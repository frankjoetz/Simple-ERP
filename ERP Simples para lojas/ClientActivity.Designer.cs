namespace ERP_Simples_para_lojas
{
    partial class ClientActivity
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_clientes = new System.Windows.Forms.ListView();
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 49;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(3)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(137, 120);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 35);
            this.btnCadastrar.TabIndex = 48;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRemoverCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(192, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 172);
            this.panel1.TabIndex = 51;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(29, 85);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(237, 20);
            this.txtTelefone.TabIndex = 53;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lv_clientes);
            this.panel2.Location = new System.Drawing.Point(83, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 266);
            this.panel2.TabIndex = 52;
            // 
            // lv_clientes
            // 
            this.lv_clientes.BackColor = System.Drawing.Color.White;
            this.lv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nome,
            this.ch_telefone});
            this.lv_clientes.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_clientes.FullRowSelect = true;
            this.lv_clientes.GridLines = true;
            this.lv_clientes.Location = new System.Drawing.Point(3, 3);
            this.lv_clientes.Name = "lv_clientes";
            this.lv_clientes.Size = new System.Drawing.Size(505, 258);
            this.lv_clientes.TabIndex = 0;
            this.lv_clientes.UseCompatibleStateImageBehavior = false;
            this.lv_clientes.View = System.Windows.Forms.View.Details;
            this.lv_clientes.SelectedIndexChanged += new System.EventHandler(this.lv_clientes_SelectedIndexChanged);
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Nome";
            this.ch_nome.Width = 216;
            // 
            // ch_telefone
            // 
            this.ch_telefone.Text = "Telefone";
            this.ch_telefone.Width = 291;
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnRemoverCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverCliente.FlatAppearance.BorderSize = 0;
            this.btnRemoverCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRemoverCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCliente.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.btnRemoverCliente.Location = new System.Drawing.Point(29, 119);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(89, 36);
            this.btnRemoverCliente.TabIndex = 53;
            this.btnRemoverCliente.Text = "Apagar";
            this.btnRemoverCliente.UseVisualStyleBackColor = false;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // ClientActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientActivity";
            this.Size = new System.Drawing.Size(709, 494);
            this.Load += new System.EventHandler(this.ClientActivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_clientes;
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoverCliente;
    }
}
