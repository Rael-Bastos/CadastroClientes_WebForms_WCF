namespace CadastroClientes.Web
{
    partial class CadastroClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputRg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDtExpedicao = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputCpf
            // 
            this.inputCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCpf.Location = new System.Drawing.Point(64, 111);
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.Size = new System.Drawing.Size(174, 35);
            this.inputCpf.TabIndex = 0;
            this.inputCpf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.MaximumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputNome
            // 
            this.inputNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Location = new System.Drawing.Point(244, 111);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(804, 35);
            this.inputNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "RG";
            // 
            // inputRg
            // 
            this.inputRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRg.Location = new System.Drawing.Point(64, 211);
            this.inputRg.Name = "inputRg";
            this.inputRg.Size = new System.Drawing.Size(245, 35);
            this.inputRg.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Expedição";
            // 
            // inputDtExpedicao
            // 
            this.inputDtExpedicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDtExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDtExpedicao.Location = new System.Drawing.Point(315, 211);
            this.inputDtExpedicao.Name = "inputDtExpedicao";
            this.inputDtExpedicao.Size = new System.Drawing.Size(179, 35);
            this.inputDtExpedicao.TabIndex = 7;
            this.inputDtExpedicao.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // listBoxClientes
            // 
            //this.listBoxClientes.ItemHeight = 20;
            this.listBoxClientes.Location = new System.Drawing.Point(509, 211);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(227, 44);
            this.listBoxClientes.TabIndex = 10;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Órgão Expedição";
            // 
            // CadastroClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2116, 955);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDtExpedicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputRg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputCpf);
            this.Name = "CadastroClienteForm";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputDtExpedicao;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label label6;
    }
}