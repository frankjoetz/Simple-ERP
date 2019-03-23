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
    public partial class HistoryActivity : UserControl
    {
        DAOcommands daoSQL = new DAOcommands();
        public HistoryActivity()
        {
            InitializeComponent();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryActivity_Load(object sender, EventArgs e)
        {
            daoSQL.exibirVendas(lv_vendas);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            daoSQL.removerVendas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            daoSQL.exibirVendas(lv_vendas);
        }
    }
}
