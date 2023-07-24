namespace Diet.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnLogin = new Button();
            btnNewUser = new Button();
            btnAdminLogin = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(1025, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 58);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Oturum Aç";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            btnNewUser.BackgroundImage = (Image)resources.GetObject("btnNewUser.BackgroundImage");
            btnNewUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnNewUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(1025, 453);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(169, 58);
            btnNewUser.TabIndex = 1;
            btnNewUser.Text = "Yeni Kullanıcı Oluştur";
            btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackgroundImage = (Image)resources.GetObject("btnAdminLogin.BackgroundImage");
            btnAdminLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdminLogin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(1266, 49);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(106, 37);
            btnAdminLogin.TabIndex = 2;
            btnAdminLogin.Text = "Admin Giriş";
            btnAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1367, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(btnLogOut);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnNewUser);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnNewUser;
        private Button btnAdminLogin;
        private Button btnLogOut;
    }
}