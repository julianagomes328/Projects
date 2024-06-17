namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class PROCESSAMENTO
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
            dataGridView2 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label30 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(26, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(716, 372);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(639, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.MenuHighlight;
            label30.Location = new Point(26, 25);
            label30.Name = "label30";
            label30.Size = new Size(445, 29);
            label30.TabIndex = 70;
            label30.Text = "Processamento de Folha por Negócio";
            // 
            // PROCESSAMENTO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(770, 487);
            Controls.Add(label30);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PROCESSAMENTO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PROCESSAMENTO";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker1;
        private Label label30;
    }
}