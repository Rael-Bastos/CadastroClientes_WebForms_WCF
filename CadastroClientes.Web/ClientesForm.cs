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
    public partial class ClientesForm : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView dataGridViewClientes = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button editNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        private Button recarregarRowButtoon = new Button();
        private IClienteService _clienteService = new ClienteService();

        public ClientesForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
        }

        private void dataGridViewClientes_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.dataGridViewClientes.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void AdicionarBtn_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroForm = new CadastroClienteForm();
            cadastroForm.ShowDialog();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {

            var idCliente = this.dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value;
            var cliente = _clienteService.GetClient(Convert.ToInt32(idCliente));

            var editarForm = new EditarClienteForm(cliente);
            editarForm.ShowDialog();

        }

        private void DeletarBtn_Click(object sender, EventArgs e)
        {
            var idCliente = this.dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value;
            _clienteService.DeleteClient(Convert.ToInt32(idCliente));

            RegarregaDados();

        }


        private void SetupLayout()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 292);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);



            this.Size = new Size(600, 500);

            addNewRowButton.Text = "Adicionar";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(AdicionarBtn_Click);

            editNewRowButton.Text = "Editar";
            editNewRowButton.Location = new Point(100, 10);
            editNewRowButton.Click += new EventHandler(EditarBtn_Click);

            deleteRowButton.Text = "Deletar";
            deleteRowButton.Location = new Point(200, 10);
            deleteRowButton.Click += new EventHandler(DeletarBtn_Click);

            recarregarRowButtoon.Text = "Recarregar";
            recarregarRowButtoon.Location = new Point(500, 10);
            recarregarRowButtoon.Click += new EventHandler(RegarregaDados);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(editNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Controls.Add(recarregarRowButtoon);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);

            this.Load += new System.EventHandler(this.RegarregaDados);
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(dataGridViewClientes);

            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridViewClientes.Font, FontStyle.Bold);

            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Location = new Point(8, 8);
            dataGridViewClientes.Size = new Size(500, 250);
            dataGridViewClientes.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewClientes.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewClientes.GridColor = Color.Black;
            dataGridViewClientes.RowHeadersVisible = false;


            dataGridViewClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Dock = DockStyle.Fill;

            dataGridViewClientes.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                dataGridViewClientes_CellFormatting);
        }

        private void RegarregaDados()
        {
            var clientes = _clienteService.GetClients();
            dataGridViewClientes.DataSource = clientes;
        }
        private void RegarregaDados(object sender, EventArgs e)
        {
            var clientes = _clienteService.GetClients();
            dataGridViewClientes.DataSource = clientes;
        }
    }
}
