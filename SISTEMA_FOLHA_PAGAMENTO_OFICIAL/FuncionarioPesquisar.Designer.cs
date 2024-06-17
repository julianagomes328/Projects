namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class FormPesquisaFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textPesquisaRe = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textPesquisaCpf = new TextBox();
            buttonPesquisarN = new Button();
            buttonNovoCad = new Button();
            dataGridPesquisa = new DataGridView();
            butnPesquisarFuncEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisa).BeginInit();
            SuspendLayout();
            // 
            // textPesquisaRe
            // 
            textPesquisaRe.Location = new Point(88, 19);
            textPesquisaRe.Name = "textPesquisaRe";
            textPesquisaRe.Size = new Size(98, 23);
            textPesquisaRe.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Resgistro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 22);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF:";
            // 
            // textPesquisaCpf
            // 
            textPesquisaCpf.Location = new Point(235, 19);
            textPesquisaCpf.Name = "textPesquisaCpf";
            textPesquisaCpf.Size = new Size(183, 23);
            textPesquisaCpf.TabIndex = 3;
            // 
            // buttonPesquisarN
            // 
            buttonPesquisarN.Location = new Point(682, 48);
            buttonPesquisarN.Name = "buttonPesquisarN";
            buttonPesquisarN.Size = new Size(110, 30);
            buttonPesquisarN.TabIndex = 5;
            buttonPesquisarN.Text = "Pesquisar";
            buttonPesquisarN.UseVisualStyleBackColor = true;
            buttonPesquisarN.Click += buttonPesquisarN_Click;
            // 
            // buttonNovoCad
            // 
            buttonNovoCad.Location = new Point(682, 84);
            buttonNovoCad.Name = "buttonNovoCad";
            buttonNovoCad.Size = new Size(110, 30);
            buttonNovoCad.TabIndex = 7;
            buttonNovoCad.Text = "Novo Cadastro";
            buttonNovoCad.UseVisualStyleBackColor = true;
            buttonNovoCad.Click += buttonNovoCad_Click;
            // 
            // dataGridPesquisa
            // 
            dataGridPesquisa.AllowUserToOrderColumns = true;
            dataGridPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisa.Location = new Point(12, 57);
            dataGridPesquisa.Name = "dataGridPesquisa";
            dataGridPesquisa.RowTemplate.Height = 25;
            dataGridPesquisa.Size = new Size(406, 78);
            dataGridPesquisa.TabIndex = 8;
            dataGridPesquisa.CellContentClick += dataGridPesquisa_CellContentClick;
            // 
            // butnPesquisarFuncEdit
            // 
            butnPesquisarFuncEdit.Location = new Point(682, 12);
            butnPesquisarFuncEdit.Name = "butnPesquisarFuncEdit";
            butnPesquisarFuncEdit.Size = new Size(110, 30);
            butnPesquisarFuncEdit.TabIndex = 9;
            butnPesquisarFuncEdit.Text = "Editar ";
            butnPesquisarFuncEdit.UseVisualStyleBackColor = true;
            butnPesquisarFuncEdit.Click += butnPesquisarFuncEdit_Click;
            // 
            // FormPesquisaFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 487);
            Controls.Add(butnPesquisarFuncEdit);
            Controls.Add(dataGridPesquisa);
            Controls.Add(buttonNovoCad);
            Controls.Add(buttonPesquisarN);
            Controls.Add(label2);
            Controls.Add(textPesquisaCpf);
            Controls.Add(label1);
            Controls.Add(textPesquisaRe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisaFunc";
            Text = "FuncionarioPesquisar";
            Load += FuncionarioPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPesquisaRe;
        private Label label1;
        private Label label2;
        private TextBox textPesquisaCpf;
        private Button buttonPesquisarN;
        private Button buttonNovoCad;
        private DataGridView dataGridPesquisa;
        private Button butnPesquisarFuncEdit;
    }
}