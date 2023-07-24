namespace Diet.UI
{
    partial class frmDinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDinner));
            btnLogOut = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lblDinner = new Label();
            lblPortions = new Label();
            numericUpDownPortions = new NumericUpDown();
            dataGridViewDinner = new DataGridView();
            dataGridViewSearch = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnDrinks = new Button();
            btnBakeryProducts = new Button();
            btnNutriens = new Button();
            btnFood = new Button();
            btnNutritionalSupplements = new Button();
            btnFruitVegatable = new Button();
            btnDelicatessen = new Button();
            btnforBreakfast = new Button();
            btnSnacks = new Button();
            btnAll = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1342, 11);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 51;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 702);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 50;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1231, 701);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 33);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(636, 510);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 33);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDinner.Location = new Point(840, 328);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(124, 23);
            lblDinner.TabIndex = 47;
            lblDinner.Text = "Akşam Yemeği";
            // 
            // lblPortions
            // 
            lblPortions.AutoSize = true;
            lblPortions.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPortions.Location = new Point(704, 396);
            lblPortions.Name = "lblPortions";
            lblPortions.Size = new Size(130, 23);
            lblPortions.TabIndex = 46;
            lblPortions.Text = "Porsiyon Adedi";
            // 
            // numericUpDownPortions
            // 
            numericUpDownPortions.Location = new Point(704, 365);
            numericUpDownPortions.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPortions.Name = "numericUpDownPortions";
            numericUpDownPortions.Size = new Size(130, 23);
            numericUpDownPortions.TabIndex = 45;
            // 
            // dataGridViewDinner
            // 
            dataGridViewDinner.BackgroundColor = SystemColors.Info;
            dataGridViewDinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDinner.Location = new Point(840, 364);
            dataGridViewDinner.Name = "dataGridViewDinner";
            dataGridViewDinner.RowTemplate.Height = 25;
            dataGridViewDinner.Size = new Size(491, 331);
            dataGridViewDinner.TabIndex = 44;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.BackgroundColor = SystemColors.Info;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(42, 365);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(491, 331);
            dataGridViewSearch.TabIndex = 43;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(42, 318);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 23);
            lblSearch.TabIndex = 42;
            lblSearch.Text = "Ara :";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(104, 314);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 23);
            txtSearch.TabIndex = 41;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = SystemColors.Control;
            btnDrinks.BackgroundImage = (Image)resources.GetObject("btnDrinks.BackgroundImage");
            btnDrinks.BackgroundImageLayout = ImageLayout.Stretch;
            btnDrinks.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrinks.ForeColor = Color.White;
            btnDrinks.Location = new Point(928, 206);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(169, 58);
            btnDrinks.TabIndex = 40;
            btnDrinks.Text = "İçecek";
            btnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnBakeryProducts
            // 
            btnBakeryProducts.BackColor = SystemColors.Control;
            btnBakeryProducts.BackgroundImage = (Image)resources.GetObject("btnBakeryProducts.BackgroundImage");
            btnBakeryProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnBakeryProducts.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBakeryProducts.ForeColor = Color.White;
            btnBakeryProducts.Location = new Point(706, 206);
            btnBakeryProducts.Name = "btnBakeryProducts";
            btnBakeryProducts.Size = new Size(169, 58);
            btnBakeryProducts.TabIndex = 39;
            btnBakeryProducts.Text = "Unlu Mamuller";
            btnBakeryProducts.UseVisualStyleBackColor = false;
            // 
            // btnNutriens
            // 
            btnNutriens.BackColor = SystemColors.Control;
            btnNutriens.BackgroundImage = (Image)resources.GetObject("btnNutriens.BackgroundImage");
            btnNutriens.BackgroundImageLayout = ImageLayout.Stretch;
            btnNutriens.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNutriens.ForeColor = Color.White;
            btnNutriens.Location = new Point(496, 206);
            btnNutriens.Name = "btnNutriens";
            btnNutriens.Size = new Size(169, 58);
            btnNutriens.TabIndex = 38;
            btnNutriens.Text = "Gıda";
            btnNutriens.UseVisualStyleBackColor = false;
            // 
            // btnFood
            // 
            btnFood.BackColor = SystemColors.Control;
            btnFood.BackgroundImage = (Image)resources.GetObject("btnFood.BackgroundImage");
            btnFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnFood.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFood.ForeColor = Color.White;
            btnFood.Location = new Point(289, 206);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(169, 58);
            btnFood.TabIndex = 37;
            btnFood.Text = "Yemek";
            btnFood.UseVisualStyleBackColor = false;
            // 
            // btnNutritionalSupplements
            // 
            btnNutritionalSupplements.BackColor = SystemColors.Control;
            btnNutritionalSupplements.BackgroundImage = (Image)resources.GetObject("btnNutritionalSupplements.BackgroundImage");
            btnNutritionalSupplements.BackgroundImageLayout = ImageLayout.Stretch;
            btnNutritionalSupplements.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNutritionalSupplements.ForeColor = Color.White;
            btnNutritionalSupplements.Location = new Point(1140, 132);
            btnNutritionalSupplements.Name = "btnNutritionalSupplements";
            btnNutritionalSupplements.Size = new Size(169, 58);
            btnNutritionalSupplements.TabIndex = 36;
            btnNutritionalSupplements.Text = "Besin Takviyeleri";
            btnNutritionalSupplements.UseVisualStyleBackColor = false;
            // 
            // btnFruitVegatable
            // 
            btnFruitVegatable.BackColor = SystemColors.Control;
            btnFruitVegatable.BackgroundImage = (Image)resources.GetObject("btnFruitVegatable.BackgroundImage");
            btnFruitVegatable.BackgroundImageLayout = ImageLayout.Stretch;
            btnFruitVegatable.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFruitVegatable.ForeColor = Color.White;
            btnFruitVegatable.Location = new Point(928, 132);
            btnFruitVegatable.Name = "btnFruitVegatable";
            btnFruitVegatable.Size = new Size(169, 58);
            btnFruitVegatable.TabIndex = 35;
            btnFruitVegatable.Text = "Meyve Sebze";
            btnFruitVegatable.UseVisualStyleBackColor = false;
            // 
            // btnDelicatessen
            // 
            btnDelicatessen.BackColor = SystemColors.Control;
            btnDelicatessen.BackgroundImage = (Image)resources.GetObject("btnDelicatessen.BackgroundImage");
            btnDelicatessen.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelicatessen.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelicatessen.ForeColor = Color.White;
            btnDelicatessen.Location = new Point(706, 132);
            btnDelicatessen.Name = "btnDelicatessen";
            btnDelicatessen.Size = new Size(169, 58);
            btnDelicatessen.TabIndex = 34;
            btnDelicatessen.Text = "Et,Tavuk,Balık";
            btnDelicatessen.UseVisualStyleBackColor = false;
            // 
            // btnforBreakfast
            // 
            btnforBreakfast.BackColor = SystemColors.Control;
            btnforBreakfast.BackgroundImage = (Image)resources.GetObject("btnforBreakfast.BackgroundImage");
            btnforBreakfast.BackgroundImageLayout = ImageLayout.Stretch;
            btnforBreakfast.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnforBreakfast.ForeColor = Color.White;
            btnforBreakfast.Location = new Point(496, 132);
            btnforBreakfast.Name = "btnforBreakfast";
            btnforBreakfast.Size = new Size(169, 58);
            btnforBreakfast.TabIndex = 33;
            btnforBreakfast.Text = "Kahvaltılık";
            btnforBreakfast.UseVisualStyleBackColor = false;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = SystemColors.Control;
            btnSnacks.BackgroundImage = (Image)resources.GetObject("btnSnacks.BackgroundImage");
            btnSnacks.BackgroundImageLayout = ImageLayout.Stretch;
            btnSnacks.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnacks.ForeColor = Color.White;
            btnSnacks.Location = new Point(289, 132);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(169, 58);
            btnSnacks.TabIndex = 32;
            btnSnacks.Text = "Atıştırmalıklar";
            btnSnacks.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Control;
            btnAll.BackgroundImage = (Image)resources.GetObject("btnAll.BackgroundImage");
            btnAll.BackgroundImageLayout = ImageLayout.Stretch;
            btnAll.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(79, 132);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(169, 58);
            btnAll.TabIndex = 31;
            btnAll.Text = "Tümü";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // frmDinner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(btnLogOut);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblDinner);
            Controls.Add(lblPortions);
            Controls.Add(numericUpDownPortions);
            Controls.Add(dataGridViewDinner);
            Controls.Add(dataGridViewSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDrinks);
            Controls.Add(btnBakeryProducts);
            Controls.Add(btnNutriens);
            Controls.Add(btnFood);
            Controls.Add(btnNutritionalSupplements);
            Controls.Add(btnFruitVegatable);
            Controls.Add(btnDelicatessen);
            Controls.Add(btnforBreakfast);
            Controls.Add(btnSnacks);
            Controls.Add(btnAll);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDinner";
            Text = "frmDinner";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnBack;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblDinner;
        private Label lblPortions;
        private NumericUpDown numericUpDownPortions;
        private DataGridView dataGridViewDinner;
        private DataGridView dataGridViewSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnDrinks;
        private Button btnBakeryProducts;
        private Button btnNutriens;
        private Button btnFood;
        private Button btnNutritionalSupplements;
        private Button btnFruitVegatable;
        private Button btnDelicatessen;
        private Button btnforBreakfast;
        private Button btnSnacks;
        private Button btnAll;
    }
}