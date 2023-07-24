namespace Diet.UI
{
    partial class frmNewUser2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser2));
            btnLogOut = new Button();
            btnForward = new Button();
            btnBack = new Button();
            lblHipCircumference = new Label();
            lblNeckCircumference = new Label();
            lblWaistCircumference = new Label();
            txtHipCircumference = new TextBox();
            txtNeckCircumference = new TextBox();
            txtWaistCircumference = new TextBox();
            lblnecessary = new Label();
            lblnecessary2 = new Label();
            lblnecessary3 = new Label();
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
            btnLogOut.TabIndex = 46;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = SystemColors.ControlDark;
            btnForward.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnForward.Location = new Point(1233, 696);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(139, 48);
            btnForward.TabIndex = 44;
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
            btnBack.TabIndex = 45;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblHipCircumference
            // 
            lblHipCircumference.AutoSize = true;
            lblHipCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHipCircumference.Location = new Point(961, 374);
            lblHipCircumference.Name = "lblHipCircumference";
            lblHipCircumference.Size = new Size(123, 23);
            lblHipCircumference.TabIndex = 43;
            lblHipCircumference.Text = "Kalça Çevresi :";
            // 
            // lblNeckCircumference
            // 
            lblNeckCircumference.AutoSize = true;
            lblNeckCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNeckCircumference.Location = new Point(511, 374);
            lblNeckCircumference.Name = "lblNeckCircumference";
            lblNeckCircumference.Size = new Size(171, 23);
            lblNeckCircumference.TabIndex = 41;
            lblNeckCircumference.Text = "Boyun Çevresi (cm) :";
            // 
            // lblWaistCircumference
            // 
            lblWaistCircumference.AutoSize = true;
            lblWaistCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWaistCircumference.Location = new Point(39, 377);
            lblWaistCircumference.Name = "lblWaistCircumference";
            lblWaistCircumference.Size = new Size(147, 23);
            lblWaistCircumference.TabIndex = 40;
            lblWaistCircumference.Text = "Bel Çevresi (cm) :";
            // 
            // txtHipCircumference
            // 
            txtHipCircumference.BackColor = SystemColors.ScrollBar;
            txtHipCircumference.Location = new Point(961, 400);
            txtHipCircumference.Multiline = true;
            txtHipCircumference.Name = "txtHipCircumference";
            txtHipCircumference.Size = new Size(386, 27);
            txtHipCircumference.TabIndex = 37;
            // 
            // txtNeckCircumference
            // 
            txtNeckCircumference.BackColor = SystemColors.ScrollBar;
            txtNeckCircumference.Location = new Point(511, 403);
            txtNeckCircumference.Multiline = true;
            txtNeckCircumference.Name = "txtNeckCircumference";
            txtNeckCircumference.Size = new Size(386, 27);
            txtNeckCircumference.TabIndex = 38;
            // 
            // txtWaistCircumference
            // 
            txtWaistCircumference.BackColor = SystemColors.ScrollBar;
            txtWaistCircumference.Location = new Point(39, 403);
            txtWaistCircumference.Multiline = true;
            txtWaistCircumference.Name = "txtWaistCircumference";
            txtWaistCircumference.Size = new Size(386, 27);
            txtWaistCircumference.TabIndex = 39;
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(431, 411);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 47;
            lblnecessary.Text = "*";
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(903, 411);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 48;
            lblnecessary2.Text = "*";
            // 
            // lblnecessary3
            // 
            lblnecessary3.AutoSize = true;
            lblnecessary3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary3.ForeColor = Color.Red;
            lblnecessary3.Location = new Point(1353, 408);
            lblnecessary3.Name = "lblnecessary3";
            lblnecessary3.Size = new Size(17, 19);
            lblnecessary3.TabIndex = 49;
            lblnecessary3.Text = "*";
            // 
            // frmNewUser2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblnecessary3);
            Controls.Add(lblnecessary2);
            Controls.Add(lblnecessary);
            Controls.Add(btnLogOut);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(lblHipCircumference);
            Controls.Add(lblNeckCircumference);
            Controls.Add(lblWaistCircumference);
            Controls.Add(txtHipCircumference);
            Controls.Add(txtNeckCircumference);
            Controls.Add(txtWaistCircumference);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewUser2";
            Text = "frmNewUser2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnForward;
        private Button btnBack;
        private Label lblHipCircumference;
        private Label lblNeckCircumference;
        private Label lblWaistCircumference;
        private TextBox txtHipCircumference;
        private TextBox txtNeckCircumference;
        private TextBox txtWaistCircumference;
        private Label lblnecessary;
        private Label lblnecessary2;
        private Label lblnecessary3;
    }
}