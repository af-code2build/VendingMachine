using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Core.Entities.Classes;

namespace VendingMachine.UI.SubWindows
{
    public partial class AdminControlBoard : Form
    {
        private int selectedProductId;
        private int selectedCoinId;
        public VendingMachineManager VendingMachineHelper { get; set; }

        public AdminControlBoard(VendingMachineManager vendingMachineHelper)
        {
            this.VendingMachineHelper = vendingMachineHelper;
            InitializeComponent();

        }

        private void AdminControlBoard_Load(object sender, EventArgs e)
        {
            ShowProductsList();
            ShowCoinsList();
        }

        private void ShowProductsList()
        {
            // Populate the View List with all the products saved in the database
            var products = VendingMachineHelper.ProductsList;
            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem item = new ListViewItem(products[i].Id.ToString());
                item.SubItems.Add(products[i].Name);
                item.SubItems.Add(products[i].Quantity.ToString());
                item.SubItems.Add(products[i].Price.ToString("0.00"));
                ProductControlPanel.Items.Add(item);
            }
        }

        private void ShowCoinsList()
        {

            // Populate the View List with all the coins saved in the database
            var coins = VendingMachineHelper.CoinReserves;
            for (int i = 0; i < coins.Count; i++)
            {
                ListViewItem item = new ListViewItem(coins[i].Id.ToString());
                item.SubItems.Add(coins[i].Name);
                item.SubItems.Add(coins[i].Value.ToString("0.00"));
                item.SubItems.Add(coins[i].Quantity.ToString());
                CoinControlPanel.Items.Add(item);
            }
        }

        private void SetProduct_Paint(object sender, PaintEventArgs e)
        {
            SetProduct.FlatAppearance.BorderColor = Color.Black;
        }

        private void SetCoin_Paint(object sender, PaintEventArgs e)
        {
            UpdateCoin.FlatAppearance.BorderColor = Color.Black;
        }

        private void ProductControlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var productId = Convert.ToInt32(ProductControlPanel.SelectedItems[0].SubItems[0].Text);

            var product = VendingMachineHelper.ProductsList[productId - 1];

            selectedProductId = product.Id;
            ProductNameTextbox.Text = product.Name;
            ProductPriceTextbox.Text = product.Price.ToString("0.00");
            ProductQuantityTextbox.Text = product.Quantity.ToString();
            ProductImageTextbox.Text = product.Picture;
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            var product = VendingMachineHelper.ProductsList.FirstOrDefault(x => x.Id == selectedProductId);

            if (product == null || VerifyIfProductInfoIsMissing() || !VerifyProductTextBoxContent(out int quantity, out double price))
            {
                return;
            }

            product.Id = selectedProductId;
            product.Name = ProductNameTextbox.Text;
            product.Price = price;
            product.Picture = ProductImageTextbox.Text;
            product.Quantity = quantity;

            VendingMachineHelper.UpdateProduct(product);

            ProductControlPanel.Items.Clear();
            ShowProductsList();
            ProductControlPanel.Refresh();
            ClearProductTextBoxes();
        }

        private void SetProduct_Click(object sender, EventArgs e)
        {
            if (VerifyIfProductInfoIsMissing() || !VerifyProductTextBoxContent(out int quantity, out double value))
            {
                return;
            }

            var product = new Product()
            {
                Name = ProductNameTextbox.Text,
                Quantity = quantity,
                Price = value,
                Picture = ProductImageTextbox.Text,
            };

            VendingMachineHelper.CreatNewProduct(product);

            ProductControlPanel.Items.Clear();
            ShowProductsList();
            ProductControlPanel.Refresh();
            ClearProductTextBoxes();
        }

        private void ClearProductTextBoxes()
        {
            ProductNameTextbox.Text = String.Empty;
            ProductPriceTextbox.Text = String.Empty;
            ProductQuantityTextbox.Text = String.Empty;
            ProductImageTextbox.Text = String.Empty;
        }


        private bool VerifyIfProductInfoIsMissing()
        {
            return ProductNameTextbox.Text == String.Empty 
                || ProductPriceTextbox.Text == String.Empty 
                || ProductQuantityTextbox.Text == String.Empty
                || ProductImageTextbox.Text == String.Empty;
        }

        private bool VerifyProductTextBoxContent(out int quantity, out double value)
        {
            var valueNotValid = !Double.TryParse(ProductPriceTextbox.Text, out value);
            var quantityNotValid = !Int32.TryParse(ProductQuantityTextbox.Text, out quantity);

            if (valueNotValid && quantityNotValid)
            {
                ProductQuantityTextbox.BackColor = Color.Red;
                ProductQuantityTextbox.Text = String.Empty;
                ProductPriceTextbox.BackColor = Color.Red;
                ProductPriceTextbox.Text = String.Empty;
                value = 0;
                return false;
            }

            if (quantityNotValid)
            {
                ProductQuantityTextbox.BackColor = Color.Red;
                ProductQuantityTextbox.Text = String.Empty;
                value = 0;
                return false;
            }

            if (valueNotValid)
            {
                ProductPriceTextbox.BackColor = Color.Red;
                ProductPriceTextbox.Text = String.Empty;
                return false;
            }

            return true;
        }

        private void ProductPriceTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductPriceTextbox.BackColor == Color.Red)
            {
                ProductPriceTextbox.BackColor = Color.White;
            }
        }

        private void ProductQuantityTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductQuantityTextbox.BackColor == Color.Red)
            {
                ProductQuantityTextbox.BackColor = Color.White;
            }
        }

        private void CoinControlPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var coinId = Convert.ToInt32(CoinControlPanel.SelectedItems[0].SubItems[0].Text);

            var coin = VendingMachineHelper.CoinReserves[coinId - 1];

            selectedCoinId = coin.Id;
            CoinQuantityTextbox.Text = coin.Quantity.ToString();
        }

        private void UpdateCoin_Click(object sender, EventArgs e)
        {
            var coin = VendingMachineHelper.CoinReserves.FirstOrDefault(x => x.Id == selectedCoinId);

            if (coin == null || CoinQuantityTextbox.Text == String.Empty)
            {
                return;
            }

            if (!Int32.TryParse(CoinQuantityTextbox.Text, out int quantity))
            {
                CoinQuantityTextbox.BackColor = Color.Red;
                CoinQuantityTextbox.Text = String.Empty;
                return;
            }

            coin.Quantity = quantity;

            VendingMachineHelper.UpdateOneCoin(coin);

            CoinControlPanel.Items.Clear();
            ShowCoinsList();
            CoinControlPanel.Refresh();
            CoinQuantityTextbox.Text = String.Empty;
        }

        private void CoinQuantityTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CoinQuantityTextbox.BackColor == Color.Red)
            {
                CoinQuantityTextbox.BackColor = Color.White;
            }
        }
    }
}
