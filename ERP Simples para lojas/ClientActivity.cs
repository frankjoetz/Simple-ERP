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
    public partial class ClientActivity : UserControl
    {

        DAOcommands daoSQL = new DAOcommands();
        String nomeSelecionado;
        String telefoneSelecionado;
        public ClientActivity()
        {
            InitializeComponent();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClientActivity_Load(object sender, EventArgs e)
        {
            daoSQL.exibirClientes(lv_clientes);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SellActivity sellActivity = new SellActivity();
            daoSQL.cadastrarCliente(txtNome.Text, txtTelefone.Text);
            limparTexto();
            daoSQL.exibirClientes(lv_clientes);
            lv_clientes.Items[lv_clientes.Items.Count - 1].EnsureVisible();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void limparTexto()
        {
            this.txtNome.Text = "";
            this.txtTelefone.Text = "";
        }

        //Apagar clientes da lista
        private void lv_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count == 0)
                return;

            ListViewItem item = lv_clientes.SelectedItems[0];
           nomeSelecionado = item.Text;
           telefoneSelecionado = item.SubItems[1].Text;
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count >= 1)
            {
                SellActivity sellActivity = new SellActivity();
                daoSQL.removerCliente(nomeSelecionado, telefoneSelecionado);
                daoSQL.exibirClientes(lv_clientes);
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }




        //Validações


    }
}
