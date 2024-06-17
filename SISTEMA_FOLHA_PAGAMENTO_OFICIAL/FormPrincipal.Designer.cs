namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelPrincipal = new Panel();
            button2 = new Button();
            button1 = new Button();
            buttonProcessadorMenu = new Button();
            buttonMenuFunc = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.GradientInactiveCaption;
            panelPrincipal.Controls.Add(button2);
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(buttonProcessadorMenu);
            panelPrincipal.Controls.Add(buttonMenuFunc);
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Location = new Point(0, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(216, 575);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkCyan;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 380);
            button2.Name = "button2";
            button2.Size = new Size(210, 73);
            button2.TabIndex = 4;
            button2.Text = " Relatórios";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkCyan;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 280);
            button1.Name = "button1";
            button1.Size = new Size(210, 73);
            button1.TabIndex = 3;
            button1.Text = "Configurações";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonProcessadorMenu
            // 
            buttonProcessadorMenu.BackColor = Color.Transparent;
            buttonProcessadorMenu.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonProcessadorMenu.FlatAppearance.BorderSize = 0;
            buttonProcessadorMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonProcessadorMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonProcessadorMenu.FlatStyle = FlatStyle.Flat;
            buttonProcessadorMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProcessadorMenu.ForeColor = Color.DarkCyan;
            buttonProcessadorMenu.Image = (Image)resources.GetObject("buttonProcessadorMenu.Image");
            buttonProcessadorMenu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProcessadorMenu.Location = new Point(3, 186);
            buttonProcessadorMenu.Name = "buttonProcessadorMenu";
            buttonProcessadorMenu.Size = new Size(210, 73);
            buttonProcessadorMenu.TabIndex = 2;
            buttonProcessadorMenu.Text = "Processamento";
            buttonProcessadorMenu.TextAlign = ContentAlignment.MiddleLeft;
            buttonProcessadorMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProcessadorMenu.UseVisualStyleBackColor = false;
            buttonProcessadorMenu.Click += buttonProcessadorMenu_Click;
            // 
            // buttonMenuFunc
            // 
            buttonMenuFunc.BackColor = Color.Transparent;
            buttonMenuFunc.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonMenuFunc.FlatAppearance.BorderSize = 0;
            buttonMenuFunc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMenuFunc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMenuFunc.FlatStyle = FlatStyle.Flat;
            buttonMenuFunc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuFunc.ForeColor = Color.DarkCyan;
            buttonMenuFunc.Image = (Image)resources.GetObject("buttonMenuFunc.Image");
            buttonMenuFunc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenuFunc.Location = new Point(3, 94);
            buttonMenuFunc.Name = "buttonMenuFunc";
            buttonMenuFunc.Size = new Size(210, 73);
            buttonMenuFunc.TabIndex = 1;
            buttonMenuFunc.Text = "Funcionário";
            buttonMenuFunc.TextAlign = ContentAlignment.MiddleLeft;
            buttonMenuFunc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMenuFunc.UseVisualStyleBackColor = false;
            buttonMenuFunc.Click += buttonMenuFunc_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = Color.DarkCyan;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 91);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(66, 23);
            label1.Name = "label1";
            label1.Size = new Size(121, 50);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelForm
            // 
            panelForm.Location = new Point(209, 2);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(827, 578);
            panelForm.TabIndex = 1;
            panelForm.Paint += panelForm_Paint;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1031, 508);
            Controls.Add(panelForm);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelPrincipal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonMenuFunc;
        private Button buttonProcessadorMenu;
        private Button button1;
        private Button button2;
        private Panel panelForm;
    }
}