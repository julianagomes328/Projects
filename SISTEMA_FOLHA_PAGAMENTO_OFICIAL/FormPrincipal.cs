using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    public partial class FormPrincipal : Form
    {

        private Form FrmAtivo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            FrmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {

            if (FrmAtivo != null)
                FrmAtivo.Close();

        }

        private void ActiveButton(Button FrmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls) ;
                
        }


        private void pictureBox1_Click(object sender, EventArgs e)

        {


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(buttonProcessadorMenu);
            FormShow(new Cofiguracoes());

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenuFunc_Click(object sender, EventArgs e)
        {
            ActiveButton(buttonProcessadorMenu);
            FormShow(new FUNCIONARIO2());
        }

        private void buttonProcessadorMenu_Click(object sender, EventArgs e)
        {
            ActiveButton(buttonProcessadorMenu);
            FormShow(new PROCESSAMENTO());

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(buttonProcessadorMenu);
            FormShow(new Relatoriosgeral());
        }
    }
}
