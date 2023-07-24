namespace Diet.UI
{
    partial class frmUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnBack = new Button();
            btnLogin2 = new Button();
            txtUserName = new TextBox();
            lblUserName = new Label();
            btnForgotPassword = new Button();
            btnLogOut = new Button();
            lblnecessary2 = new Label();
            lblnecessary3 = new Label();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(424, 347);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 23);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Şifre :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(424, 382);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(619, 39);
            txtPassword.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 8;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = SystemColors.Control;
            btnLogin2.BackgroundImage = (Image)resources.GetObject("btnLogin2.BackgroundImage");
            btnLogin2.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin2.ForeColor = Color.White;
            btnLogin2.Location = new Point(650, 458);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(169, 58);
            btnLogin2.TabIndex = 7;
            btnLogin2.Text = "Oturum Aç";
            btnLogin2.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ScrollBar;
            txtUserName.Location = new Point(424, 280);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(619, 39);
            txtUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(424, 241);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(117, 23);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "Kullanıcı Adı :";
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = SystemColors.ControlDark;
            btnForgotPassword.Font = new Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnForgotPassword.Location = new Point(424, 427);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(156, 27);
            btnForgotPassword.TabIndex = 8;
            btnForgotPassword.Text = "Şifremi Unuttum";
            btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1346, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 12;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(1049, 280);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 13;
            lblnecessary2.Text = "*";
            // 
            // lblnecessary3
            // 
            lblnecessary3.AutoSize = true;
            lblnecessary3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary3.ForeColor = Color.Red;
            lblnecessary3.Location = new Point(1049, 382);
            lblnecessary3.Name = "lblnecessary3";
            lblnecessary3.Size = new Size(17, 19);
            lblnecessary3.TabIndex = 13;
            lblnecessary3.Text = "*";
            // 
            // frmUserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblnecessary3);
            Controls.Add(lblnecessary2);
            Controls.Add(btnLogOut);
            Controls.Add(lblUserName);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnBack);
            Controls.Add(btnLogin2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserLogin";
            Text = "frmUserLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnBack;
        private Button btnLogin2;
        private TextBox txtUserName;
        private Label lblUserName;
        private Button btnForgotPassword;
        private Button btnLogOut;
        private Label lblnecessary2;
        private Label lblnecessary3;
    }
}