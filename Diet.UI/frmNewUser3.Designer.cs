namespace Diet.UI
{
    partial class frmNewUser3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser3));
            btnLogOut = new Button();
            btnForward = new Button();
            btnBack = new Button();
            btnLessActive = new Button();
            lblHowActiveAreYou = new Label();
            btnMidActive = new Button();
            btnActive = new Button();
            lblnecessary = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 7);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 55;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = SystemColors.ControlDark;
            btnForward.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnForward.Location = new Point(1233, 696);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(139, 48);
            btnForward.TabIndex = 53;
            btnForward.Text = "İleri";
            btnForward.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 705);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 54;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLessActive
            // 
            btnLessActive.BackgroundImage = (Image)resources.GetObject("btnLessActive.BackgroundImage");
            btnLessActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnLessActive.DialogResult = DialogResult.Abort;
            btnLessActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLessActive.ForeColor = Color.White;
            btnLessActive.Location = new Point(242, 408);
            btnLessActive.Name = "btnLessActive";
            btnLessActive.Size = new Size(181, 69);
            btnLessActive.TabIndex = 56;
            btnLessActive.Text = "Az Hareketli";
            btnLessActive.UseVisualStyleBackColor = true;
            // 
            // lblHowActiveAreYou
            // 
            lblHowActiveAreYou.AutoSize = true;
            lblHowActiveAreYou.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHowActiveAreYou.Location = new Point(430, 210);
            lblHowActiveAreYou.Name = "lblHowActiveAreYou";
            lblHowActiveAreYou.Size = new Size(479, 59);
            lblHowActiveAreYou.TabIndex = 57;
            lblHowActiveAreYou.Text = "Ne Kadar Hareketlisin?";
            // 
            // btnMidActive
            // 
            btnMidActive.BackgroundImage = (Image)resources.GetObject("btnMidActive.BackgroundImage");
            btnMidActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnMidActive.DialogResult = DialogResult.Abort;
            btnMidActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMidActive.ForeColor = Color.White;
            btnMidActive.Location = new Point(541, 408);
            btnMidActive.Name = "btnMidActive";
            btnMidActive.Size = new Size(290, 69);
            btnMidActive.TabIndex = 56;
            btnMidActive.Text = "Orta Derece Hareketli";
            btnMidActive.UseVisualStyleBackColor = true;
            // 
            // btnActive
            // 
            btnActive.BackgroundImage = (Image)resources.GetObject("btnActive.BackgroundImage");
            btnActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnActive.DialogResult = DialogResult.Abort;
            btnActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(952, 408);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(192, 69);
            btnActive.TabIndex = 56;
            btnActive.Text = "Çok Hareketli";
            btnActive.UseVisualStyleBackColor = true;
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(915, 210);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 58;
            lblnecessary.Text = "*";
            // 
            // frmNewUser3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblnecessary);
            Controls.Add(lblHowActiveAreYou);
            Controls.Add(btnActive);
            Controls.Add(btnMidActive);
            Controls.Add(btnLessActive);
            Controls.Add(btnLogOut);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewUser3";
            Text = "frmNewUser3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnForward;
        private Button btnBack;
        private Button btnLessActive;
        private Label lblHowActiveAreYou;
        private Button btnMidActive;
        private Button btnActive;
        private Label lblnecessary;
    }
}