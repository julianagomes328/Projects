using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    public partial class FUNCIONARIO2 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True");

        public int IdItemSelecionado { get; }

        public FUNCIONARIO2()
        {
            InitializeComponent();
        }

        public FUNCIONARIO2(int idItemSelecionado)
        {
            IdItemSelecionado = idItemSelecionado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FUNCIONARIO_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvarFuncionario();
        }


        private void bind_data()

        {

            SqlCommand cmd1 = new SqlCommand("Select * from TB_FUNCIONARIOS", cn);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd1;

            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);

            dataGridView5.DataSource = dt;

            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

            dataGridView5.DefaultCellStyle.Font = new Font("arial", 12);

        }
        private void SalvarFuncionario()
        {

            try
            {

                {

                    cn.Open();

                    var sql = "INSERT INTO TB_FUNCIONARIOS (REGISTRO_EMPREGADOR, NOME_COLABORADOR, CPF, RG, DATA_NASC, GENERO, CTPS, SERIE, PIS, CEP, ENDERECO, BAIRRO, UF, EMAIL_COLABORADOR, CEL, DATA_ADMISSAO, DATA_DEMISSAO, STATUS, CARGA_HORARIA, AREA, CARGO, DIRETOR, GESTOR_IMEDIATO, BANCO, AGENCIA, CONTA, SALARIO,  DEPENDENTES) " +
                            "VALUES  (@REGISTRO_EMPREGADOR, @NOME_COLABORADOR, @CPF, @RG, @DATA_NASC, @GENERO, @CTPS, @SERIE, @PIS, @CEP, @ENDERECO, @BAIRRO, @UF, @EMAIL_COLABORADOR, @CEL, @DATA_ADMISSAO, @DATA_DEMISSAO, @STATUS, @CARGA_HORARIA, @AREA, @CARGO, @DIRETOR, @GESTOR_IMEDIATO,@BANCO, @AGENCIA, @CONTA, @SALARIO,  @DEPENDENTES)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {


                        cmd.Parameters.AddWithValue("@REGISTRO_EMPREGADOR", textRegistroFunc.Text);
                        cmd.Parameters.AddWithValue("@NOME_COLABORADOR", textNomeFunc.Text);
                        cmd.Parameters.AddWithValue("@CPF", textCpfFunc.Text);
                        cmd.Parameters.AddWithValue("@RG", textRgFunc.Text);
                        cmd.Parameters.AddWithValue("@DATA_NASC", textDtNascFunc.Text);
                        cmd.Parameters.AddWithValue("@GENERO", comboGenFunc.Text);
                        cmd.Parameters.AddWithValue("@CTPS", textCtpsFunc.Text);
                        cmd.Parameters.AddWithValue("@SERIE", textSerieFunc.Text);
                        cmd.Parameters.AddWithValue("@PIS", textPisFunc.Text);
                        cmd.Parameters.AddWithValue("@CEP", textCepFunc.Text);
                        cmd.Parameters.AddWithValue("@ENDERECO", textEndFunc.Text);
                        cmd.Parameters.AddWithValue("@BAIRRO", textBairroFunc.Text);
                        cmd.Parameters.AddWithValue("@UF", comboUfFunc.Text);
                        cmd.Parameters.AddWithValue("@EMAIL_COLABORADOR", textEmailFunc.Text);
                        cmd.Parameters.AddWithValue("@CEL", textCelFunc.Text);
                        cmd.Parameters.AddWithValue("@DATA_ADMISSAO", textDtAdmFunc.Text);
                        cmd.Parameters.AddWithValue("@STATUS", textDtDmFunc.Text);
                        cmd.Parameters.AddWithValue("@DATA_DEMISSAO", textDtDmFunc.Text);
                        cmd.Parameters.AddWithValue("@CARGA_HORARIA", comboCargHor.Text);
                        cmd.Parameters.AddWithValue("@AREA", comboAreaFunc.Text);
                        cmd.Parameters.AddWithValue("@CARGO", comboCargoFunc.Text);
                        cmd.Parameters.AddWithValue("@DIRETOR", comboDiretorFunc.Text);
                        cmd.Parameters.AddWithValue("@GESTOR_IMEDIATO", comboGestorImed.Text);
                        cmd.Parameters.AddWithValue("@BANCO", textBancoFunc.Text);
                        cmd.Parameters.AddWithValue("@AGENCIA", textAgenciaFunc.Text);
                        cmd.Parameters.AddWithValue("@CONTA", textContaFunc.Text);
                        cmd.Parameters.AddWithValue("@SALARIO", textSalarioFunc.Text);
                        cmd.Parameters.AddWithValue("@DEPENDENTES", comboDependFunc.Text);


                        cmd.ExecuteNonQuery();
                    }
                }
                cn.Close();
                MessageBox.Show("Cadastro realizado com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não inserir os dados!\n\n" + ex.Message);
            }
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisaFunc_Click(object sender, EventArgs e)
        {

        }

        private void textRegistroFunc_Leave(object sender, EventArgs e)
        {

        }

        private void textBancoFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            DataGridViewRow selectedrow = dataGridView5.Rows[index];

            textRegistroFunc.Text = selectedrow.Cells[0].Value.ToString();
            textNomeFunc.Text = selectedrow.Cells[1].Value.ToString();
            textCpfFunc.Text = selectedrow.Cells[2].Value.ToString();
            textRgFunc.Text = selectedrow.Cells[3].Value.ToString();
            textDtNascFunc.Text = selectedrow.Cells[4].Value.ToString();
            comboGenFunc.Text = selectedrow.Cells[5].Value.ToString();
            textCtpsFunc.Text = selectedrow.Cells[6].Value.ToString();
            textSerieFunc.Text = selectedrow.Cells[7].Value.ToString();
            textPisFunc.Text = selectedrow.Cells[8].Value.ToString();
            textCepFunc.Text = selectedrow.Cells[9].Value.ToString();
            textEndFunc.Text = selectedrow.Cells[10].Value.ToString();
            textBairroFunc.Text = selectedrow.Cells[11].Value.ToString();
            comboUfFunc.Text = selectedrow.Cells[12].Value.ToString();
            textEmailFunc.Text = selectedrow.Cells[13].Value.ToString();
            textCelFunc.Text = selectedrow.Cells[14].Value.ToString();
            textDtAdmFunc.Text = selectedrow.Cells[15].Value.ToString();
            textDtDmFunc.Text = selectedrow.Cells[16].Value.ToString();
            comboStatusFunc.Text = selectedrow.Cells[17].Value.ToString();
            comboCargHor.Text = selectedrow.Cells[18].Value.ToString();
            comboAreaFunc.Text = selectedrow.Cells[19].Value.ToString();
            comboCargoFunc.Text = selectedrow.Cells[20].Value.ToString();
            comboDiretorFunc.Text = selectedrow.Cells[21].Value.ToString();
            comboGestorImed.Text = selectedrow.Cells[22].Value.ToString();
            textBancoFunc.Text = selectedrow.Cells[23].Value.ToString();
            textAgenciaFunc.Text = selectedrow.Cells[24].Value.ToString();
            textContaFunc.Text = selectedrow.Cells[25].Value.ToString();
            textSalarioFunc.Text = selectedrow.Cells[26].Value.ToString();
            comboDependFunc.Text = selectedrow.Cells[28].Value.ToString();



        }

        private void buttonEditarFunc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd3 = new SqlCommand("Update TB_FUNCIONARIOS Set NOME_COLABORADOR=@NOME_COLABORADOR,GENERO=@GENERO,CEP=@CEP,ENDERECO=@ENDERECO,BAIRRO = @BAIRRO ,UF = @UF,EMAIL_COLABORADOR = @EMAIL_COLABORADOR  ,CEL = @CEL,STATUS = @STATUS ,CARGA_HORARIA = @CARGA_HORARIA  ,AREA = @AREA  ,CARGO = @CARGO  ,DIRETOR = @DIRETOR  ,GESTOR_IMEDIATO = @GESTOR_IMEDIATO ,SALARIO = @SALARIO  ,DEPENDENTES = @DEPENDENTES  where REGISTRO_EMPREGADOR=@REGISTRO_EMPREGADOR", cn);




            cmd3.Parameters.AddWithValue("@REGISTRO_EMPREGADOR", textRegistroFunc.Text);
            cmd3.Parameters.AddWithValue("@NOME_COLABORADOR", textNomeFunc.Text);

            cmd3.Parameters.AddWithValue("@GENERO", comboGenFunc.Text);
            cmd3.Parameters.AddWithValue("@CEP", textCepFunc.Text);
            cmd3.Parameters.AddWithValue("@ENDERECO", textEndFunc.Text);
            cmd3.Parameters.AddWithValue("@BAIRRO", textBairroFunc.Text);
            cmd3.Parameters.AddWithValue("@UF", comboUfFunc.Text);
            cmd3.Parameters.AddWithValue("@EMAIL_COLABORADOR", textEmailFunc.Text);
            cmd3.Parameters.AddWithValue("@CEL", textCelFunc.Text);
            cmd3.Parameters.AddWithValue("@STATUS", textDtDmFunc.Text);
            cmd3.Parameters.AddWithValue("@CARGA_HORARIA", comboCargHor.Text);
            cmd3.Parameters.AddWithValue("@AREA", comboAreaFunc.Text);
            cmd3.Parameters.AddWithValue("@CARGO", comboCargoFunc.Text);
            cmd3.Parameters.AddWithValue("@DIRETOR", comboDiretorFunc.Text);
            cmd3.Parameters.AddWithValue("@GESTOR_IMEDIATO", comboGestorImed.Text);
            cmd3.Parameters.AddWithValue("@SALARIO", textSalarioFunc.Text);
            cmd3.Parameters.AddWithValue("@DEPENDENTES", comboDependFunc.Text);

            cn.Open();


            cmd3.ExecuteNonQuery();

            cn.Close();

            bind_data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select * from TB_FUNCIONARIOS where NOME_COLABORADOR Like @NOME_COLABORADOR+'%' OR REGISTRO_EMPREGADOR LIKE @REGISTRO_EMPREGADOR+'%' ", cn);

            cmd1.Parameters.AddWithValue("NOME_COLABORADOR", textPesquisaNome.Text);
            cmd1.Parameters.AddWithValue("REGISTRO_EMPREGADOR", textPesquisaNome.Text);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd1;

            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);

            dataGridView5.DataSource = dt;

            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);

            dataGridView5.DefaultCellStyle.Font = new Font("arial", 9);


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
