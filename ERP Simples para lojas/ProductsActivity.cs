using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_Simples_para_lojas.Database_files.DAL;

namespace ERP_Simples_para_lojas
{
    public partial class ProductsActivity : UserControl
    {
        DAOcommands daoSQL= new DAOcommands();
        String produtoSelecionado, valorSelecionado, quantidadeSelecionado;


        public ProductsActivity()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedItems.Count == 0)
                return;

            ListViewItem item = lv_produtos.SelectedItems[0];
            produtoSelecionado = item.Text;
            valorSelecionado = item.SubItems[1].Text;
            quantidadeSelecionado = item.SubItems[2].Text;

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int intQuantidade = int.Parse(txtQuantidade.Text);
            daoSQL.cadastrarProduto(txtProduto.Text, txtValor.Text, intQuantidade);
            limparTexto();
            daoSQL.exibirProdutos(lv_produtos);
            lv_produtos.Items[lv_produtos.Items.Count - 1].EnsureVisible();
        }




        private void limparTexto()
        {
            this.txtProduto.Text = "";
            this.txtValor.Text = "20";
            this.txtQuantidade.Text = "1";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

        public void listView_Load(object sender, EventArgs e)
        {
            daoSQL.exibirProdutos(lv_produtos);
        }

        private void removerProduto()
        {
            if (lv_produtos.SelectedItems.Count >= 1)
            {
                SellActivity sellActivity = new SellActivity();
                daoSQL.removerProduto(produtoSelecionado, valorSelecionado, int.Parse(quantidadeSelecionado));
                daoSQL.exibirProdutos(lv_produtos);
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
    }
}
