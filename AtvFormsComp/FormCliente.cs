using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            // Person
            string name = txtName.Text;
            string phone = txtPhone.Text;

            // Address
            string street = txtStreet.Text;
            int number = int.Parse(txtNumber.Text);
            string city = txtCity.Text;
            string state = txtState.Text;
            string country = txtCountry.Text;

            // Segmento
            string description = txtDescription.Text;
            Cliente cliente = new Cliente();

            cliente.Nome = name;
            cliente.Telefone = phone;

            Endereco endereco = new Endereco();
            endereco.Logradouro = street;
            endereco.Numero = number;
            endereco.Cidade = city;
            endereco.Estado = state;
            endereco.Pais = country;

            Segmento segmento = new Segmento();
            segmento.Descricao = description;

            cliente.Endereco = endereco;
            cliente.Segmento = segmento;

            ClientService.addCliente(cliente);

            LoadGrid();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = ClientService.getClients();
        }

        private void ctnClearData_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
            txtDescription.Clear();
        }
    }
}
