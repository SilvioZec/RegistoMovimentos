using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using RegistoMovimentos.Business_code;
using RegistoMovimentos.Business_data;
using RegistoMovimentos.Facade_presentation;
using RegistoMovimentos.Presentation;
using System.Globalization;
using System.Windows.Forms;

namespace RegistoMovimentos
{
    public partial class Form1 : Form
    {
        //============================================================================================================================== INSTANCIA FACADE / INICIALIZE COMPONENTS
        ProgramController controller = new ProgramController();
        public Form1()
        {
            InitializeComponent();
        }


        //============================================================================================================================== FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //carrega Datagrids
            atualizaDtgMovimentos();
            atualizaDtgClientes();
            //lida com dataerror dos datagrids
            dtgClientes.DataError += dtgClientes_DataError;
            dtgMovimentos.DataError += dtgMovimentos_DataError;
            //carregar as comboboxes de Clientes.
            atualizaCbxCliente_Movimentos();
            atualizaCbxClientes_Listagens();
            //carrega combobox listagens com anos
            atualizaCbxAnos_Listagens();
            cbxMeses_Listagens.SelectedIndex = 0;

            //carregar as comboboxes de tipo_movimento.
            List<object> tiposMovimento = new List<object>
            {
                new { ValueMember = 1, DisplayMember = "Débito" },
                new { ValueMember = 2, DisplayMember = "Crédito" }
            };
            comboBoxTipo_Movimentos.DataSource = tiposMovimento;
            comboBoxTipo_Movimentos.ValueMember = "ValueMember";
            comboBoxTipo_Movimentos.DisplayMember = "DisplayMember";

            // Habilita o recurso de autocomplete na ComboBox
            comboBoxTipo_Movimentos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTipo_Movimentos.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        //============================================================================================================================== METODOS UTEIS A CLASSE
        private void atualizaDtgClientes()
        {
            dtgClientes.DataSource = controller.listarClientes();
            dtgClientes.Columns["Id"].ReadOnly = true;
        }
        private void limpaBoxesCliente()
        {
            txtNif_Clientes.Clear();
            txtDesignacao_Clientes.Clear();
            txtMarcador_Clientes.Clear();
        }

        //============================================================================================================================== TAB CLIENTES
        private void btnEnviar_Clientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nif = txtNif_Clientes.Text;
            cliente.Designacao = txtDesignacao_Clientes.Text;
            cliente.Marcador = string.IsNullOrEmpty(txtMarcador_Clientes.Text) ? null : Convert.ToChar(txtMarcador_Clientes.Text.ToUpper());

            controller.add(cliente);

            atualizaDtgClientes();
            atualizaCbxCliente_Movimentos();
            atualizaCbxClientes_Listagens();
            limpaBoxesCliente();
        }

        private void btnRemove_Clientes_Click(object sender, EventArgs e)
        {
            // Obtem a linha selecionada da DataGridView
            DataGridViewRow row = dtgClientes.SelectedRows[0];

            // Obtem o cliente associado à linha selecionada
            Cliente cliente = (Cliente)row.DataBoundItem;

            // Remove o cliente da lista de clientes
            controller.remove(cliente);

            // Atualiza a DataGridView
            atualizaDtgClientes();
            atualizaCbxCliente_Movimentos();
            atualizaCbxClientes_Listagens();
        }

