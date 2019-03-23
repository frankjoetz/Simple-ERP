namespace ERP_Simples_para_lojas
{
    partial class MainActivity
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSVender = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sellActivity3 = new ERP_Simples_para_lojas.SellActivity();
            this.productsActivity3 = new ERP_Simples_para_lojas.ProductsActivity();
            this.historyActivity1 = new ERP_Simples_para_lojas.HistoryActivity();
            this.clientActivity1 = new ERP_Simples_para_lojas.ClientActivity();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.hora);
            this.panel2.Controls.Add(this.data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 34);
            this.panel2.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.hora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora.Location = new System.Drawing.Point(500, 9);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(36, 14);
            this.hora.TabIndex = 8;
            this.hora.Text = "Hora";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.data.Location = new System.Drawing.Point(189, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(36, 14);
            this.data.TabIndex = 7;
            this.data.Text = "Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.Controls.Add(this.SidePanel);
            this.panel3.Controls.Add(this.btnSVender);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.btnClientes);
            this.panel3.Controls.Add(this.btnHistorico);
            this.panel3.Controls.Add(this.btnProdutos);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 538);
            this.panel3.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.SidePanel.Location = new System.Drawing.Point(163, 94);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 59);
            this.SidePanel.TabIndex = 5;
            // 
            // btnSVender
            // 
            this.btnSVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSVender.FlatAppearance.BorderSize = 0;
            this.btnSVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVender.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSVender.Image = global::ERP_Simples_para_lojas.Properties.Resources.sell;
            this.btnSVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSVender.Location = new System.Drawing.Point(0, 94);
            this.btnSVender.Name = "btnSVender";
            this.btnSVender.Size = new System.Drawing.Size(173, 59);
            this.btnSVender.TabIndex = 7;
            this.btnSVender.Text = "Vender";
            this.btnSVender.UseVisualStyleBackColor = true;
            this.btnSVender.Click += new System.EventHandler(this.btnSVender_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ERP_Simples_para_lojas.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::ERP_Simples_para_lojas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 76);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Image = global::ERP_Simples_para_lojas.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(173, 59);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Image = global::ERP_Simples_para_lojas.Properties.Resources.client;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 309);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(173, 59);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistorico.Image = global::ERP_Simples_para_lojas.Properties.Resources.sales;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 234);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(173, 59);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click_1);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdutos.Image = global::ERP_Simples_para_lojas.Properties.Resources.products2;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 159);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(173, 59);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sellActivity3
            // 
            this.sellActivity3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sellActivity3.Location = new System.Drawing.Point(192, 40);
            this.sellActivity3.Name = "sellActivity3";
            this.sellActivity3.Size = new System.Drawing.Size(609, 437);
            this.sellActivity3.TabIndex = 3;
            // 
            // productsActivity3
            // 
            this.productsActivity3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productsActivity3.Location = new System.Drawing.Point(179, 40);
            this.productsActivity3.Name = "productsActivity3";
            this.productsActivity3.Size = new System.Drawing.Size(604, 475);
            this.productsActivity3.TabIndex = 4;
            // 
            // historyActivity1
            // 
            this.historyActivity1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyActivity1.Location = new System.Drawing.Point(179, 40);
            this.historyActivity1.Name = "historyActivity1";
            this.historyActivity1.Size = new System.Drawing.Size(675, 486);
            this.historyActivity1.TabIndex = 5;
            // 
            // clientActivity1
            // 
            this.clientActivity1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientActivity1.Location = new System.Drawing.Point(179, 40);
            this.clientActivity1.Name = "clientActivity1";
            this.clientActivity1.Size = new System.Drawing.Size(687, 498);
            this.clientActivity1.TabIndex = 6;
            this.clientActivity1.Load += new System.EventHandler(this.clientActivity1_Load);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(866, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productsActivity3);
            this.Controls.Add(this.clientActivity1);
            this.Controls.Add(this.sellActivity3);
            this.Controls.Add(this.historyActivity1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerencial - Tela Inícial";
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSVender;
        private ProductsActivity productsActivity3;
        private System.Windows.Forms.Panel SidePanel;
        private HistoryActivity historyActivity1;
        private ClientActivity clientActivity1;
        private SellActivity sellActivity3;
    }
}

