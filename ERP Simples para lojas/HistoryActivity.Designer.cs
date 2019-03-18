namespace ERP_Simples_para_lojas
{
    partial class HistoryActivity
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
            this.lv_extract = new System.Windows.Forms.ListView();
            this.ch_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_extract
            // 
            this.lv_extract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_produto,
            this.ch_valor,
            this.ch_cliente});
            this.lv_extract.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_extract.Location = new System.Drawing.Point(104, 66);
            this.lv_extract.Name = "lv_extract";
            this.lv_extract.Size = new System.Drawing.Size(426, 348);
            this.lv_extract.TabIndex = 0;
            this.lv_extract.UseCompatibleStateImageBehavior = false;
            this.lv_extract.View = System.Windows.Forms.View.Details;
            this.lv_extract.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ch_produto
            // 
            this.ch_produto.Text = "Produto";
            this.ch_produto.Width = 142;
            // 
            // ch_valor
            // 
            this.ch_valor.Text = "Valor";
            this.ch_valor.Width = 163;
            // 
            // ch_cliente
            // 
            this.ch_cliente.Text = "Cliente";
            this.ch_cliente.Width = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico de Vendas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(395, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HistoryActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_extract);
            this.Name = "HistoryActivity";
            this.Size = new System.Drawing.Size(709, 475);
            this.Load += new System.EventHandler(this.HistoryActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_extract;
        private System.Windows.Forms.ColumnHeader ch_produto;
        private System.Windows.Forms.ColumnHeader ch_valor;
        private System.Windows.Forms.ColumnHeader ch_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
