using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    public partial class FormLogin : Form
    {

        // CONEXAO BD//
        SqlConnection Conexao = new SqlConnection(@"Data Source=LAPTOP-I8AEDR8B\SQLEXPRESS;Initial Catalog=DB_FOLHA_PAGAMENTOS;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
            textUsuario.Select();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            //VALIDA LOGIN EXISTENTE//

            string query = "SELECT * FROM USUARIO WHERE USERNAME = '" + textUsuario.Text + "' AND PASSWORD = '" + textPassword.Text + "' AND TIPO_ACESSO='ADMINISTRADOR'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)

            {
                FormPrincipal principal = new FormPrincipal();
                this.Hide();
                principal.Show();


            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";//LIMPA TEXTBOXS
                textUsuario.Text = "";//LIMPA TEXTBOXS
            }


        }
    }
}