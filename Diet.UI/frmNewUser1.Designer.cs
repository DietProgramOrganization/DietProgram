namespace Diet.UI
{
    partial class frmNewUser1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser1));
            checkBoxFemale = new CheckBox();
            checkBoxMale = new CheckBox();
            lblGender = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            txtWeight = new TextBox();
            lblWeight = new Label();
            btnBack = new Button();
            btnLogOut = new Button();
            btnForward = new Button();
            label6 = new Label();
            lblnecessary = new Label();
            label8 = new Label();
            label9 = new Label();
            lblnecessary2 = new Label();
            lblnecessary1 = new Label();
            lblnecessary3 = new Label();
            SuspendLayout();
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(544, 224);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(82, 31);
            checkBoxFemale.TabIndex = 0;
            checkBoxFemale.Text = "Kadın";
            checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(646, 224);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(80, 31);
            checkBoxMale.TabIndex = 0;
            checkBoxMale.Text = "Erkek";
            checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(415, 224);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(94, 27);
            lblGender.TabIndex = 1;
            lblGender.Text = "Cinsiyet :";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(415, 432);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(49, 23);
            lblHeight.TabIndex = 24;
            lblHeight.Text = "Boy :";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(415, 368);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 23);
            lblAge.TabIndex = 23;
            lblAge.Text = "Yaş :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(415, 307);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 23);
            lblName.TabIndex = 22;
            lblName.Text = "İsim :";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.ScrollBar;
            txtHeight.Location = new Point(415, 458);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(557, 27);
            txtHeight.TabIndex = 19;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ScrollBar;
            txtAge.Location = new Point(415, 394);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(557, 27);
            txtAge.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Location = new Point(415, 333);
            txtName.Name = "txtName";
            txtName.Size = new Size(557, 27);
            txtName.TabIndex = 21;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.ScrollBar;
            txtWeight.Location = new Point(415, 529);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(557, 27);
            txtWeight.TabIndex = 19;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.Location = new Point(415, 503);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(49, 23);
            lblWeight.TabIndex = 24;
            lblWeight.Text = "Kilo :";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 710);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 25;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 32;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = SystemColors.ControlDark;
            btnForward.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnForward.Location = new Point(1233, 701);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(139, 48);
            btnForward.TabIndex = 25;
            btnForward.Text = "İleri";
            btnForward.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(515, 224);
            label6.Name = "label6";
            label6.Size = new Size(17, 19);
            label6.TabIndex = 38;
            label6.Text = "*";
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(978, 336);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 39;
            lblnecessary.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(978, 466);
            label8.Name = "label8";
            label8.Size = new Size(17, 19);
            label8.TabIndex = 40;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(978, 397);
            label9.Name = "label9";
            label9.Size = new Size(17, 19);
            label9.TabIndex = 40;
            label9.Text = "*";
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(978, 463);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 40;
            lblnecessary2.Text = "*";
            // 
            // lblnecessary1
            // 
            lblnecessary1.AutoSize = true;
            lblnecessary1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary1.ForeColor = Color.Red;
            lblnecessary1.Location = new Point(978, 394);
            lblnecessary1.Name = "lblnecessary1";
            lblnecessary1.Size = new Size(17, 19);
            lblnecessary1.TabIndex = 40;
            lblnecessary1.Text = "*";
            // 
            // lblnecessary3
            // 
            lblnecessary3.AutoSize = true;
            lblnecessary3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary3.ForeColor = Color.Red;
            lblnecessary3.Location = new Point(978, 532);
            lblnecessary3.Name = "lblnecessary3";
            lblnecessary3.Size = new Size(17, 19);
            lblnecessary3.TabIndex = 40;
            lblnecessary3.Text = "*";
            // 
            // frmNewUser1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblnecessary1);
            Controls.Add(lblnecessary3);
            Controls.Add(lblnecessary2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblnecessary);
            Controls.Add(label6);
            Controls.Add(btnLogOut);
            Controls.Add(btnForward);
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
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNewUser1";
            Text = "frmNewUser1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxFemale;
        private CheckBox checkBoxMale;
        private Label lblGender;
        private Label lblHeight;
        private Label lblAge;
        private Label lblName;
        private TextBox txtHeight;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtWeight;
        private Label lblWeight;
        private Button btnBack;
        private Button btnLogOut;
        private Button btnForward;
        private Label label6;
        private Label lblnecessary;
        private Label label8;
        private Label label9;
        private Label lblnecessary2;
        private Label lblnecessary1;
        private Label lblnecessary3;
    }
}