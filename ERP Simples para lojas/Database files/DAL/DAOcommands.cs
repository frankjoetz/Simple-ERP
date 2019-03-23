using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Simples_para_lojas.Database_files.DAL
{
    class DAOcommands
    {
        String mensagem = "";
        SqlCommand cmdSql = new SqlCommand();
        Connection connectionSql = new Connection();

        //==============================| CLIENTES |==========================================//
        public void cadastrarCliente(String nome, String telefone)
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "INSERT INTO tb_clientes (cl_nome, cl_telefone) VALUES (@nome, @telefone) ";
            cmdSql.Parameters.AddWithValue("@nome", nome);
            cmdSql.Parameters.AddWithValue("@telefone", telefone);
            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Cliente cadastrado");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        public void exibirClientes(ListView lv_clientes)
        {
            lv_clientes.Items.Clear();
            String sqlSelect = "SELECT cl_nome, cl_telefone FROM tb_clientes";
            DataSet ds = new DataSet();
            SqlConnection con = connectionSql.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, con);
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem listView = new ListViewItem(row["cl_nome"].ToString());
                listView.SubItems.Add(row["cl_telefone"].ToString());
                lv_clientes.Items.Add(listView);
            }
            connectionSql.Disconnect();
        }


        //==============================| PRODUTOS |==========================================//
        public void cadastrarProduto(String produto, String valor, int quantidade)
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "INSERT INTO tb_produtos (cl_produto, cl_valor, cl_quantidade) VALUES (@produto, @valor, @quantidade) ";
            cmdSql.Parameters.AddWithValue("@produto", produto);
            cmdSql.Parameters.AddWithValue("@valor", valor);
            cmdSql.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Produto cadastrado");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }

        public void exibirProdutos(ListView lv_produtos)
        {
            lv_produtos.Items.Clear();
            String sqlSelect = "SELECT * FROM tb_produtos";
            DataSet ds = new DataSet();
            SqlConnection con = connectionSql.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, con);
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem listView = new ListViewItem(row["cl_produto"].ToString());
                listView.SubItems.Add(row["cl_valor"].ToString());
                listView.SubItems.Add(row["cl_quantidade"].ToString());
                lv_produtos.Items.Add(listView);
            }
            connectionSql.Disconnect();
        }
        //========================================================================//


        //=============================| REMOVER CLIENTES |===========================================//

        //Metódos de remoção SQL da tela clientes.
        public void removerCliente(String nome, String telefone)
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "DELETE FROM tb_clientes WHERE cl_nome = @nome and cl_telefone = @telefone";
            cmdSql.Parameters.AddWithValue("@nome", nome);
            cmdSql.Parameters.AddWithValue("@telefone", telefone);
            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Cliente Deletado");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        //===========================| REMOVER PRODUTOS ================================================//
        public void removerProduto(String produto, String valor, int quantidade)
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "DELETE FROM tb_produtos WHERE cl_produto = @produto and cl_valor = @valor and cl_quantidade = @quantidade";
            cmdSql.Parameters.AddWithValue("@produto", produto);
            cmdSql.Parameters.AddWithValue("@valor", valor);
            cmdSql.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Produto Deletado");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        //================================| ATUALIZADOR COMBOBOX |========================================//

        //Enviar os dados do banco de dados para os ComboBox Clientes e Produtos
        public void dropDownClientes(ComboBox comboBoxClientes)
            {
            String sqlSelect = "SELECT cl_nome FROM tb_clientes";
            SqlConnection con = connectionSql.Connect();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            comboBoxClientes.DataSource = null;
            da.Fill(dtResultado);
            comboBoxClientes.DisplayMember = "cl_nome";
            comboBoxClientes.DataSource = dtResultado;
            comboBoxClientes.Refresh();
        }

        public void dropDownProdutos(ComboBox comboBoxClientes)
        {
            String sqlSelect = "SELECT cl_produto FROM tb_produtos";
            SqlConnection con = connectionSql.Connect();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            comboBoxClientes.DataSource = null;
            da.Fill(dtResultado);
            comboBoxClientes.DisplayMember = "cl_produto";
            comboBoxClientes.DataSource = dtResultado;
            comboBoxClientes.Refresh();
        }
        //==============================| CADASTRAR VENDA |===============================//
        public void cadastrarVenda(String produto, Double valor, String cliente)
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "INSERT INTO tb_vendas (cl_hproduto, cl_hvalor, cl_hcliente) VALUES (@produto, @valor, @cliente) ";
            cmdSql.Parameters.AddWithValue("@produto", produto);
            cmdSql.Parameters.AddWithValue("@valor", valor);
            cmdSql.Parameters.AddWithValue("@cliente", cliente);

            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Venda cadastrada");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        public void removerVendas()
        {
            cmdSql.Parameters.Clear();
            cmdSql.CommandText = "DELETE FROM tb_vendas";

            try
            {
                cmdSql.Connection = connectionSql.Connect();
                cmdSql.ExecuteNonQuery();
                connectionSql.Disconnect();
                Console.WriteLine("Vendas deletadas");
                MessageBox.Show("Vendas deletadas com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }


        public void exibirVendas(ListView lv_vendas)
        {
            lv_vendas.Items.Clear();
            String sqlSelect = "SELECT * FROM tb_vendas";
            DataSet ds = new DataSet();
            SqlConnection con = connectionSql.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, con);
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem listView = new ListViewItem(row["cl_hproduto"].ToString());
                listView.SubItems.Add(row["cl_hvalor"].ToString());
                listView.SubItems.Add(row["cl_hcliente"].ToString());
                lv_vendas.Items.Add(listView);
            }
            connectionSql.Disconnect();
        }


        public String getValorProduto(string produto)
        {
            SqlConnection con = connectionSql.Connect();
            String valorProduto = "0";
            string oString = "Select * from tb_produtos where cl_produto = @produto";
                SqlCommand oCmd = new SqlCommand(oString, con);
                oCmd.Parameters.AddWithValue("@produto", produto);
               connectionSql.Connect();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        valorProduto = oReader["cl_valor"].ToString();
                    }

                connectionSql.Disconnect();
            }
            return valorProduto;
        }


        //===============================================================================//



    }

}

