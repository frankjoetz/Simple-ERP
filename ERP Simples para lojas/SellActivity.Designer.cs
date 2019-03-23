namespace ERP_Simples_para_lojas
{
    partial class SellActivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dropProdutos = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelValorProduto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dropClientes = new System.Windows.Forms.ComboBox();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Produto";
            // 
            // dropProdutos
            // 
            this.dropProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropProdutos.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropProdutos.FormattingEnabled = true;
            this.dropProdutos.Location = new System.Drawing.Point(201, 57);
            this.dropProdutos.Name = "dropProdutos";
            this.dropProdutos.Size = new System.Drawing.Size(244, 24);
            this.dropProdutos.TabIndex = 33;
            this.dropProdutos.DropDown += new System.EventHandler(this.dropDownProdutos_Load);
            this.dropProdutos.SelectedIndexChanged += new System.EventHandler(this.dropProdutos_SelectedIndexChanged);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(3)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.btnVender.ForeColor = System.Drawing.Color.Black;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(92, 343);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(121, 35);
            this.btnVender.TabIndex = 31;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDesconto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelValorProduto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelValorFinal);
            this.panel1.Location = new System.Drawing.Point(201, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 178);
            this.panel1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(52, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(89, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "10.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Valor Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(50, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "R$";
            // 
            // labelValorProduto
            // 
            this.labelValorProduto.AutoSize = true;
            this.labelValorProduto.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorProduto.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelValorProduto.Location = new System.Drawing.Point(89, 32);
            this.labelValorProduto.Name = "labelValorProduto";
            this.labelValorProduto.Size = new System.Drawing.Size(23, 23);
            this.labelValorProduto.TabIndex = 16;
            this.labelValorProduto.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor Produto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(48, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 33);
            this.label13.TabIndex = 13;
            this.label13.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor Final";
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorFinal.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelValorFinal.Location = new System.Drawing.Point(98, 130);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(33, 37);
            this.labelValorFinal.TabIndex = 12;
            this.labelValorFinal.Text = "0";
            this.labelValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dropClientes);
            this.panel2.Controls.Add(this.btnVender);
            this.panel2.Location = new System.Drawing.Point(163, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 407);
            this.panel2.TabIndex = 38;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // dropClientes
            // 
            this.dropClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropClientes.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.dropClientes.FormattingEnabled = true;
            this.dropClientes.Location = new System.Drawing.Point(38, 112);
            this.dropClientes.Name = "dropClientes";
            this.dropClientes.Size = new System.Drawing.Size(244, 24);
            this.dropClientes.TabIndex = 39;
            this.dropClientes.DropDown += new System.EventHandler(this.dropDown_Load);
            this.dropClientes.SelectedIndexChanged += new System.EventHandler(this.dropClientes_SelectedIndexChanged);
            this.dropClientes.MouseEnter += new System.EventHandler(this.dropClientes_MouseEnter);
            // 
            // txtDesconto
            // 
            this.txtDesconto.DecimalPlaces = 2;
            this.txtDesconto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Firebrick;
            this.txtDesconto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDesconto.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDesconto.InterceptArrowKeys = false;
            this.txtDesconto.Location = new System.Drawing.Point(93, 84);
            this.txtDesconto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 27);
            this.txtDesconto.TabIndex = 22;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.txtDesconto_ValueChanged);
            // 
            // SellActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SellActivity";
            this.Size = new System.Drawing.Size(709, 475);
            this.Load += new System.EventHandler(this.SellActivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropProdutos;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelValorProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox dropClientes;
        private System.Windows.Forms.NumericUpDown txtDesconto;
    }
}
