using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Simples_para_lojas
{
    public partial class MainActivity : Form
    {
        public MainActivity()
        {
            InitializeComponent();
        }

        private void MainActivity_Load(object sender, EventArgs e)
        {
            timer1.Start();
            data.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
            btnSVender_Click(sender, e);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void btnProdutos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProdutos.Height;
            SidePanel.Top = btnProdutos.Top;
            productsActivity3.BringToFront();
            historyActivity1.Hide();
            clientActivity1.Hide();
        }

        private void btnSVender_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSVender.Height;
            SidePanel.Top = btnSVender.Top;
            sellActivity3.BringToFront();
            historyActivity1.Hide();
            clientActivity1.Hide();
        }

        private void btnHistorico_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnHistorico.Height;
            SidePanel.Top = btnHistorico.Top;
            historyActivity1.BringToFront();
            historyActivity1.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnClientes.Height;
            SidePanel.Top = btnClientes.Top;
            clientActivity1.BringToFront();
            clientActivity1.Show();
        }
    }
}
