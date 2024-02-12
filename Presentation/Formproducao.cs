using Microsoft.EntityFrameworkCore;
using RegistoMovimentos.Business_data;
using RegistoMovimentos.Facade_presentation;
using RegistoMovimentos.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistoMovimentos.Presentation
{
    public partial class Formproducao : Form
    {
        ProgramController controller = new ProgramController();
        DBWorker worker = new DBWorker();
        public Formproducao()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int id_cliente = worker.Clientes.Where(d => d.Designacao == txtNomeCliente.Text).Select(d => d.Id).FirstOrDefault();
            string debito = worker.Movimentos.Where(d => d.ClienteId == id_cliente && d.Tipo_movimentoId == 1).Max(d => d.Valor).ToString();
            string credito = worker.Movimentos.Where(d => d.ClienteId == id_cliente && d.Tipo_movimentoId == 2).Max(d => d.Valor).ToString();
            txtOutput.Text = "débito maior: " + debito + "; credito maior: " + credito;
        }

        private void Formproducao_Load(object sender, EventArgs e)
        {
            // Obter a lista de clientes do controller
            List<Cliente> listaClientes = controller.listarClientes();

            // Criar um AutoCompleteStringCollection
            AutoCompleteStringCollection autoCompleteClientes = new AutoCompleteStringCollection();

            // Adicionar o nome de cada cliente à coleção
            foreach (Cliente cliente in listaClientes)
            {
                autoCompleteClientes.Add(cliente.Designacao);
            }

            // Definir a fonte personalizada para a caixa de texto
            txtNomeCliente.AutoCompleteCustomSource = autoCompleteClientes;

            txtNomeCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}
