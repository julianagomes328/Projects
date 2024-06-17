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
    public partial class Cofiguracoes : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True");
        public Cofiguracoes()
        {
            InitializeComponent();
        }

        private void Cofiguracoes_Load(object sender, EventArgs e)
        {

        }
        private void SalvarFuncionario()
        {

            try
            {

                {

                    cn.Open();

                    var sql = "INSERT INTO TB_USERS_FUNC (REGISTRO, USUARIO, SENHA) VALUES  (@REGISTRO, @USUARIO, @SENHA)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {


                        cmd.Parameters.AddWithValue("@REGISTRO", textReConfig.Text);
                        cmd.Parameters.AddWithValue("@USUARIO", textUserConfig.Text);
                        cmd.Parameters.AddWithValue("@SENHA", textSenhaConfig.Text);



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
    }


}
