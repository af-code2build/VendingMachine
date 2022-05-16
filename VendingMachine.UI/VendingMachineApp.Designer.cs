namespace VendingMachine.UI
{
    partial class VendingMachineApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OnePence = new System.Windows.Forms.PictureBox();
            this.TwoPence = new System.Windows.Forms.PictureBox();
            this.FivePence = new System.Windows.Forms.PictureBox();
            this.TwentyPence = new System.Windows.Forms.PictureBox();
            this.FiftyPence = new System.Windows.Forms.PictureBox();
            this.OnePound = new System.Windows.Forms.PictureBox();
            this.TenPence = new System.Windows.Forms.PictureBox();
            this.TwoPounds = new System.Windows.Forms.PictureBox();
            this.MoneyPanel = new System.Windows.Forms.TextBox();
            this.ProductsList = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.CoinSlot = new System.Windows.Forms.PictureBox();
            this.OutputProduct = new System.Windows.Forms.PictureBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.UnlockButton = new System.Windows.Forms.PictureBox();
            this.AdminKey = new System.Windows.Forms.TextBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.RefreshProductList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OnePence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FivePence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyPence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyPence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDING MACHINE";
            // 
            // OnePence
            // 
            this.OnePence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_1p;
            this.OnePence.Location = new System.Drawing.Point(397, 308);
            this.OnePence.Name = "OnePence";
            this.OnePence.Size = new System.Drawing.Size(53, 49);
            this.OnePence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OnePence.TabIndex = 2;
            this.OnePence.TabStop = false;
            this.OnePence.Click += new System.EventHandler(this.OnePence_Click);
            // 
            // TwoPence
            // 
            this.TwoPence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_20p;
            this.TwoPence.Location = new System.Drawing.Point(397, 355);
            this.TwoPence.Name = "TwoPence";
            this.TwoPence.Size = new System.Drawing.Size(53, 52);
            this.TwoPence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TwoPence.TabIndex = 3;
            this.TwoPence.TabStop = false;
            this.TwoPence.Click += new System.EventHandler(this.TwoPence_Click);
            // 
            // FivePence
            // 
            this.FivePence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_5p;
            this.FivePence.Location = new System.Drawing.Point(502, 308);
            this.FivePence.Name = "FivePence";
            this.FivePence.Size = new System.Drawing.Size(52, 49);
            this.FivePence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FivePence.TabIndex = 4;
            this.FivePence.TabStop = false;
            this.FivePence.Click += new System.EventHandler(this.FivePence_Click);
            // 
            // TwentyPence
            // 
            this.TwentyPence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_2p;
            this.TwentyPence.Location = new System.Drawing.Point(450, 308);
            this.TwentyPence.Name = "TwentyPence";
            this.TwentyPence.Size = new System.Drawing.Size(52, 49);
            this.TwentyPence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TwentyPence.TabIndex = 5;
            this.TwentyPence.TabStop = false;
            this.TwentyPence.Click += new System.EventHandler(this.TwentyPence_Click);
            // 
            // FiftyPence
            // 
            this.FiftyPence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_50p;
            this.FiftyPence.Location = new System.Drawing.Point(450, 355);
            this.FiftyPence.Name = "FiftyPence";
            this.FiftyPence.Size = new System.Drawing.Size(52, 52);
            this.FiftyPence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FiftyPence.TabIndex = 6;
            this.FiftyPence.TabStop = false;
            this.FiftyPence.Click += new System.EventHandler(this.FiftyPence_Click);
            // 
            // OnePound
            // 
            this.OnePound.Image = global::VendingMachine.UI.Resources.Resource1.Coin_1pound;
            this.OnePound.Location = new System.Drawing.Point(502, 355);
            this.OnePound.Name = "OnePound";
            this.OnePound.Size = new System.Drawing.Size(52, 52);
            this.OnePound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OnePound.TabIndex = 7;
            this.OnePound.TabStop = false;
            this.OnePound.Click += new System.EventHandler(this.OnePound_Click);
            // 
            // TenPence
            // 
            this.TenPence.Image = global::VendingMachine.UI.Resources.Resource1.Coin_10p;
            this.TenPence.Location = new System.Drawing.Point(555, 308);
            this.TenPence.Name = "TenPence";
            this.TenPence.Size = new System.Drawing.Size(54, 49);
            this.TenPence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TenPence.TabIndex = 8;
            this.TenPence.TabStop = false;
            this.TenPence.Click += new System.EventHandler(this.TenPence_Click);
            // 
            // TwoPounds
            // 
            this.TwoPounds.Image = global::VendingMachine.UI.Resources.Resource1.Coin_2pound;
            this.TwoPounds.Location = new System.Drawing.Point(555, 355);
            this.TwoPounds.Name = "TwoPounds";
            this.TwoPounds.Size = new System.Drawing.Size(54, 52);
            this.TwoPounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TwoPounds.TabIndex = 9;
            this.TwoPounds.TabStop = false;
            this.TwoPounds.Click += new System.EventHandler(this.TwoPounds_Click);
            // 
            // MoneyPanel
            // 
            this.MoneyPanel.Location = new System.Drawing.Point(398, 85);
            this.MoneyPanel.Multiline = true;
            this.MoneyPanel.Name = "MoneyPanel";
            this.MoneyPanel.Size = new System.Drawing.Size(211, 204);
            this.MoneyPanel.TabIndex = 10;
            // 
            // ProductsList
            // 
            this.ProductsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Price});
            this.ProductsList.FullRowSelect = true;
            this.ProductsList.HideSelection = false;
            this.ProductsList.Location = new System.Drawing.Point(30, 85);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(340, 497);
            this.ProductsList.TabIndex = 12;
            this.ProductsList.UseCompatibleStateImageBehavior = false;
            this.ProductsList.View = System.Windows.Forms.View.Details;
            this.ProductsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductsList_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 300;
            // 
            // CoinSlot
            // 
            this.CoinSlot.BackColor = System.Drawing.Color.Tan;
            this.CoinSlot.Location = new System.Drawing.Point(398, 542);
            this.CoinSlot.Name = "CoinSlot";
            this.CoinSlot.Size = new System.Drawing.Size(79, 77);
            this.CoinSlot.TabIndex = 14;
            this.CoinSlot.TabStop = false;
            this.CoinSlot.Paint += new System.Windows.Forms.PaintEventHandler(this.CoinSlot_Paint);
            // 
            // OutputProduct
            // 
            this.OutputProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputProduct.BackColor = System.Drawing.Color.Tan;
            this.OutputProduct.Location = new System.Drawing.Point(486, 476);
            this.OutputProduct.Name = "OutputProduct";
            this.OutputProduct.Size = new System.Drawing.Size(123, 143);
            this.OutputProduct.TabIndex = 15;
            this.OutputProduct.TabStop = false;
            this.OutputProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputProduct_Paint);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.Gold;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("SkylineSans Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyButton.Location = new System.Drawing.Point(459, 416);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(69, 30);
            this.BuyButton.TabIndex = 16;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Gold;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("SkylineSans Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.Location = new System.Drawing.Point(534, 416);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 30);
            this.RestartButton.TabIndex = 17;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // UnlockButton
            // 
            this.UnlockButton.Image = global::VendingMachine.UI.Resources.Resource1.Lock;
            this.UnlockButton.Location = new System.Drawing.Point(568, 18);
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.Size = new System.Drawing.Size(40, 41);
            this.UnlockButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UnlockButton.TabIndex = 18;
            this.UnlockButton.TabStop = false;
            this.UnlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // AdminKey
            // 
            this.AdminKey.Location = new System.Drawing.Point(459, 26);
            this.AdminKey.Name = "AdminKey";
            this.AdminKey.PasswordChar = '*';
            this.AdminKey.Size = new System.Drawing.Size(106, 27);
            this.AdminKey.TabIndex = 19;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("SkylineSans Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminLabel.Location = new System.Drawing.Point(395, 29);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(61, 20);
            this.AdminLabel.TabIndex = 20;
            this.AdminLabel.Text = "Admin";
            // 
            // RefreshProductList
            // 
            this.RefreshProductList.BackColor = System.Drawing.Color.SandyBrown;
            this.RefreshProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshProductList.Font = new System.Drawing.Font("SkylineSans Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshProductList.Location = new System.Drawing.Point(30, 588);
            this.RefreshProductList.Name = "RefreshProductList";
            this.RefreshProductList.Size = new System.Drawing.Size(340, 31);
            this.RefreshProductList.TabIndex = 21;
            this.RefreshProductList.Text = "Refresh";
            this.RefreshProductList.UseVisualStyleBackColor = false;
            this.RefreshProductList.Click += new System.EventHandler(this.RefreshProductList_Click);
            // 
            // VendingMachineApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(633, 654);
            this.Controls.Add(this.RefreshProductList);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.AdminKey);
            this.Controls.Add(this.UnlockButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.OutputProduct);
            this.Controls.Add(this.CoinSlot);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.MoneyPanel);
            this.Controls.Add(this.TwoPounds);
            this.Controls.Add(this.TenPence);
            this.Controls.Add(this.OnePound);
            this.Controls.Add(this.FiftyPence);
            this.Controls.Add(this.TwentyPence);
            this.Controls.Add(this.FivePence);
            this.Controls.Add(this.TwoPence);
            this.Controls.Add(this.OnePence);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VendingMachineApp";
            this.Text = "Vending Machine App";
            this.Load += new System.EventHandler(this.VendingMachineApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OnePence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FivePence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyPence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyPence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoPounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox OnePence;
        private System.Windows.Forms.PictureBox TwoPence;
        private System.Windows.Forms.PictureBox FivePence;
        private System.Windows.Forms.PictureBox TwentyPence;
        private System.Windows.Forms.PictureBox FiftyPence;
        private System.Windows.Forms.PictureBox OnePound;
        private System.Windows.Forms.PictureBox TenPence;
        private System.Windows.Forms.PictureBox TwoPounds;
        private System.Windows.Forms.TextBox MoneyPanel;
        private System.Windows.Forms.ListView ProductsList;
        private System.Windows.Forms.PictureBox CoinSlot;
        private System.Windows.Forms.PictureBox OutputProduct;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.PictureBox UnlockButton;
        private System.Windows.Forms.TextBox AdminKey;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button RefreshProductList;
    }
}
