namespace ERP_Simples_para_lojas
{
    partial class ProductsActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.nome_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd_estoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome do Produto";
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
            this.btnCadastrar.Location = new System.Drawing.Point(144, 126);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 35);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(27, 31);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(237, 20);
            this.txtProduto.TabIndex = 39;
            this.txtProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Valor em R$";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(27, 84);
            this.txtValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(98, 26);
            this.txtValor.TabIndex = 47;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(188, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 176);
            this.panel1.TabIndex = 48;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightGray;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(27, 126);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(98, 35);
            this.btnApagar.TabIndex = 50;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(167, 84);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(97, 26);
            this.txtQuantidade.TabIndex = 49;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Quantidade";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lv_produtos);
            this.panel2.Location = new System.Drawing.Point(117, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 267);
            this.panel2.TabIndex = 49;
            // 
            // lv_produtos
            // 
            this.lv_produtos.BackColor = System.Drawing.Color.White;
            this.lv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome_produto,
            this.valor_produto,
            this.qtd_estoque});
            this.lv_produtos.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.GridLines = true;
            this.lv_produtos.Location = new System.Drawing.Point(3, -1);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(422, 263);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // nome_produto
            // 
            this.nome_produto.Text = "Produto";
            this.nome_produto.Width = 210;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.DisplayIndex = 2;
            this.qtd_estoque.Text = "Quantidade";
            this.qtd_estoque.Width = 128;
            // 
            // valor_produto
            // 
            this.valor_produto.DisplayIndex = 1;
            this.valor_produto.Text = "Preço";
            this.valor_produto.Width = 99;
            // 
            // ProductsActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsActivity";
            this.Size = new System.Drawing.Size(709, 496);
            this.Load += new System.EventHandler(this.listView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader nome_produto;
        private System.Windows.Forms.ColumnHeader qtd_estoque;
        private System.Windows.Forms.ColumnHeader valor_produto;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApagar;
    }
}
