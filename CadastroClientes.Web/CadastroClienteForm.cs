using CadastroClientes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace CadastroClientes.Web
{
    public partial class CadastroClienteForm : Form
    {
        private IClienteService _clienteService;
        public CadastroClienteForm()
        {
            _clienteService = new ClienteService();
            InitializeComponent();
            this.Load += new EventHandler(ClienteForm_Load);
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dtExp = new DateTime(); dtExp = null;
                if(string.IsNullOrEmpty(inputDtExpedicao.Text)) { dtExp = Convert.ToDateTime(inputDtExpedicao.Text); };
                var cliente = new Cliente()
                {
                    IdCliente = 0,
                    CPF = inputCpf.Text,
                    Nome = inputNome.Text,
                    RG = inputRg.Text,
                    DataExpedicao = dtExp,
                    OrgaoExpedicao = inputOrgExpedicao.Text,
                    UFExpedicao = inputUfEx.Text,
                    DataNascimento = Convert.ToDateTime(inputDtNascimento.Text),
                    Sexo = inputSexo.Text,
                    EstadoCivil = inputEstadoCivil.Text,
                    EnderecoCliente = new EnderecoCliente()
                    {
                        CEP = inputCep.Text,
                        Logradouro = inputLogradouro.Text,
                        Numero = inputNumero.Text,
                        Complemento = inputComplemento.Text,
                        Bairro = inputBairro.Text,
                        Cidade = inputCidade.Text,
                        UF = inputUf.Text,
                    }
                };

                _clienteService.InsertClient(cliente);

                this.Hide();
                this.Hide();
            }
            catch (Exception ex)
            {
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
