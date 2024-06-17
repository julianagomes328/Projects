using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    public partial class PROCESSAMENTO : Form
    {
        string Connection = @"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True";
        public PROCESSAMENTO()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }


        private void CarregarDadosNoDataGridView2(string text)
        {
            // Conectar ao banco de dados
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();

                // Substitua esta consulta pelo seu próprio SQL
                string query = "SELECT *  FROM AGROUP_PROCESSAMENTOS WHERE DATA_FOLHA = '" + dateTimePicker1.Text + "'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Preencher DataGridView com os resultados da consulta
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView2(dateTimePicker1.Text);
        }
    }
}
