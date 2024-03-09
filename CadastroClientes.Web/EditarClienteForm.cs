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
    public partial class EditarClienteForm : Form
    {
        private IClienteService _clienteService;
        private Cliente _cliente;
        private int idCliente;
        public EditarClienteForm(Cliente cliente)
        {
            _cliente = cliente;
            _clienteService = new ClienteService();
            InitializeComponent();
            this.Load += new EventHandler(EditarClienteForm_Load);
        }

        private void EditarClienteForm_Load(object sender, EventArgs e)
        {
            idCliente = _cliente.IdCliente;
            inputCpf.Text = _cliente.CPF;
            inputNome.Text = _cliente.Nome;
            inputRg.Text = _cliente.RG;
            inputDtExpedicao.Text = _cliente.DataExpedicao?.ToString("dd/MM/yyyy");
            inputOrgExpedicao.Text = _cliente.OrgaoExpedicao;
            inputUfEx.Text = _cliente.UFExpedicao;
            inputDtNascimento.Text = _cliente.DataNascimento.ToString("dd/MM/yyyy");
            inputSexo.Text = _cliente.Sexo;
            inputEstadoCivil.Text = _cliente.EstadoCivil;
            inputCep.Text = _cliente.EnderecoCliente.CEP;
            inputLogradouro.Text = _cliente.EnderecoCliente.Logradouro;
            inputNumero.Text = _cliente.EnderecoCliente.Numero;
            inputComplemento.Text = _cliente.EnderecoCliente.Complemento;
            inputBairro.Text = _cliente.EnderecoCliente.Bairro;
            inputCidade.Text = _cliente.EnderecoCliente.Cidade;
            inputUf.Text = _cliente.EnderecoCliente.UF;
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente()
            {
                IdCliente = idCliente,
                CPF = inputCpf.Text,
                Nome = inputNome.Text,
                RG = inputRg.Text,
                DataExpedicao = Convert.ToDateTime(inputDtExpedicao.Text),
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

            _clienteService.UpdateClient(cliente);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region SemUso

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
