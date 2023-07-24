namespace Diet.UI
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            btnLogOut = new Button();
            btnBack = new Button();
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            lblGender = new Label();
            checkBoxMale = new CheckBox();
            checkBoxFemale = new CheckBox();
            lblHipCircumference = new Label();
            lblNeckCircumference = new Label();
            lblWaistCircumference = new Label();
            txtHipCircumference = new TextBox();
            txtNeckCircumference = new TextBox();
            txtWaistCircumference = new TextBox();
            lblHowActiveAreYou = new Label();
            btnActive = new Button();
            btnMidActive = new Button();
            btnLessActive = new Button();
            btnSaveInfo = new Button();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 7);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 46;
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 705);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 45;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.Location = new Point(482, 315);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(49, 23);
            lblWeight.TabIndex = 42;
            lblWeight.Text = "Kilo :";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(482, 263);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(49, 23);
            lblHeight.TabIndex = 43;
            lblHeight.Text = "Boy :";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(482, 211);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 23);
            lblAge.TabIndex = 41;
            lblAge.Text = "Yaş :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(482, 159);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 23);
            lblName.TabIndex = 40;
            lblName.Text = "İsim :";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.ScrollBar;
            txtWeight.Location = new Point(547, 318);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(386, 23);
            txtWeight.TabIndex = 36;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.ScrollBar;
            txtHeight.Location = new Point(547, 266);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(386, 23);
            txtHeight.TabIndex = 37;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ScrollBar;
            txtAge.Location = new Point(548, 211);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(386, 23);
            txtAge.TabIndex = 38;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Location = new Point(548, 159);
            txtName.Name = "txtName";
            txtName.Size = new Size(386, 23);
            txtName.TabIndex = 39;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(482, 117);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(94, 27);
            lblGender.TabIndex = 35;
            lblGender.Text = "Cinsiyet :";
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(713, 117);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(80, 31);
            checkBoxMale.TabIndex = 33;
            checkBoxMale.Text = "Erkek";
            checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(611, 117);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(82, 31);
            checkBoxFemale.TabIndex = 34;
            checkBoxFemale.Text = "Kadın";
            checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // lblHipCircumference
            // 
            lblHipCircumference.AutoSize = true;
            lblHipCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHipCircumference.Location = new Point(408, 493);
            lblHipCircumference.Name = "lblHipCircumference";
            lblHipCircumference.Size = new Size(123, 23);
            lblHipCircumference.TabIndex = 52;
            lblHipCircumference.Text = "Kalça Çevresi :";
            // 
            // lblNeckCircumference
            // 
            lblNeckCircumference.AutoSize = true;
            lblNeckCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNeckCircumference.Location = new Point(363, 437);
            lblNeckCircumference.Name = "lblNeckCircumference";
            lblNeckCircumference.Size = new Size(171, 23);
            lblNeckCircumference.TabIndex = 51;
            lblNeckCircumference.Text = "Boyun Çevresi (cm) :";
            // 
            // lblWaistCircumference
            // 
            lblWaistCircumference.AutoSize = true;
            lblWaistCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWaistCircumference.Location = new Point(387, 375);
            lblWaistCircumference.Name = "lblWaistCircumference";
            lblWaistCircumference.Size = new Size(147, 23);
            lblWaistCircumference.TabIndex = 50;
            lblWaistCircumference.Text = "Bel Çevresi (cm) :";
            // 
            // txtHipCircumference
            // 
            txtHipCircumference.BackColor = SystemColors.ScrollBar;
            txtHipCircumference.Location = new Point(547, 496);
            txtHipCircumference.Multiline = true;
            txtHipCircumference.Name = "txtHipCircumference";
            txtHipCircumference.Size = new Size(386, 27);
            txtHipCircumference.TabIndex = 47;
            // 
            // txtNeckCircumference
            // 
            txtNeckCircumference.BackColor = SystemColors.ScrollBar;
            txtNeckCircumference.Location = new Point(548, 440);
            txtNeckCircumference.Multiline = true;
            txtNeckCircumference.Name = "txtNeckCircumference";
            txtNeckCircumference.Size = new Size(386, 27);
            txtNeckCircumference.TabIndex = 48;
            // 
            // txtWaistCircumference
            // 
            txtWaistCircumference.BackColor = SystemColors.ScrollBar;
            txtWaistCircumference.Location = new Point(548, 378);
            txtWaistCircumference.Multiline = true;
            txtWaistCircumference.Name = "txtWaistCircumference";
            txtWaistCircumference.Size = new Size(386, 27);
            txtWaistCircumference.TabIndex = 49;
            // 
            // lblHowActiveAreYou
            // 
            lblHowActiveAreYou.AutoSize = true;
            lblHowActiveAreYou.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblHowActiveAreYou.Location = new Point(547, 573);
            lblHowActiveAreYou.Name = "lblHowActiveAreYou";
            lblHowActiveAreYou.Size = new Size(300, 37);
            lblHowActiveAreYou.TabIndex = 61;
            lblHowActiveAreYou.Text = "Ne Kadar Hareketlisin?";
            // 
            // btnActive
            // 
            btnActive.BackgroundImage = (Image)resources.GetObject("btnActive.BackgroundImage");
            btnActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnActive.DialogResult = DialogResult.Abort;
            btnActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(959, 624);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(208, 46);
            btnActive.TabIndex = 58;
            btnActive.Text = "Çok Hareketli";
            btnActive.UseVisualStyleBackColor = true;
            // 
            // btnMidActive
            // 
            btnMidActive.BackgroundImage = (Image)resources.GetObject("btnMidActive.BackgroundImage");
            btnMidActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnMidActive.DialogResult = DialogResult.Abort;
            btnMidActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMidActive.ForeColor = Color.White;
            btnMidActive.Location = new Point(548, 624);
            btnMidActive.Name = "btnMidActive";
            btnMidActive.Size = new Size(306, 46);
            btnMidActive.TabIndex = 59;
            btnMidActive.Text = "Orta Derece Hareketli";
            btnMidActive.UseVisualStyleBackColor = true;
            // 
            // btnLessActive
            // 
            btnLessActive.BackgroundImage = (Image)resources.GetObject("btnLessActive.BackgroundImage");
            btnLessActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnLessActive.DialogResult = DialogResult.Abort;
            btnLessActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLessActive.ForeColor = Color.White;
            btnLessActive.Location = new Point(249, 624);
            btnLessActive.Name = "btnLessActive";
            btnLessActive.Size = new Size(197, 46);
            btnLessActive.TabIndex = 60;
            btnLessActive.Text = "Az Hareketli";
            btnLessActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.BackgroundImage = (Image)resources.GetObject("btnSaveInfo.BackgroundImage");
            btnSaveInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveInfo.DialogResult = DialogResult.Abort;
            btnSaveInfo.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveInfo.ForeColor = Color.White;
            btnSaveInfo.Location = new Point(1211, 705);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(161, 48);
            btnSaveInfo.TabIndex = 62;
            btnSaveInfo.Text = "Bilgileri Kaydet...";
            btnSaveInfo.UseVisualStyleBackColor = true;
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(btnSaveInfo);
            Controls.Add(lblHowActiveAreYou);
            Controls.Add(btnActive);
            Controls.Add(btnMidActive);
            Controls.Add(btnLessActive);
            Controls.Add(lblHipCircumference);
            Controls.Add(lblNeckCircumference);
            Controls.Add(lblWaistCircumference);
            Controls.Add(txtHipCircumference);
            Controls.Add(txtNeckCircumference);
            Controls.Add(txtWaistCircumference);
            Controls.Add(btnLogOut);
            Controls.Add(btnBack);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(checkBoxMale);
            Controls.Add(checkBoxFemale);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserProfile";
            Text = "frmUserProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnBack;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label lblName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;
        private TextBox txtName;
        private Label lblGender;
        private CheckBox checkBoxMale;
        private CheckBox checkBoxFemale;
        private Label lblHipCircumference;
        private Label lblNeckCircumference;
        private Label lblWaistCircumference;
        private TextBox txtHipCircumference;
        private TextBox txtNeckCircumference;
        private TextBox txtWaistCircumference;
        private Label lblHowActiveAreYou;
        private Button btnActive;
        private Button btnMidActive;
        private Button btnLessActive;
        private Button btnSaveInfo;
    }
}