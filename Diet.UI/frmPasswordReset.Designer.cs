namespace Diet.UI
{
    partial class frmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordReset));
            btnLogOut = new Button();
            lblPasswordConfirm = new Label();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            btnBack = new Button();
            btnSave = new Button();
            lblPassword = new Label();
            lblSecurityCode = new Label();
            txtSecurityCode = new TextBox();
            lblnecessary = new Label();
            lblnecessary3 = new Label();
            lblnecessary2 = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 21;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordConfirm.Location = new Point(404, 356);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(105, 23);
            lblPasswordConfirm.TabIndex = 19;
            lblPasswordConfirm.Text = "Şifre Tekrar:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(404, 291);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(619, 39);
            txtPassword.TabIndex = 16;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = SystemColors.ScrollBar;
            txtPasswordConfirm.Location = new Point(404, 382);
            txtPasswordConfirm.Multiline = true;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(619, 39);
            txtPasswordConfirm.TabIndex = 17;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(-8, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 15;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1203, 696);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 58);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(404, 265);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 23);
            lblPassword.TabIndex = 19;
            lblPassword.Text = "Şifre :";
            // 
            // lblSecurityCode
            // 
            lblSecurityCode.AutoSize = true;
            lblSecurityCode.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecurityCode.Location = new Point(404, 168);
            lblSecurityCode.Name = "lblSecurityCode";
            lblSecurityCode.Size = new Size(124, 23);
            lblSecurityCode.TabIndex = 18;
            lblSecurityCode.Text = "Güvenlik Kodu";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.BackColor = SystemColors.ScrollBar;
            txtSecurityCode.Location = new Point(404, 203);
            txtSecurityCode.Multiline = true;
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.Size = new Size(619, 39);
            txtSecurityCode.TabIndex = 16;
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(1029, 203);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 22;
            lblnecessary.Text = "*";
            // 
            // lblnecessary3
            // 
            lblnecessary3.AutoSize = true;
            lblnecessary3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary3.ForeColor = Color.Red;
            lblnecessary3.Location = new Point(1029, 382);
            lblnecessary3.Name = "lblnecessary3";
            lblnecessary3.Size = new Size(17, 19);
            lblnecessary3.TabIndex = 22;
            lblnecessary3.Text = "*";
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(1029, 291);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 22;
            lblnecessary2.Text = "*";
            // 
            // frmPasswordReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblnecessary2);
            Controls.Add(lblnecessary3);
            Controls.Add(lblnecessary);
            Controls.Add(btnLogOut);
            Controls.Add(lblSecurityCode);
            Controls.Add(lblPassword);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(txtSecurityCode);
            Controls.Add(txtPassword);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPasswordReset";
            Text = "frmPasswordReset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Label lblPasswordConfirm;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Button btnBack;
        private Button btnSave;
        private Label lblPassword;
        private Label lblSecurityCode;
        private TextBox txtSecurityCode;
        private Label lblnecessary;
        private Label lblnecessary3;
        private Label lblnecessary2;
    }
}