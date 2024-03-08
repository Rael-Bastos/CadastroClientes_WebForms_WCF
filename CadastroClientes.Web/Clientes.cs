using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes.Web
{
    public partial class Clientes : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView dataGridViewClientes = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();

        public Clientes()
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

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroForm = new CadastroClienteForm();
            cadastroForm.Show();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewClientes.SelectedRows.Count > 0 &&
                this.dataGridViewClientes.SelectedRows[0].Index !=
                this.dataGridViewClientes.Rows.Count - 1)
            {
                this.dataGridViewClientes.Rows.RemoveAt(
                    this.dataGridViewClientes.SelectedRows[0].Index);
            }
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);

            addNewRowButton.Text = "Add Row";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
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
    }
}
