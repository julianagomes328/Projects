namespace SISTEMA_FOLHA_PAGAMENTO_OFICIAL
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            panel1 = new Panel();
            PanelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 190, 156);
            panel1.Controls.Add(PanelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 526);
            panel1.TabIndex = 0;
            // 
            // PanelLogo
            // 
            PanelLogo.AllowDrop = true;
            PanelLogo.BackColor = Color.FromArgb(0, 112, 100);
            PanelLogo.Controls.Add(pictureBox1);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(198, 98);
            PanelLogo.TabIndex = 0;
            PanelLogo.Paint += PanelLogo_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 526);
            Controls.Add(panel1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            panel1.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PanelLogo;
        private PictureBox pictureBox1;
    }
}