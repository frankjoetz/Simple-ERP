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
    public partial class SellActivity : UserControl
    {
        DAOcommands daoSQL = new DAOcommands();
        private String produto, cliente;
        private double desconto, valor, valorfinal;

        public SellActivity()
        {
            InitializeComponent();
        }

        private void dropClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SellActivity_Load(object sender, EventArgs e)
        {
            daoSQL.dropDownClientes(dropClientes);
            daoSQL.dropDownProdutos(dropProdutos);
            produto = dropProdutos.Text;
            desconto = double.Parse(txtDesconto.Text);
            valor = double.Parse(daoSQL.getValorProduto(produto));
            calcularDesconto();

        }

        public void dropDown_Load(object sender, EventArgs e)
        {
            daoSQL.dropDownClientes(dropClientes);
        }

        public void dropDownProdutos_Load(object sender, EventArgs e)
        {
            daoSQL.dropDownProdutos(dropProdutos);
        }

        private void dropClientes_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
        }



        private void btnVender_Click(object sender, EventArgs e)
        {
            produto = dropProdutos.Text;
            desconto = double.Parse(txtDesconto.Text);
            valor = double.Parse(daoSQL.getValorProduto(produto));
            cliente = dropClientes.Text;
            calcularDesconto();
            daoSQL.cadastrarVenda(produto, valorfinal, cliente);
        }

        private void calcularDesconto()
        {
            if(double.Parse(txtDesconto.Text) > 0)
            {
                double calculoFinal = valor - desconto;
                setValorFinal(calculoFinal);
            }
            else
            {
                setValorFinal(valor);
            }
        }

        private void dropProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto = dropProdutos.Text;
            desconto = double.Parse(txtDesconto.Text);
            valor = double.Parse(daoSQL.getValorProduto(produto));
            calcularDesconto();
            labelValorProduto.Text = (""+valor);
            labelValorFinal.Text = (""+valorfinal);
        }

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            produto = dropProdutos.Text;
            desconto = double.Parse(txtDesconto.Text);
            valor = double.Parse(daoSQL.getValorProduto(produto));
            calcularDesconto();
            labelValorFinal.Text = (""+valorfinal);
        }

        public void setProduto(String produto)
        {
            this.produto = produto;
        }

        public void setDesconto(double desconto)
        {
            this.desconto = desconto;
        }

        public void setValorFinal(double valorfinal)
        {
            this.valorfinal = valorfinal;
        }



    }
}
