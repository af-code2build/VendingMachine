using System;
using System.Drawing;
using System.Windows.Forms;
using VendingMachine.Core.Entities.Classes;
using VendingMachine.UI.SubWindows;

namespace VendingMachine.UI
{
    public partial class VendingMachineApp : Form
    {

        public VendingMachineManager VendingMachineHelper { get; set; }

        public VendingMachineApp()
        {
            VendingMachineHelper = new VendingMachineManager();
            InitializeComponent();
        }

        private void VendingMachineApp_Load(object sender, EventArgs e)
        {
            ShowProductsList();
        }

        private void ShowProductsList()
        {
            // Populate the View List with all the products saved in the database
            var products = VendingMachineHelper.ProductsList;

            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem item = new ListViewItem(products[i].Id.ToString());
                item.SubItems.Add(products[i].Name);
                item.SubItems.Add(products[i].Price.ToString("0.00"));
                ProductsList.Items.Add(item);
            }
        }

        private void ProductsList_MouseClick(object sender, MouseEventArgs e)
        {
            var productId = Convert.ToInt32(ProductsList.SelectedItems[0].SubItems[0].Text);

            MoneyPanel.Text = VendingMachineHelper.InitiatingTransaction(productId);

            ClearCoinAndProductOutput();
        }

        private void InserCoinAction(string coinName)
        {
            if (VendingMachineHelper.TransationIsRunning)
            {
                MoneyPanel.Text = VendingMachineHelper.InsertCoin(coinName);
                return;
            }

            MoneyPanel.Text = "SELECT ONE PRODUCT";
        }

        private void OnePence_Click(object sender, EventArgs e)
        {
            InserCoinAction("1p");
        }


        private void TwentyPence_Click(object sender, EventArgs e)
        {
            InserCoinAction("2p");
        }

        private void FivePence_Click(object sender, EventArgs e)
        {
            InserCoinAction("5p");
        }

        private void TenPence_Click(object sender, EventArgs e)
        {
            InserCoinAction("10p");
        }

        private void TwoPence_Click(object sender, EventArgs e)
        {
            InserCoinAction("20p");
        }

        private void FiftyPence_Click(object sender, EventArgs e)
        {
            InserCoinAction("50p");
        }

        private void OnePound_Click(object sender, EventArgs e)
        {
            InserCoinAction("£1");
        }

        private void TwoPounds_Click(object sender, EventArgs e)
        {
            InserCoinAction("£2");
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (MoneyPanel.Text.Contains("THANK YOU"))
            {
                MoneyPanel.Text = "SELECT ONE PRODUCT";
                return;
            }

            var productId = 0;

            try
            {
                productId = Convert.ToInt32(ProductsList.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception)
            {
                MoneyPanel.Text = "SELECT ONE PRODUCT";
                return;
            }

            MoneyPanel.Text = VendingMachineHelper.BuyProduct(productId, out string totalChange);

            if (MoneyPanel.Text.Contains("THANK YOU"))
            {
                GiveTheChangeToTheUser(totalChange);
                GiveTheProductToTheUser(productId);
            }
        }

        private void GiveTheChangeToTheUser(string totalChange)
        {
            var image = new Bitmap(CoinSlot.Width, CoinSlot.Height);

            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);

            var graph = Graphics.FromImage(image);

            graph.DrawString(totalChange + "£", font, Brushes.Black, new Point(0, 7));

            CoinSlot.BackColor = Color.White;

            CoinSlot.BackgroundImage = Image.FromFile(@"..\..\..\Resources\Coins.png");

            CoinSlot.Image = image;

        }

        private void GiveTheProductToTheUser(int productId)
        {
            var imageName = VendingMachineHelper.ProductsList[productId - 1].Picture;

            OutputProduct.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + imageName);

            OutputProduct.BackgroundImageLayout = ImageLayout.Stretch;

            OutputProduct.BackColor = Color.White;
        }

        private void ClearCoinAndProductOutput()
        {
            CoinSlot.BackColor = Color.Tan;

            CoinSlot.BackgroundImage = null;

            CoinSlot.Image = null;

            OutputProduct.BackgroundImage = null;

            OutputProduct.BackColor = Color.Tan;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            VendingMachineHelper.TransationIsRunning = false;
            ClearCoinAndProductOutput();
            MoneyPanel.Text = String.Empty;
        }

        private void OutputProduct_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, OutputProduct.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void CoinSlot_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, CoinSlot.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            var adminKey = AdminKey.Text;

            AdminKey.Text = String.Empty;

            if (!VendingMachineHelper.UnlockAdminAccess(adminKey))
            {
                MessageBox.Show("Invalid Key!", "Admin Access");
                return;
            }

            AdminControlBoard subWindow = new AdminControlBoard(VendingMachineHelper);

            subWindow.Show();

        }

        private void RefreshProductList_Click(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();
            ShowProductsList();
            ProductsList.Refresh();
        }
    }
}
