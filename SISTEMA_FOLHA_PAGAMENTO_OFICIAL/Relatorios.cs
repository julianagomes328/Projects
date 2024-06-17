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
    public partial class Relatoriosgeral : Form
    {
        string Connection = @"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True";
        public Relatoriosgeral()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Relatoriosgeral_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker2.Enabled = true;

        }

        private void CarregarDadosNoDataGridView3(string text)
        {
            // Conectar ao banco de dados
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();

                // Substitua esta consulta pelo seu próprio SQL
                string query = "SELECT *  FROM FOLHA_FUNCIONARIO WHERE DATA_FOLHA = '" + dateTimePicker2.Text + "' AND REGISTRO = '" + textPesquisaReFolha.Text + "'  ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Preencher DataGridView com os resultados da consulta
                    dataGridView3.DataSource = dataTable;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView3(dateTimePicker2.Text);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarGridParaCSV();
        }
        private void ExportarGridParaCSV()
        {
            // Verificar se há dados para exportar
            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configurar o diálogo de salvar arquivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "DadosExportados";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Criar o arquivo CSV e gravar os dados
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    // Gravar cabeçalhos das colunas
                    for (int i = 0; i < dataGridView3.Columns.Count; i++)
                    {
                        streamWriter.Write(dataGridView3.Columns[i].HeaderText);
                        if (i < dataGridView3.Columns.Count - 1)
                            streamWriter.Write(",");
                    }
                    streamWriter.WriteLine();

                    // Gravar dados das linhas
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        for (int i = 0; i < dataGridView3.Columns.Count; i++)
                        {
                            streamWriter.Write(row.Cells[i].Value);
                            if (i < dataGridView3.Columns.Count - 1)
                                streamWriter.Write(",");
                        }
                        streamWriter.WriteLine();
                    }
                }

                MessageBox.Show("Dados exportados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisarReFolha_Click(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView3(textPesquisaReFolha.Text);
        }
    }
}
