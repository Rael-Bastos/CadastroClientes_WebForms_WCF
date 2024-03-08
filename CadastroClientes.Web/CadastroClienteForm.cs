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
    public partial class CadastroClienteForm : Form
    {
        public CadastroClienteForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ClienteForm_Load);
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            // Adicione itens fictícios ao ListBox
            listBoxClientes.Items.AddRange(new object[] {"SSP","Detran","PF","CC"});

            // Personalize a aparência do ListBox
            EstilizarListBox(listBoxClientes);
        }
        private void EstilizarListBox(ListBox listBox)
        {
            listBox.BorderStyle = BorderStyle.None;
            listBox.BackColor = Color.White;
            listBox.Font = new Font("Arial", 15);
            listBox.Size = new Size(236,35);
            listBox.ForeColor = Color.Black;
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.DrawItem += ListBox_DrawItem;
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                Brush myBrush = Brushes.Black;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    myBrush = Brushes.White;
                }

                e.Graphics.DrawString(listBoxClientes.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
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
    }
}
