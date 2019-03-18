using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Simples_para_lojas
{
    public partial class HistoryActivity : UserControl
    {
        public HistoryActivity()
        {
            InitializeComponent();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryActivity_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
              
                ListViewItem listView = new ListViewItem("Topolino");
                listView.SubItems.Add("R$: " + "35,00");
                listView.SubItems.Add("Kevin Soares");
                lv_extract.Items.Add(listView);

            }

        }
    }
}
