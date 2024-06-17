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
    public partial class FormPesquisaFunc : Form
    {

        private Form FrmAtivo1;
        string Connection =
            @"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True";

        public FormPesquisaFunc()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FuncionarioPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisarN_Click(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView(textPesquisaRe.Text);
        }

        private void CarregarDadosNoDataGridView(string text)
        {
            // Conectar ao banco de dados
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();

                // Substitua esta consulta pelo seu próprio SQL
                string query = "SELECT REGISTRO_EMPREGADOR AS REGISTRO, NOME_COLABORADOR AS NOME, CPF FROM TB_FUNCIONARIOS WHERE CPF LIKE '%" + textPesquisaCpf.Text + "%' OR REGISTRO_EMPREGADOR LIKE '%" + textPesquisaRe.Text + "%'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Preencher DataGridView com os resultados da consulta
                    dataGridPesquisa.DataSource = dataTable;
                }
            }
        }



        private void dataGridPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNovoCad_Click(object sender, EventArgs e)
        {


        }

        private void butnPesquisarFuncEdit_Click(object sender, EventArgs e)
        {


        }



        
    

    private void AbrirFormularioEdicao(int id)
        {
            // Instanciar o FormularioEdicao com o ID do item selecionado
            FormShow(new FUNCIONARIO2());
            // Atualizar o DataGridView após as edições serem concluídas
            CarregarDadosNoDataGridView(textPesquisaCpf.Text);
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            FrmAtivo1 = frm;
            frm.TopLevel = false;

            frm.BringToFront();
            frm.Show();
        }
        private void ActiveFormClose()
        {

            if (FrmAtivo1
                != null)
                FrmAtivo1
                    .Close();

        }
    }
}