        private void txtMarcador_Clientes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 1)
            {
                // Se houver mais de um caractere, mantem apenas o primeiro caractere e remove o restante
                textBox.Text = textBox.Text.Substring(0, 1);
                textBox.Select(1, 0); // Coloca o cursor no final do texto
            }
        }

        private void btnUpdate_Clientes_Click(object sender, EventArgs e)
        {
            // Obtem a linha selecionada da DataGridView
            DataGridViewRow row = dtgClientes.SelectedRows[0];

            // Obtem o cliente associado à linha selecionada
            Cliente cliente = (Cliente)row.DataBoundItem;

            //atualiza cliente
            cliente.Nif = dtgClientes.SelectedRows[0].Cells[1].Value.ToString();
            cliente.Designacao = dtgClientes.SelectedRows[0].Cells[2].Value.ToString();
            cliente.Marcador = Convert.ToChar(dtgClientes.SelectedRows[0].Cells[3].Value.ToString().ToUpper());

            //realiza update
            controller.update(cliente);
            atualizaDtgClientes();
            atualizaCbxCliente_Movimentos();
            atualizaCbxClientes_Listagens();

        }

        private void dtgClientes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ocorreu um erro ao modificar os dados do DataGrid. Por favor, verifique que apenas uma letra pode ser inserida na coluna Marcador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //============================================================================================================================== TAB MOVIMENTOS
        /// <summary>
        /// carrega combobox clientes da aba movimentos com database
        /// </summary>
        private void atualizaCbxCliente_Movimentos()
        {
            comboBoxCliente_Movimentos.DataSource = controller.listarClientes();
            comboBoxCliente_Movimentos.DisplayMember = "Designacao";
            comboBoxCliente_Movimentos.ValueMember = "Id";

            // Habilita o recurso de autocomplete na ComboBox
            comboBoxCliente_Movimentos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCliente_Movimentos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void atualizaDtgMovimentos()
        {
            List<Movimento_datagrid> lista = controller.listarMovimentos();
            dtgMovimentos.DataSource = lista;
            dtgMovimentos.Columns["Id"].ReadOnly = true;
            dtgMovimentos.Columns["Cliente"].ReadOnly = true;
            dtgMovimentos.Columns["TipoMovimento"].ReadOnly = true;

            if (lista.Count > 0)
            {
                dtgMovimentos.FirstDisplayedScrollingRowIndex = lista.Count - 1;
            }
        }
        private void btnAdd_Movimentos_Click(object sender, EventArgs e)
        {
            Movimento movimento = new Movimento();
            movimento.Data = Convert.ToDateTime(dateTimePicker_Movimentos.Value.Date.ToShortDateString());
            movimento.Valor = Convert.ToDecimal(maskedTextBox_Movimentos.Text);
            movimento.Marcador = string.IsNullOrEmpty(txtMarcador_Movimentos.Text) ? null : Convert.ToChar(txtMarcador_Movimentos.Text.ToUpper());
            movimento.Descricao = txtDescricao_Movimentos.Text;
            movimento.Tipo_movimentoId = Convert.ToInt32(comboBoxTipo_Movimentos.SelectedValue);
            movimento.ClienteId = Convert.ToInt32(comboBoxCliente_Movimentos.SelectedValue);

            controller.add(movimento);
            atualizaDtgMovimentos();
            maskedTextBox_Movimentos.Clear();
            txtMarcador_Movimentos.Clear();
            txtDescricao_Movimentos.Clear();

            //atualiza combobox Listagem de anos, para caso um novo ano seja adicionado
            atualizaCbxAnos_Listagens();
        }
        private void btnRemove_Movimentos_Click(object sender, EventArgs e)
        {
            controller.remove(Convert.ToInt32(dtgMovimentos.SelectedRows[0].Cells[0].Value));
            atualizaDtgMovimentos();

            //atualiza combobox Listagem de anos, para caso um novo ano seja removido
            atualizaCbxAnos_Listagens();
        }
        private void txtMarcador_Movimentos_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 1)
            {
                // Se houver mais de um caractere, mantem apenas o primeiro caractere e remove o restante
                textBox.Text = textBox.Text.Substring(0, 1);
                textBox.Select(1, 0); // Coloca o cursor no final do texto
            }
        }

        private void btnUpdate_Movimentos_Click(object sender, EventArgs e)
        {
            Movimento movimento = controller.buscarMovimento(Convert.ToInt32(dtgMovimentos.SelectedRows[0].Cells[0].Value));
            movimento.Data = DateTime.ParseExact(dtgMovimentos.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            movimento.Valor = Convert.ToDecimal(dtgMovimentos.SelectedRows[0].Cells[2].Value);
            movimento.Marcador = Convert.ToChar(dtgMovimentos.SelectedRows[0].Cells[3].Value);
            movimento.Descricao = dtgMovimentos.SelectedRows[0].Cells[4].Value.ToString();

            controller.update(movimento);

            atualizaDtgMovimentos();

            //atualiza combobox Listagem de anos, para caso um novo ano seja adicionado/removido
            atualizaCbxAnos_Listagens();
        }
        private void dtgMovimentos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ocorreu um erro ao modificar os dados do DataGrid. Por favor, verifique que apenas uma letra pode ser inserida na coluna Marcador ou se valor esta separado por virgula (ex.: 00,00).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //============================================================================================================================== TAB LISTAGENS
        private void atualizaCbxAnos_Listagens()
        {
            cbxAnos_Listagem.DataSource = controller.listarAnosMovimentos();
            cbxAnos_Listagem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAnos_Listagem.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void atualizaCbxClientes_Listagens()
        {
            cbxClientes_Listagens.DataSource = controller.listarClientes();
            cbxClientes_Listagens.DisplayMember = "Designacao";
            cbxClientes_Listagens.ValueMember = "Id";

            // Habilita o recurso de autocomplete na ComboBox
            cbxClientes_Listagens.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxClientes_Listagens.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnListaSaldos_Click(object sender, EventArgs e)
        {
            dtgListagens.DataSource = controller.listarSaldos(chkDebito.Checked, chkCredito.Checked);
        }
        // impede que mais de um char seja introduzido na textbox
        private void txtMarcador_Listagens_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 1)
            {
                // Se houver mais de um caractere, mantem apenas o primeiro caractere e remove o restante
                textBox.Text = textBox.Text.Substring(0, 1);
                textBox.Select(1, 0); // Coloca o cursor no final do texto
            }
        }
        // impede que mais de um char seja introduzido na textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 1)
            {
                // Se houver mais de um caractere, mantem apenas o primeiro caractere e remove o restante
                textBox.Text = textBox.Text.Substring(0, 1);
                textBox.Select(1, 0); // Coloca o cursor no final do texto
            }
        }

        private void btnHistoricoCliente_Click(object sender, EventArgs e)
        {
            if (cbxMeses_Listagens.Text == "*" && cbxAnos_Listagem.Text == "Todos")
            {
                dtgListagens.DataSource = controller.listarMovimentosCliente(Convert.ToInt32(cbxClientes_Listagens.SelectedValue));
            }
            if (cbxMeses_Listagens.Text != "*" && cbxAnos_Listagem.Text == "Todos")
            {
                MessageBox.Show("Escolha o ano para listar um mês", "Erro");
            }
            if (cbxMeses_Listagens.Text != "*" && cbxAnos_Listagem.Text != "Todos")
            {
                dtgListagens.DataSource = controller.listarMovimentosCliente(Convert.ToInt32(cbxClientes_Listagens.SelectedValue), cbxAnos_Listagem.Text, cbxMeses_Listagens.Text);
            }
            if (cbxMeses_Listagens.Text == "*" && cbxAnos_Listagem.Text != "Todos")
            {
                dtgListagens.DataSource = controller.listarMovimentosCliente(Convert.ToInt32(cbxClientes_Listagens.SelectedValue), cbxAnos_Listagem.Text);
            }
        }

        private void btnListaMarcadorCliente_Click(object sender, EventArgs e)
        {
            dtgListagens.DataSource = controller.listarClienteMarcador(string.IsNullOrEmpty(txtMarcador_Listagens.Text) ? null : Convert.ToChar(txtMarcador_Listagens.Text.ToUpper()));
        }

        private void btnListaMarcadorMovimento_Click(object sender, EventArgs e)
        {
            dtgListagens.DataSource = controller.listarMovimentoMarcador(string.IsNullOrEmpty(textBox1.Text) ? null : Convert.ToChar(textBox1.Text.ToUpper()));
        }

        private void btnSaldosMes_Listagens_Click(object sender, EventArgs e)
        {
            dtgListagens.DataSource = controller.listarSaldosData(dtpSaldo_Listagens.Value);
        }

        private void btnExport_Movimentos_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Define as configurações do SaveFileDialog
            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Ficheiro PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Escolha o local para salvar o arquivo";
            saveFileDialog.FileName = "NomeDoArquivo";

            // Abre a janela de diálogo para salvar o arquivo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Chama a função Exportar passando o DataGridView, o caminho e o nome do arquivo e tipo
                controller.exportar(dtgMovimentos, Path.GetDirectoryName(saveFileDialog.FileName), Path.GetFileNameWithoutExtension(saveFileDialog.FileName), saveFileDialog.FilterIndex);
            }
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            Formproducao form = new Formproducao();
            form.Show();
        }
    }

}
