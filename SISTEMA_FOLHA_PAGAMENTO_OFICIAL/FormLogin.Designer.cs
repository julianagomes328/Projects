namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textUsuario = new TextBox();
            label1 = new Label();
            buttonEntrar = new Button();
            label2 = new Label();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.Location = new Point(324, 175);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(170, 27);
            textUsuario.TabIndex = 0;
            textUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 179);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            label1.Click += label1_Click;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrar.ForeColor = Color.DimGray;
            buttonEntrar.Location = new Point(324, 260);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(121, 30);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(256, 222);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(324, 218);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(170, 27);
            textPassword.TabIndex = 3;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textBox2_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(828, 376);
            Controls.Add(label2);
            Controls.Add(textPassword);
            Controls.Add(buttonEntrar);
            Controls.Add(label1);
            Controls.Add(textUsuario);
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private Label label1;
        private Button buttonEntrar;
        private Label label2;
        private TextBox textPassword;
    }
}