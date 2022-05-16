namespace VendingMachine.UI.SubWindows
{
    partial class AdminControlBoard
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
            this.ProductControlPanel = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.CoinControlPanel = new System.Windows.Forms.ListView();
            this.Number = new System.Windows.Forms.ColumnHeader();
            this.Designation = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.CoinQuantity = new System.Windows.Forms.ColumnHeader();
            this.CoinQuantityTextbox = new System.Windows.Forms.TextBox();
            this.CoinQuantityLabel = new System.Windows.Forms.Label();
            this.CurrencyManagementLabel = new System.Windows.Forms.Label();
            this.ProductManagementLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductQuantityLabel = new System.Windows.Forms.Label();
            this.ProductQuantityTextbox = new System.Windows.Forms.TextBox();
            this.SetProduct = new System.Windows.Forms.Button();
            this.ProductImageLabel = new System.Windows.Forms.Label();
            this.ProductImageTextbox = new System.Windows.Forms.TextBox();
            this.UpdateCoin = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductControlPanel
            // 
            this.ProductControlPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProductName,
            this.Quantity,
            this.Price});
            this.ProductControlPanel.FullRowSelect = true;
            this.ProductControlPanel.HideSelection = false;
            this.ProductControlPanel.Location = new System.Drawing.Point(22, 199);
            this.ProductControlPanel.Name = "ProductControlPanel";
            this.ProductControlPanel.Size = new System.Drawing.Size(511, 168);
            this.ProductControlPanel.TabIndex = 0;
            this.ProductControlPanel.UseCompatibleStateImageBehavior = false;
            this.ProductControlPanel.View = System.Windows.Forms.View.Details;
            this.ProductControlPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductControlPanel_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ProductName
            // 
            this.ProductName.Text = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 200;
            // 
            // CoinControlPanel
            // 
            this.CoinControlPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Designation,
            this.Value,
            this.CoinQuantity});
            this.CoinControlPanel.FullRowSelect = true;
            this.CoinControlPanel.HideSelection = false;
            this.CoinControlPanel.Location = new System.Drawing.Point(22, 514);
            this.CoinControlPanel.Name = "CoinControlPanel";
            this.CoinControlPanel.Size = new System.Drawing.Size(511, 157);
            this.CoinControlPanel.TabIndex = 1;
            this.CoinControlPanel.UseCompatibleStateImageBehavior = false;
            this.CoinControlPanel.View = System.Windows.Forms.View.Details;
            this.CoinControlPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoinControlPanel_MouseClick);
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 100;
            // 
            // Designation
            // 
            this.Designation.Text = "Designation";
            this.Designation.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 100;
            // 
            // CoinQuantity
            // 
            this.CoinQuantity.Text = "Quantity";
            this.CoinQuantity.Width = 300;
            // 
            // CoinQuantityTextbox
            // 
            this.CoinQuantityTextbox.Location = new System.Drawing.Point(22, 466);
            this.CoinQuantityTextbox.Name = "CoinQuantityTextbox";
            this.CoinQuantityTextbox.Size = new System.Drawing.Size(156, 27);
            this.CoinQuantityTextbox.TabIndex = 2;
            this.CoinQuantityTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoinQuantityTextbox_MouseClick);
            // 
            // CoinQuantityLabel
            // 
            this.CoinQuantityLabel.AutoSize = true;
            this.CoinQuantityLabel.Location = new System.Drawing.Point(22, 443);
            this.CoinQuantityLabel.Name = "CoinQuantityLabel";
            this.CoinQuantityLabel.Size = new System.Drawing.Size(65, 20);
            this.CoinQuantityLabel.TabIndex = 4;
            this.CoinQuantityLabel.Text = "Quantity";
            // 
            // CurrencyManagementLabel
            // 
            this.CurrencyManagementLabel.AutoSize = true;
            this.CurrencyManagementLabel.Font = new System.Drawing.Font("SkylineSans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrencyManagementLabel.Location = new System.Drawing.Point(22, 401);
            this.CurrencyManagementLabel.Name = "CurrencyManagementLabel";
            this.CurrencyManagementLabel.Size = new System.Drawing.Size(222, 23);
            this.CurrencyManagementLabel.TabIndex = 6;
            this.CurrencyManagementLabel.Text = "Currency Management";
            // 
            // ProductManagementLabel
            // 
            this.ProductManagementLabel.AutoSize = true;
            this.ProductManagementLabel.Font = new System.Drawing.Font("SkylineSans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductManagementLabel.Location = new System.Drawing.Point(22, 26);
            this.ProductManagementLabel.Name = "ProductManagementLabel";
            this.ProductManagementLabel.Size = new System.Drawing.Size(212, 23);
            this.ProductManagementLabel.TabIndex = 11;
            this.ProductManagementLabel.Text = "Product Management";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(208, 69);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(41, 20);
            this.ProductPriceLabel.TabIndex = 10;
            this.ProductPriceLabel.Text = "Price";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(22, 69);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(49, 20);
            this.ProductNameLabel.TabIndex = 9;
            this.ProductNameLabel.Text = "Name";
            // 
            // ProductPriceTextbox
            // 
            this.ProductPriceTextbox.Location = new System.Drawing.Point(208, 92);
            this.ProductPriceTextbox.Name = "ProductPriceTextbox";
            this.ProductPriceTextbox.Size = new System.Drawing.Size(156, 27);
            this.ProductPriceTextbox.TabIndex = 8;
            this.ProductPriceTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductPriceTextbox_MouseClick);
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(22, 92);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(156, 27);
            this.ProductNameTextbox.TabIndex = 7;
            // 
            // ProductQuantityLabel
            // 
            this.ProductQuantityLabel.AutoSize = true;
            this.ProductQuantityLabel.Location = new System.Drawing.Point(22, 127);
            this.ProductQuantityLabel.Name = "ProductQuantityLabel";
            this.ProductQuantityLabel.Size = new System.Drawing.Size(65, 20);
            this.ProductQuantityLabel.TabIndex = 13;
            this.ProductQuantityLabel.Text = "Quantity";
            // 
            // ProductQuantityTextbox
            // 
            this.ProductQuantityTextbox.Location = new System.Drawing.Point(22, 150);
            this.ProductQuantityTextbox.Name = "ProductQuantityTextbox";
            this.ProductQuantityTextbox.Size = new System.Drawing.Size(156, 27);
            this.ProductQuantityTextbox.TabIndex = 12;
            this.ProductQuantityTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductQuantityTextbox_MouseClick);
            // 
            // SetProduct
            // 
            this.SetProduct.BackColor = System.Drawing.Color.Gold;
            this.SetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetProduct.Location = new System.Drawing.Point(429, 142);
            this.SetProduct.Name = "SetProduct";
            this.SetProduct.Size = new System.Drawing.Size(104, 35);
            this.SetProduct.TabIndex = 14;
            this.SetProduct.Text = "Create";
            this.SetProduct.UseVisualStyleBackColor = false;
            this.SetProduct.Click += new System.EventHandler(this.SetProduct_Click);
            this.SetProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.SetProduct_Paint);
            // 
            // ProductImageLabel
            // 
            this.ProductImageLabel.AutoSize = true;
            this.ProductImageLabel.Location = new System.Drawing.Point(208, 127);
            this.ProductImageLabel.Name = "ProductImageLabel";
            this.ProductImageLabel.Size = new System.Drawing.Size(51, 20);
            this.ProductImageLabel.TabIndex = 15;
            this.ProductImageLabel.Text = "Image";
            // 
            // ProductImageTextbox
            // 
            this.ProductImageTextbox.Location = new System.Drawing.Point(208, 150);
            this.ProductImageTextbox.Name = "ProductImageTextbox";
            this.ProductImageTextbox.Size = new System.Drawing.Size(156, 27);
            this.ProductImageTextbox.TabIndex = 16;
            // 
            // UpdateCoin
            // 
            this.UpdateCoin.BackColor = System.Drawing.Color.Gold;
            this.UpdateCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateCoin.Location = new System.Drawing.Point(429, 459);
            this.UpdateCoin.Name = "UpdateCoin";
            this.UpdateCoin.Size = new System.Drawing.Size(104, 34);
            this.UpdateCoin.TabIndex = 17;
            this.UpdateCoin.Text = "Update";
            this.UpdateCoin.UseVisualStyleBackColor = false;
            this.UpdateCoin.Click += new System.EventHandler(this.UpdateCoin_Click);
            this.UpdateCoin.Paint += new System.Windows.Forms.PaintEventHandler(this.SetCoin_Paint);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.BackColor = System.Drawing.Color.Gold;
            this.UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateProduct.Location = new System.Drawing.Point(429, 92);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(104, 35);
            this.UpdateProduct.TabIndex = 18;
            this.UpdateProduct.Text = "Update";
            this.UpdateProduct.UseVisualStyleBackColor = false;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // AdminControlBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(565, 698);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.UpdateCoin);
            this.Controls.Add(this.ProductImageTextbox);
            this.Controls.Add(this.ProductImageLabel);
            this.Controls.Add(this.SetProduct);
            this.Controls.Add(this.ProductQuantityLabel);
            this.Controls.Add(this.ProductQuantityTextbox);
            this.Controls.Add(this.ProductManagementLabel);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductPriceTextbox);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.CurrencyManagementLabel);
            this.Controls.Add(this.CoinQuantityLabel);
            this.Controls.Add(this.CoinQuantityTextbox);
            this.Controls.Add(this.CoinControlPanel);
            this.Controls.Add(this.ProductControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminControlBoard";
            this.Text = "Admin Control Board";
            this.Load += new System.EventHandler(this.AdminControlBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProductControlPanel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView CoinControlPanel;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Designation;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader CoinQuantity;
        private System.Windows.Forms.TextBox CoinQuantityTextbox;
        private System.Windows.Forms.Label CoinQuantityLabel;
        private System.Windows.Forms.Label CurrencyManagementLabel;
        private System.Windows.Forms.Label ProductManagementLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductPriceTextbox;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.Label ProductQuantityLabel;
        private System.Windows.Forms.TextBox ProductQuantityTextbox;
        private System.Windows.Forms.Button SetProduct;
        private System.Windows.Forms.Label ProductImageLabel;
        private System.Windows.Forms.TextBox ProductImageTextbox;
        private System.Windows.Forms.Button UpdateCoin;
        private System.Windows.Forms.Button UpdateProduct;
    }
}