﻿namespace RegistoMovimentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcForm = new TabControl();
            Movimentos = new TabPage();
            btnProducao = new Button();
            btnExport_Movimentos = new Button();
            btnUpdate_Movimentos = new Button();
            btnRemove_Movimentos = new Button();
            btnAdd_Movimentos = new Button();
            dtgMovimentos = new DataGridView();
            comboBoxTipo_Movimentos = new ComboBox();
            comboBoxCliente_Movimentos = new ComboBox();
            txtDescricao_Movimentos = new TextBox();
            txtMarcador_Movimentos = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox_Movimentos = new MaskedTextBox();
            dateTimePicker_Movimentos = new DateTimePicker();
            Clientes = new TabPage();
            btnExport_Clientes = new Button();
            btnUpdate_Clientes = new Button();
            btnRemove_Clientes = new Button();
            dtgClientes = new DataGridView();
            btnEnviar_Clientes = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtMarcador_Clientes = new TextBox();
            txtDesignacao_Clientes = new TextBox();
            txtNif_Clientes = new TextBox();
            Listagens = new TabPage();
            btnExport_Listagens = new Button();
            gpxDatas_Listagens = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            cbxAnos_Listagem = new ComboBox();
            cbxMeses_Listagens = new ComboBox();
            dtpSaldo_Listagens = new DateTimePicker();
            btnSaldosMes_Listagens = new Button();
            cbxClientes_Listagens = new ComboBox();
            btnHistoricoCliente = new Button();
            gpxMarcadores_Listagens = new GroupBox();
            btnListaMarcadorCliente = new Button();
            btnListaMarcadorMovimento = new Button();
            txtMarcador_Listagens = new TextBox();
            textBox1 = new TextBox();
            chkCredito = new CheckBox();
            chkDebito = new CheckBox();
            btnListaSaldos = new Button();
            dtgListagens = new DataGridView();
            tbcForm.SuspendLayout();
            Movimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMovimentos).BeginInit();
            Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            Listagens.SuspendLayout();
            gpxDatas_Listagens.SuspendLayout();
            gpxMarcadores_Listagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListagens).BeginInit();
            SuspendLayout();
            // 
            // tbcForm
            // 
            tbcForm.Controls.Add(Movimentos);
            tbcForm.Controls.Add(Clientes);
            tbcForm.Controls.Add(Listagens);
            tbcForm.Location = new Point(12, 12);
            tbcForm.Name = "tbcForm";
            tbcForm.Padding = new Point(25, 15);
            tbcForm.SelectedIndex = 0;
            tbcForm.Size = new Size(992, 544);
            tbcForm.TabIndex = 7;
            // 
            // Movimentos
            // 
            Movimentos.BackColor = Color.Transparent;
            Movimentos.Controls.Add(btnProducao);
            Movimentos.Controls.Add(btnExport_Movimentos);
            Movimentos.Controls.Add(btnUpdate_Movimentos);
            Movimentos.Controls.Add(btnRemove_Movimentos);
            Movimentos.Controls.Add(btnAdd_Movimentos);
            Movimentos.Controls.Add(dtgMovimentos);
            Movimentos.Controls.Add(comboBoxTipo_Movimentos);
            Movimentos.Controls.Add(comboBoxCliente_Movimentos);
            Movimentos.Controls.Add(txtDescricao_Movimentos);
            Movimentos.Controls.Add(txtMarcador_Movimentos);
            Movimentos.Controls.Add(label6);
            Movimentos.Controls.Add(label5);
            Movimentos.Controls.Add(label4);
            Movimentos.Controls.Add(label3);
            Movimentos.Controls.Add(label2);
            Movimentos.Controls.Add(label1);
            Movimentos.Controls.Add(maskedTextBox_Movimentos);
            Movimentos.Controls.Add(dateTimePicker_Movimentos);
            Movimentos.Location = new Point(4, 53);
            Movimentos.Name = "Movimentos";
            Movimentos.Padding = new Padding(3);
            Movimentos.Size = new Size(984, 487);
            Movimentos.TabIndex = 0;
            Movimentos.Text = "Movimentos";
            // 
            // btnProducao
            // 
            btnProducao.Location = new Point(21, 447);
            btnProducao.Margin = new Padding(1);
            btnProducao.Name = "btnProducao";
            btnProducao.Size = new Size(88, 28);
            btnProducao.TabIndex = 19;
            btnProducao.Text = "Producao";
            btnProducao.UseVisualStyleBackColor = true;
            btnProducao.Click += btnProducao_Click;
            // 
            // btnExport_Movimentos
            // 
            btnExport_Movimentos.Location = new Point(879, 446);
            btnExport_Movimentos.Margin = new Padding(1);
            btnExport_Movimentos.Name = "btnExport_Movimentos";
            btnExport_Movimentos.Size = new Size(88, 28);
            btnExport_Movimentos.TabIndex = 18;
            btnExport_Movimentos.Text = "Exportar";
            btnExport_Movimentos.UseVisualStyleBackColor = true;
            btnExport_Movimentos.Click += btnExport_Movimentos_Click;
            // 
            // btnUpdate_Movimentos
            // 
            btnUpdate_Movimentos.Location = new Point(236, 73);
            btnUpdate_Movimentos.Name = "btnUpdate_Movimentos";
            btnUpdate_Movimentos.Size = new Size(262, 29);
            btnUpdate_Movimentos.TabIndex = 15;
            btnUpdate_Movimentos.TabStop = false;
            btnUpdate_Movimentos.Text = "Modificar Movimento Selecionado";
            btnUpdate_Movimentos.UseVisualStyleBackColor = true;
            btnUpdate_Movimentos.Click += btnUpdate_Movimentos_Click;
            // 
            // btnRemove_Movimentos
            // 
            btnRemove_Movimentos.Location = new Point(537, 73);
            btnRemove_Movimentos.Name = "btnRemove_Movimentos";
            btnRemove_Movimentos.Size = new Size(262, 29);
            btnRemove_Movimentos.TabIndex = 14;
            btnRemove_Movimentos.TabStop = false;
            btnRemove_Movimentos.Text = "Remover Movimento Selecionado";
            btnRemove_Movimentos.UseVisualStyleBackColor = true;
            btnRemove_Movimentos.Click += btnRemove_Movimentos_Click;
            // 
            // btnAdd_Movimentos
            // 
            btnAdd_Movimentos.Location = new Point(873, 73);
            btnAdd_Movimentos.Name = "btnAdd_Movimentos";
            btnAdd_Movimentos.Size = new Size(94, 29);
            btnAdd_Movimentos.TabIndex = 6;
            btnAdd_Movimentos.Text = "Enviar";
            btnAdd_Movimentos.UseVisualStyleBackColor = true;
            btnAdd_Movimentos.Click += btnAdd_Movimentos_Click;
            // 
            // dtgMovimentos
            // 
            dtgMovimentos.AllowUserToAddRows = false;
            dtgMovimentos.AllowUserToDeleteRows = false;
            dtgMovimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMovimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMovimentos.Location = new Point(21, 114);
            dtgMovimentos.Name = "dtgMovimentos";
            dtgMovimentos.RowHeadersVisible = false;
            dtgMovimentos.RowHeadersWidth = 51;
            dtgMovimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMovimentos.Size = new Size(946, 329);
            dtgMovimentos.TabIndex = 17;
            dtgMovimentos.TabStop = false;
            // 
            // comboBoxTipo_Movimentos
            // 
            comboBoxTipo_Movimentos.FormattingEnabled = true;
            comboBoxTipo_Movimentos.Location = new Point(816, 39);
            comboBoxTipo_Movimentos.Name = "comboBoxTipo_Movimentos";
            comboBoxTipo_Movimentos.Size = new Size(151, 28);
            comboBoxTipo_Movimentos.TabIndex = 5;
            // 
            // comboBoxCliente_Movimentos
            // 
            comboBoxCliente_Movimentos.FormattingEnabled = true;
            comboBoxCliente_Movimentos.Location = new Point(618, 38);
            comboBoxCliente_Movimentos.Name = "comboBoxCliente_Movimentos";
            comboBoxCliente_Movimentos.Size = new Size(181, 28);
            comboBoxCliente_Movimentos.TabIndex = 4;
            // 
            // txtDescricao_Movimentos
            // 
            txtDescricao_Movimentos.Location = new Point(480, 37);
            txtDescricao_Movimentos.Name = "txtDescricao_Movimentos";
            txtDescricao_Movimentos.Size = new Size(125, 27);
            txtDescricao_Movimentos.TabIndex = 3;
            // 
            // txtMarcador_Movimentos
            // 
            txtMarcador_Movimentos.Location = new Point(401, 37);
            txtMarcador_Movimentos.Name = "txtMarcador_Movimentos";
            txtMarcador_Movimentos.Size = new Size(50, 27);
            txtMarcador_Movimentos.TabIndex = 2;
            txtMarcador_Movimentos.TextChanged += txtMarcador_Movimentos_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(816, 14);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 7;
            label6.Text = "Tipo (Crédito / Débito)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 14);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 14);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 14);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Marcador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 14);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 2;
            label1.Text = "Data";
            // 
            // maskedTextBox_Movimentos
            // 
            maskedTextBox_Movimentos.Location = new Point(255, 37);
            maskedTextBox_Movimentos.Name = "maskedTextBox_Movimentos";
            maskedTextBox_Movimentos.Size = new Size(125, 27);
            maskedTextBox_Movimentos.TabIndex = 1;
            // 
            // dateTimePicker_Movimentos
            // 
            dateTimePicker_Movimentos.Checked = false;
            dateTimePicker_Movimentos.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_Movimentos.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Movimentos.Location = new Point(21, 37);
            dateTimePicker_Movimentos.Name = "dateTimePicker_Movimentos";
            dateTimePicker_Movimentos.Size = new Size(215, 27);
            dateTimePicker_Movimentos.TabIndex = 0;
            // 
            // Clientes
            // 
            Clientes.Controls.Add(btnExport_Clientes);
            Clientes.Controls.Add(btnUpdate_Clientes);
            Clientes.Controls.Add(btnRemove_Clientes);
            Clientes.Controls.Add(dtgClientes);
            Clientes.Controls.Add(btnEnviar_Clientes);
            Clientes.Controls.Add(label9);
            Clientes.Controls.Add(label8);
            Clientes.Controls.Add(label7);
            Clientes.Controls.Add(txtMarcador_Clientes);
            Clientes.Controls.Add(txtDesignacao_Clientes);
            Clientes.Controls.Add(txtNif_Clientes);
            Clientes.Location = new Point(4, 53);
            Clientes.Name = "Clientes";
            Clientes.Padding = new Padding(3);
            Clientes.Size = new Size(984, 487);
            Clientes.TabIndex = 1;
            Clientes.Text = "Clientes";
            Clientes.UseVisualStyleBackColor = true;
            // 
            // btnExport_Clientes
            // 
            btnExport_Clientes.Location = new Point(879, 447);
            btnExport_Clientes.Margin = new Padding(1);
            btnExport_Clientes.Name = "btnExport_Clientes";
            btnExport_Clientes.Size = new Size(88, 28);
            btnExport_Clientes.TabIndex = 19;
            btnExport_Clientes.Text = "Exportar";
            btnExport_Clientes.UseVisualStyleBackColor = true;
            btnExport_Clientes.Click += btnExport_Clientes_Click;
            // 
            // btnUpdate_Clientes
            // 
            btnUpdate_Clientes.Location = new Point(413, 71);
            btnUpdate_Clientes.Name = "btnUpdate_Clientes";
            btnUpdate_Clientes.Size = new Size(270, 29);
            btnUpdate_Clientes.TabIndex = 9;
            btnUpdate_Clientes.TabStop = false;
            btnUpdate_Clientes.Text = "Atualizar Cliente Selecionado";
            btnUpdate_Clientes.UseVisualStyleBackColor = true;
            btnUpdate_Clientes.Click += btnUpdate_Clientes_Click;
            // 
            // btnRemove_Clientes
            // 
            btnRemove_Clientes.Location = new Point(109, 71);
            btnRemove_Clientes.Name = "btnRemove_Clientes";
            btnRemove_Clientes.Size = new Size(270, 29);
            btnRemove_Clientes.TabIndex = 8;
            btnRemove_Clientes.TabStop = false;
            btnRemove_Clientes.Text = "Remover Clientes Selecionados";
            btnRemove_Clientes.UseVisualStyleBackColor = true;
            btnRemove_Clientes.Click += btnRemove_Clientes_Click;
            // 
            // dtgClientes
            // 
            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AllowUserToDeleteRows = false;
            dtgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Location = new Point(21, 114);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.RowHeadersVisible = false;
            dtgClientes.RowHeadersWidth = 51;
            dtgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClientes.Size = new Size(946, 329);
            dtgClientes.TabIndex = 7;
            dtgClientes.TabStop = false;
            // 
            // btnEnviar_Clientes
            // 
            btnEnviar_Clientes.Location = new Point(864, 26);
            btnEnviar_Clientes.Name = "btnEnviar_Clientes";
            btnEnviar_Clientes.Size = new Size(94, 29);
            btnEnviar_Clientes.TabIndex = 3;
            btnEnviar_Clientes.Text = "Enviar";
            btnEnviar_Clientes.UseVisualStyleBackColor = true;
            btnEnviar_Clientes.Click += btnEnviar_Clientes_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(756, 7);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 5;
            label9.Text = "Marcador";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 7);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 4;
            label8.Text = "Designação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 7);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 3;
            label7.Text = "NIF";
            // 
            // txtMarcador_Clientes
            // 
            txtMarcador_Clientes.Location = new Point(773, 30);
            txtMarcador_Clientes.Name = "txtMarcador_Clientes";
            txtMarcador_Clientes.Size = new Size(36, 27);
            txtMarcador_Clientes.TabIndex = 2;
            txtMarcador_Clientes.TextChanged += txtMarcador_Clientes_TextChanged;
            // 
            // txtDesignacao_Clientes
            // 
            txtDesignacao_Clientes.Location = new Point(242, 30);
            txtDesignacao_Clientes.Name = "txtDesignacao_Clientes";
            txtDesignacao_Clientes.Size = new Size(374, 27);
            txtDesignacao_Clientes.TabIndex = 1;
            // 
            // txtNif_Clientes
            // 
            txtNif_Clientes.Location = new Point(19, 30);
            txtNif_Clientes.Name = "txtNif_Clientes";
            txtNif_Clientes.Size = new Size(205, 27);
            txtNif_Clientes.TabIndex = 0;
            // 
            // Listagens
            // 
            Listagens.Controls.Add(btnExport_Listagens);
            Listagens.Controls.Add(gpxDatas_Listagens);
            Listagens.Controls.Add(gpxMarcadores_Listagens);
            Listagens.Controls.Add(chkCredito);
            Listagens.Controls.Add(chkDebito);
            Listagens.Controls.Add(btnListaSaldos);
            Listagens.Controls.Add(dtgListagens);
            Listagens.Location = new Point(4, 53);
            Listagens.Name = "Listagens";
            Listagens.Padding = new Padding(3);
            Listagens.Size = new Size(984, 487);
            Listagens.TabIndex = 2;
            Listagens.Text = "Listagens";
            Listagens.UseVisualStyleBackColor = true;
            // 
            // btnExport_Listagens
            // 
            btnExport_Listagens.Location = new Point(879, 455);
            btnExport_Listagens.Margin = new Padding(1);
            btnExport_Listagens.Name = "btnExport_Listagens";
            btnExport_Listagens.Size = new Size(88, 28);
            btnExport_Listagens.TabIndex = 19;
            btnExport_Listagens.Text = "Exportar";
            btnExport_Listagens.UseVisualStyleBackColor = true;
            btnExport_Listagens.Click += btnExport_Listagens_Click;
            // 
            // gpxDatas_Listagens
            // 
            gpxDatas_Listagens.Controls.Add(label11);
            gpxDatas_Listagens.Controls.Add(label10);
            gpxDatas_Listagens.Controls.Add(cbxAnos_Listagem);
            gpxDatas_Listagens.Controls.Add(cbxMeses_Listagens);
            gpxDatas_Listagens.Controls.Add(dtpSaldo_Listagens);
            gpxDatas_Listagens.Controls.Add(btnSaldosMes_Listagens);
            gpxDatas_Listagens.Controls.Add(cbxClientes_Listagens);
            gpxDatas_Listagens.Controls.Add(btnHistoricoCliente);
            gpxDatas_Listagens.Location = new Point(174, 1);
            gpxDatas_Listagens.Margin = new Padding(1);
            gpxDatas_Listagens.Name = "gpxDatas_Listagens";
            gpxDatas_Listagens.Padding = new Padding(1);
            gpxDatas_Listagens.Size = new Size(488, 109);
            gpxDatas_Listagens.TabIndex = 3;
            gpxDatas_Listagens.TabStop = false;
            gpxDatas_Listagens.Text = "Listagem por datas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 44);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 10;
            label11.Text = "Mês";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 44);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 9;
            label10.Text = "Ano";
            // 
            // cbxAnos_Listagem
            // 
            cbxAnos_Listagem.FormattingEnabled = true;
            cbxAnos_Listagem.Location = new Point(3, 69);
            cbxAnos_Listagem.Margin = new Padding(1);
            cbxAnos_Listagem.Name = "cbxAnos_Listagem";
            cbxAnos_Listagem.Size = new Size(77, 28);
            cbxAnos_Listagem.TabIndex = 6;
            // 
            // cbxMeses_Listagens
            // 
            cbxMeses_Listagens.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxMeses_Listagens.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMeses_Listagens.FormattingEnabled = true;
            cbxMeses_Listagens.Items.AddRange(new object[] { "*", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxMeses_Listagens.Location = new Point(81, 69);
            cbxMeses_Listagens.Margin = new Padding(1);
            cbxMeses_Listagens.Name = "cbxMeses_Listagens";
            cbxMeses_Listagens.Size = new Size(39, 28);
            cbxMeses_Listagens.TabIndex = 7;
            // 
            // dtpSaldo_Listagens
            // 
            dtpSaldo_Listagens.CustomFormat = "dd/MM/yyyy";
            dtpSaldo_Listagens.Format = DateTimePickerFormat.Custom;
            dtpSaldo_Listagens.Location = new Point(178, 27);
            dtpSaldo_Listagens.Margin = new Padding(1);
            dtpSaldo_Listagens.Name = "dtpSaldo_Listagens";
            dtpSaldo_Listagens.Size = new Size(117, 27);
            dtpSaldo_Listagens.TabIndex = 4;
            // 
            // btnSaldosMes_Listagens
            // 
            btnSaldosMes_Listagens.Location = new Point(306, 25);
            btnSaldosMes_Listagens.Margin = new Padding(1);
            btnSaldosMes_Listagens.Name = "btnSaldosMes_Listagens";
            btnSaldosMes_Listagens.Size = new Size(170, 28);
            btnSaldosMes_Listagens.TabIndex = 5;
            btnSaldosMes_Listagens.Text = "Consulta saldo até data";
            btnSaldosMes_Listagens.UseVisualStyleBackColor = true;
            btnSaldosMes_Listagens.Click += btnSaldosMes_Listagens_Click;
            // 
            // cbxClientes_Listagens
            // 
            cbxClientes_Listagens.FormattingEnabled = true;
            cbxClientes_Listagens.Location = new Point(122, 69);
            cbxClientes_Listagens.Name = "cbxClientes_Listagens";
            cbxClientes_Listagens.Size = new Size(173, 28);
            cbxClientes_Listagens.TabIndex = 8;
            // 
            // btnHistoricoCliente
            // 
            btnHistoricoCliente.Location = new Point(306, 66);
            btnHistoricoCliente.Name = "btnHistoricoCliente";
            btnHistoricoCliente.Size = new Size(170, 29);
            btnHistoricoCliente.TabIndex = 9;
            btnHistoricoCliente.Text = "Histórico de movimentos";
            btnHistoricoCliente.UseVisualStyleBackColor = true;
            btnHistoricoCliente.Click += btnHistoricoCliente_Click;
            // 
            // gpxMarcadores_Listagens
            // 
            gpxMarcadores_Listagens.Controls.Add(btnListaMarcadorCliente);
            gpxMarcadores_Listagens.Controls.Add(btnListaMarcadorMovimento);
            gpxMarcadores_Listagens.Controls.Add(txtMarcador_Listagens);
            gpxMarcadores_Listagens.Controls.Add(textBox1);
            gpxMarcadores_Listagens.Location = new Point(670, 1);
            gpxMarcadores_Listagens.Margin = new Padding(1);
            gpxMarcadores_Listagens.Name = "gpxMarcadores_Listagens";
            gpxMarcadores_Listagens.Padding = new Padding(1);
            gpxMarcadores_Listagens.Size = new Size(311, 109);
            gpxMarcadores_Listagens.TabIndex = 10;
            gpxMarcadores_Listagens.TabStop = false;
            gpxMarcadores_Listagens.Text = "Marcadores";
            // 
            // btnListaMarcadorCliente
            // 
            btnListaMarcadorCliente.Location = new Point(46, 27);
            btnListaMarcadorCliente.Name = "btnListaMarcadorCliente";
            btnListaMarcadorCliente.Size = new Size(259, 23);
            btnListaMarcadorCliente.TabIndex = 12;
            btnListaMarcadorCliente.Text = "Listar por marcador em cliente";
            btnListaMarcadorCliente.UseVisualStyleBackColor = true;
            btnListaMarcadorCliente.Click += btnListaMarcadorCliente_Click;
            // 
            // btnListaMarcadorMovimento
            // 
            btnListaMarcadorMovimento.Location = new Point(46, 68);
            btnListaMarcadorMovimento.Name = "btnListaMarcadorMovimento";
            btnListaMarcadorMovimento.Size = new Size(259, 23);
            btnListaMarcadorMovimento.TabIndex = 14;
            btnListaMarcadorMovimento.Text = "Listar por marcador em movimento";
            btnListaMarcadorMovimento.UseVisualStyleBackColor = true;
            btnListaMarcadorMovimento.Click += btnListaMarcadorMovimento_Click;
            // 
            // txtMarcador_Listagens
            // 
            txtMarcador_Listagens.Location = new Point(4, 27);
            txtMarcador_Listagens.Name = "txtMarcador_Listagens";
            txtMarcador_Listagens.Size = new Size(38, 27);
            txtMarcador_Listagens.TabIndex = 11;
            txtMarcador_Listagens.TextChanged += txtMarcador_Listagens_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // chkCredito
            // 
            chkCredito.AutoSize = true;
            chkCredito.Checked = true;
            chkCredito.CheckState = CheckState.Checked;
            chkCredito.Location = new Point(100, 47);
            chkCredito.Name = "chkCredito";
            chkCredito.Size = new Size(80, 24);
            chkCredito.TabIndex = 2;
            chkCredito.Text = "Crédito";
            chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            chkDebito.AutoSize = true;
            chkDebito.Checked = true;
            chkDebito.CheckState = CheckState.Checked;
            chkDebito.Location = new Point(17, 47);
            chkDebito.Name = "chkDebito";
            chkDebito.Size = new Size(77, 24);
            chkDebito.TabIndex = 1;
            chkDebito.Text = "Débito";
            chkDebito.UseVisualStyleBackColor = true;
            // 
            // btnListaSaldos
            // 
            btnListaSaldos.Location = new Point(3, 3);
            btnListaSaldos.Name = "btnListaSaldos";
            btnListaSaldos.Size = new Size(156, 29);
            btnListaSaldos.TabIndex = 0;
            btnListaSaldos.Text = "Resumo por cliente";
            btnListaSaldos.UseVisualStyleBackColor = true;
            btnListaSaldos.Click += btnListaSaldos_Click;
            // 
            // dtgListagens
            // 
            dtgListagens.AllowDrop = true;
            dtgListagens.AllowUserToAddRows = false;
            dtgListagens.AllowUserToDeleteRows = false;
            dtgListagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListagens.Location = new Point(21, 114);
            dtgListagens.Name = "dtgListagens";
            dtgListagens.ReadOnly = true;
            dtgListagens.RowHeadersVisible = false;
            dtgListagens.RowHeadersWidth = 51;
            dtgListagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListagens.Size = new Size(946, 329);
            dtgListagens.TabIndex = 15;
            dtgListagens.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(tbcForm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tbcForm.ResumeLayout(false);
            Movimentos.ResumeLayout(false);
            Movimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMovimentos).EndInit();
            Clientes.ResumeLayout(false);
            Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            Listagens.ResumeLayout(false);
            Listagens.PerformLayout();
            gpxDatas_Listagens.ResumeLayout(false);
            gpxDatas_Listagens.PerformLayout();
            gpxMarcadores_Listagens.ResumeLayout(false);
            gpxMarcadores_Listagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListagens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcForm;
        private TabPage Movimentos;
        private TabPage Clientes;
        private TabPage Listagens;
        private DateTimePicker dateTimePicker_Movimentos;
        private MaskedTextBox maskedTextBox_Movimentos;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMarcador_Movimentos;
        private DataGridView dtgMovimentos;
        private ComboBox comboBoxTipo_Movimentos;
        private ComboBox comboBoxCliente_Movimentos;
        private TextBox txtDescricao_Movimentos;
        private Button btnUpdate_Movimentos;
        private Button btnRemove_Movimentos;
        private Button btnAdd_Movimentos;
        private TextBox txtDesignacao_Clientes;
        private TextBox txtNif_Clientes;
        private TextBox txtMarcador_Clientes;
        private Button btnUpdate_Clientes;
        private Button btnRemove_Clientes;
        private DataGridView dtgClientes;
        private Button btnEnviar_Clientes;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dtgListagens;
        private Button btnListaMarcadorCliente;
        private TextBox txtMarcador_Listagens;
        private Button btnListaMarcadorMovimento;
        private TextBox textBox1;
        private Button btnListaSaldos;
        private ComboBox cbxClientes_Listagens;
        private Button btnHistoricoCliente;
        private CheckBox chkCredito;
        private CheckBox chkDebito;
        private GroupBox gpxMarcadores_Listagens;
        private GroupBox gpxDatas_Listagens;
        private Button btnSaldosMes_Listagens;
        private ComboBox cbxMeses_Listagens;
        private DateTimePicker dtpSaldo_Listagens;
        private ComboBox cbxAnos_Listagem;
        private Label label11;
        private Label label10;
        private Button btnExport_Movimentos;
        private Button btnExport_Clientes;
        private Button btnExport_Listagens;
        private Button btnProducao;
    }
}
