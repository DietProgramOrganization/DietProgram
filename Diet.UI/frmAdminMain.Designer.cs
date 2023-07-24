namespace Diet.UI
{
    partial class frmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            btnBack = new Button();
            btnLogOut2 = new Button();
            dataGridViewProduct = new DataGridView();
            cbProductCategory = new ComboBox();
            btnExit = new Button();
            txtProductName = new TextBox();
            txtProductCalorie = new TextBox();
            txtProteinValue = new TextBox();
            txtCarbohydrateValue = new TextBox();
            txtFatValue = new TextBox();
            txtSearch = new TextBox();
            pbProductPicture = new PictureBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblProductName = new Label();
            lblProductCategory = new Label();
            lblProductCalorie = new Label();
            lblProteinValue = new Label();
            lblCarbohydrateValue = new Label();
            lblFatValue = new Label();
            lblSearch = new Label();
            lblProductPicture = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 3;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogOut2
            // 
            btnLogOut2.BackColor = Color.Transparent;
            btnLogOut2.BackgroundImage = (Image)resources.GetObject("btnLogOut2.BackgroundImage");
            btnLogOut2.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut2.Location = new Point(1342, 12);
            btnLogOut2.Name = "btnLogOut2";
            btnLogOut2.Size = new Size(30, 30);
            btnLogOut2.TabIndex = 5;
            btnLogOut2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.BackgroundColor = SystemColors.Info;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(820, 160);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new Size(491, 345);
            dataGridViewProduct.TabIndex = 6;
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = SystemColors.ScrollBar;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Location = new Point(109, 160);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(441, 23);
            cbProductCategory.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(1233, 701);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 48);
            btnExit.TabIndex = 8;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.ScrollBar;
            txtProductName.Location = new Point(109, 228);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(441, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtProductCalorie
            // 
            txtProductCalorie.BackColor = SystemColors.ScrollBar;
            txtProductCalorie.Location = new Point(109, 297);
            txtProductCalorie.Name = "txtProductCalorie";
            txtProductCalorie.Size = new Size(441, 23);
            txtProductCalorie.TabIndex = 10;
            // 
            // txtProteinValue
            // 
            txtProteinValue.BackColor = SystemColors.ScrollBar;
            txtProteinValue.Location = new Point(109, 357);
            txtProteinValue.Name = "txtProteinValue";
            txtProteinValue.Size = new Size(441, 23);
            txtProteinValue.TabIndex = 10;
            // 
            // txtCarbohydrateValue
            // 
            txtCarbohydrateValue.BackColor = SystemColors.ScrollBar;
            txtCarbohydrateValue.Location = new Point(109, 418);
            txtCarbohydrateValue.Name = "txtCarbohydrateValue";
            txtCarbohydrateValue.Size = new Size(441, 23);
            txtCarbohydrateValue.TabIndex = 10;
            // 
            // txtFatValue
            // 
            txtFatValue.BackColor = SystemColors.ScrollBar;
            txtFatValue.Location = new Point(109, 482);
            txtFatValue.Name = "txtFatValue";
            txtFatValue.Size = new Size(441, 23);
            txtFatValue.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(882, 134);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 23);
            txtSearch.TabIndex = 10;
            // 
            // pbProductPicture
            // 
            pbProductPicture.Location = new Point(109, 546);
            pbProductPicture.Name = "pbProductPicture";
            pbProductPicture.Size = new Size(274, 133);
            pbProductPicture.TabIndex = 11;
            pbProductPicture.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(413, 546);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 33);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(413, 595);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(413, 646);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 33);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(109, 202);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(89, 23);
            lblProductName.TabIndex = 13;
            lblProductName.Text = "Ürün Adı :";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCategory.Location = new Point(109, 134);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(142, 23);
            lblProductCategory.TabIndex = 14;
            lblProductCategory.Text = "Ürün Kategorisi :";
            // 
            // lblProductCalorie
            // 
            lblProductCalorie.AutoSize = true;
            lblProductCalorie.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCalorie.Location = new Point(109, 271);
            lblProductCalorie.Name = "lblProductCalorie";
            lblProductCalorie.Size = new Size(121, 23);
            lblProductCalorie.TabIndex = 15;
            lblProductCalorie.Text = "Ürün Kalorisi :";
            // 
            // lblProteinValue
            // 
            lblProteinValue.AutoSize = true;
            lblProteinValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProteinValue.Location = new Point(109, 331);
            lblProteinValue.Name = "lblProteinValue";
            lblProteinValue.Size = new Size(135, 23);
            lblProteinValue.TabIndex = 16;
            lblProteinValue.Text = "Protein Değeri :";
            // 
            // lblCarbohydrateValue
            // 
            lblCarbohydrateValue.AutoSize = true;
            lblCarbohydrateValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarbohydrateValue.Location = new Point(109, 392);
            lblCarbohydrateValue.Name = "lblCarbohydrateValue";
            lblCarbohydrateValue.Size = new Size(180, 23);
            lblCarbohydrateValue.TabIndex = 17;
            lblCarbohydrateValue.Text = "Karbonhidrat Değeri :";
            // 
            // lblFatValue
            // 
            lblFatValue.AutoSize = true;
            lblFatValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFatValue.Location = new Point(109, 456);
            lblFatValue.Name = "lblFatValue";
            lblFatValue.Size = new Size(103, 23);
            lblFatValue.TabIndex = 18;
            lblFatValue.Text = "Yağ Değeri :";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(820, 131);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 23);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Ara :";
            // 
            // lblProductPicture
            // 
            lblProductPicture.AutoSize = true;
            lblProductPicture.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductPicture.Location = new Point(109, 520);
            lblProductPicture.Name = "lblProductPicture";
            lblProductPicture.Size = new Size(125, 23);
            lblProductPicture.TabIndex = 18;
            lblProductPicture.Text = "Ürün Fotoğrafı";
            // 
            // frmAdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(lblSearch);
            Controls.Add(lblProductPicture);
            Controls.Add(lblFatValue);
            Controls.Add(lblCarbohydrateValue);
            Controls.Add(lblProteinValue);
            Controls.Add(lblProductCalorie);
            Controls.Add(lblProductCategory);
            Controls.Add(lblProductName);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(pbProductPicture);
            Controls.Add(txtSearch);
            Controls.Add(txtFatValue);
            Controls.Add(txtCarbohydrateValue);
            Controls.Add(txtProteinValue);
            Controls.Add(txtProductCalorie);
            Controls.Add(txtProductName);
            Controls.Add(btnExit);
            Controls.Add(cbProductCategory);
            Controls.Add(dataGridViewProduct);
            Controls.Add(btnLogOut2);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Name = "frmAdminMain";
            Text = "frmAdminMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnLogOut2;
        private DataGridView dataGridViewProduct;
        private ComboBox cbProductCategory;
        private Button btnExit;
        private TextBox txtProductName;
        private TextBox txtProductCalorie;
        private TextBox txtProteinValue;
        private TextBox txtCarbohydrateValue;
        private TextBox txtFatValue;
        private TextBox txtSearch;
        private PictureBox pbProductPicture;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblProductName;
        private Label lblProductCategory;
        private Label lblProductCalorie;
        private Label lblProteinValue;
        private Label lblCarbohydrateValue;
        private Label lblFatValue;
        private Label lblSearch;
        private Label lblProductPicture;
    }
}