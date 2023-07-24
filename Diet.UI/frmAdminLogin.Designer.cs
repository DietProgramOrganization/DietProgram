namespace Diet.UI
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            btnLogin = new Button();
            btnBack = new Button();
            btnLogOut1 = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(569, 387);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 58);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Oturum Aç";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 2;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogOut1
            // 
            btnLogOut1.BackColor = Color.Transparent;
            btnLogOut1.BackgroundImage = (Image)resources.GetObject("btnLogOut1.BackgroundImage");
            btnLogOut1.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut1.Location = new Point(1342, 12);
            btnLogOut1.Name = "btnLogOut1";
            btnLogOut1.Size = new Size(30, 30);
            btnLogOut1.TabIndex = 4;
            btnLogOut1.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(345, 313);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(619, 39);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(345, 276);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Şifre :";
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogOut1);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminLogin";
            Text = "frmAdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnBack;
        private Button btnLogOut1;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}