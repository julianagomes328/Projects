namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class Relatoriosgeral
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
            dataGridView3 = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            textPesquisaReFolha = new TextBox();
            btnPesquisarReFolha = new Button();
            btnExportar = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(25, 102);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(761, 322);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textPesquisaReFolha);
            panel1.Controls.Add(btnPesquisarReFolha);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dataGridView3);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 444);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 53);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 8;
            label2.Text = "Registro Funcionário:";
            // 
            // textPesquisaReFolha
            // 
            textPesquisaReFolha.Location = new Point(386, 51);
            textPesquisaReFolha.Name = "textPesquisaReFolha";
            textPesquisaReFolha.Size = new Size(123, 23);
            textPesquisaReFolha.TabIndex = 7;
            // 
            // btnPesquisarReFolha
            // 
            btnPesquisarReFolha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarReFolha.ForeColor = Color.DimGray;
            btnPesquisarReFolha.Location = new Point(515, 48);
            btnPesquisarReFolha.Name = "btnPesquisarReFolha";
            btnPesquisarReFolha.Size = new Size(88, 27);
            btnPesquisarReFolha.TabIndex = 6;
            btnPesquisarReFolha.Text = "Pesquisar";
            btnPesquisarReFolha.UseVisualStyleBackColor = true;
            btnPesquisarReFolha.Click += btnPesquisarReFolha_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.DimGray;
            btnExportar.Location = new Point(621, 9);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(154, 27);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar Relatório";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 3;
            label1.Text = "Competência:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(117, 51);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(113, 23);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Relatoriosgeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Relatoriosgeral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorios";
            Load += Relatoriosgeral_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView3;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button btnExportar;
        private Label label2;
        private TextBox textPesquisaReFolha;
        private Button btnPesquisarReFolha;
    }
}