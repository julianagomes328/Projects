namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class Cofiguracoes
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
            label1 = new Label();
            textUserConfig = new TextBox();
            textSenhaConfig = new TextBox();
            label2 = new Label();
            btnCadConfig = new Button();
            textReConfig = new TextBox();
            label4 = new Label();
            label30 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 188);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // textUserConfig
            // 
            textUserConfig.Location = new Point(293, 185);
            textUserConfig.Name = "textUserConfig";
            textUserConfig.Size = new Size(180, 23);
            textUserConfig.TabIndex = 1;
            // 
            // textSenhaConfig
            // 
            textSenhaConfig.Location = new Point(293, 223);
            textSenhaConfig.Name = "textSenhaConfig";
            textSenhaConfig.Size = new Size(180, 23);
            textSenhaConfig.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 226);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // btnCadConfig
            // 
            btnCadConfig.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadConfig.ForeColor = Color.DimGray;
            btnCadConfig.Location = new Point(293, 261);
            btnCadConfig.Name = "btnCadConfig";
            btnCadConfig.Size = new Size(93, 29);
            btnCadConfig.TabIndex = 6;
            btnCadConfig.Text = "Salvar";
            btnCadConfig.UseVisualStyleBackColor = true;
            // 
            // textReConfig
            // 
            textReConfig.Location = new Point(293, 146);
            textReConfig.Name = "textReConfig";
            textReConfig.Size = new Size(180, 23);
            textReConfig.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 149);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Registro:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.MenuHighlight;
            label30.Location = new Point(12, 9);
            label30.Name = "label30";
            label30.Size = new Size(331, 29);
            label30.TabIndex = 69;
            label30.Text = "Gerenciamento de Usuários";
            // 
            // Cofiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(786, 526);
            Controls.Add(label30);
            Controls.Add(textReConfig);
            Controls.Add(label4);
            Controls.Add(btnCadConfig);
            Controls.Add(textSenhaConfig);
            Controls.Add(label2);
            Controls.Add(textUserConfig);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cofiguracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cofiguracoes";
            Load += Cofiguracoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUserConfig;
        private TextBox textSenhaConfig;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Button btnCadConfig;
        private Button button2;
        private Button button3;
        private TextBox textReConfig;
        private Label label4;
        private Label label30;
    }
}