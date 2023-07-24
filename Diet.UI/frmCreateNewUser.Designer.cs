namespace Diet.UI
{
    partial class frmCreateNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewUser));
            lblnecessary1 = new Label();
            lblnecessary2 = new Label();
            btnLogOut = new Button();
            lbltxtSecurityCode = new Label();
            lblPasswordConfirm = new Label();
            txtSecurityCode = new TextBox();
            txtPasswordConfirm = new TextBox();
            btnBack = new Button();
            btnCreateNewUser = new Button();
            lblnecessary = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnInfo = new Button();
            SuspendLayout();
            // 
            // lblnecessary1
            // 
            lblnecessary1.AutoSize = true;
            lblnecessary1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary1.ForeColor = Color.Red;
            lblnecessary1.Location = new Point(1039, 343);
            lblnecessary1.Name = "lblnecessary1";
            lblnecessary1.Size = new Size(17, 19);
            lblnecessary1.TabIndex = 33;
            lblnecessary1.Text = "*";
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(1039, 421);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 34;
            lblnecessary2.Text = "*";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 31;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lbltxtSecurityCode
            // 
            lbltxtSecurityCode.AutoSize = true;
            lbltxtSecurityCode.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtSecurityCode.Location = new Point(414, 413);
            lbltxtSecurityCode.Name = "lbltxtSecurityCode";
            lbltxtSecurityCode.Size = new Size(200, 23);
            lbltxtSecurityCode.TabIndex = 28;
            lbltxtSecurityCode.Text = "Güvenlik Kodunu Giriniz";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordConfirm.Location = new Point(414, 317);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(105, 23);
            lblPasswordConfirm.TabIndex = 30;
            lblPasswordConfirm.Text = "Şifre Tekrar:";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.BackColor = SystemColors.ScrollBar;
            txtSecurityCode.Location = new Point(414, 439);
            txtSecurityCode.Multiline = true;
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.Size = new Size(619, 39);
            txtSecurityCode.TabIndex = 25;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = SystemColors.ScrollBar;
            txtPasswordConfirm.Location = new Point(414, 343);
            txtPasswordConfirm.Multiline = true;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(619, 39);
            txtPasswordConfirm.TabIndex = 27;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(2, 698);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 24;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnCreateNewUser
            // 
            btnCreateNewUser.BackColor = SystemColors.Control;
            btnCreateNewUser.BackgroundImage = (Image)resources.GetObject("btnCreateNewUser.BackgroundImage");
            btnCreateNewUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateNewUser.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateNewUser.ForeColor = Color.White;
            btnCreateNewUser.Location = new Point(613, 517);
            btnCreateNewUser.Name = "btnCreateNewUser";
            btnCreateNewUser.Size = new Size(222, 58);
            btnCreateNewUser.TabIndex = 23;
            btnCreateNewUser.Text = "Yeni Kullanıcı Oluştur";
            btnCreateNewUser.UseVisualStyleBackColor = false;
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(1039, 253);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 37;
            lblnecessary.Text = "*";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(414, 227);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(117, 23);
            lblUserName.TabIndex = 36;
            lblUserName.Text = "Kullanıcı Adı :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ScrollBar;
            txtUserName.Location = new Point(414, 253);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(619, 39);
            txtUserName.TabIndex = 35;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = SystemColors.ButtonShadow;
            btnInfo.Font = new Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.Location = new Point(1039, 450);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(30, 28);
            btnInfo.TabIndex = 38;
            btnInfo.Text = "?";
            btnInfo.UseVisualStyleBackColor = false;
            // 
            // frmCreateNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(btnInfo);
            Controls.Add(lblnecessary);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblnecessary1);
            Controls.Add(lblnecessary2);
            Controls.Add(btnLogOut);
            Controls.Add(lbltxtSecurityCode);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(txtSecurityCode);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(btnBack);
            Controls.Add(btnCreateNewUser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateNewUser";
            Text = "frmCreateNewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnecessary1;
        private Label lblnecessary2;
        private Button btnLogOut;
        private Label lbltxtSecurityCode;
        private Label lblPasswordConfirm;
        private TextBox txtSecurityCode;
        private TextBox txtPasswordConfirm;
        private Button btnBack;
        private Button btnCreateNewUser;
        private Label lblnecessary;
        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnInfo;
    }
}