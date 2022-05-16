using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Core.Entities.Classes
{
    public class VendingMachineManager
    {
        public List<Product> ProductsList { get => DatabaseConnector.LoadProductList(); }
        public List<Coin> CoinReserves { get => DatabaseConnector.LoadCoinReserves().ToList(); }

        public MoneyBox MoneyManager { get; set; }
        public bool TransationIsRunning { get; set; }

        public VendingMachineManager()
        {
            TransationIsRunning = false;
        }

        public string InitiatingTransaction(int productId)
        {
            var product = ProductsList[productId - 1];

            if (product.Quantity < 1)
            {
                return "THIS PRODUCT IS NO LONGER AVAILABLE";
            }

            var display = new DisplayBox()
            {
                ProductName = product.Name,
                ProductPrice = product.Price.ToString("0.00")
            };

            MoneyManager = new MoneyBox(product.Price, display);

            TransationIsRunning = true;

            return display.ToString();
        }

        public string InsertCoin(string coin)
        {
            return MoneyManager.CollectMoney(coin).ToString();
        }

        public string BuyProduct(int productId, out string totalChange)
        {
            if (!MoneyManager.isReadyToBuy)
            {
                totalChange = "0";
                MoneyManager.TransationInfo.Message = "NOT ENOUGH MONEY TO BUY THE PRODUCT.";
                return MoneyManager.TransationInfo.ToString();
            }

            TransationIsRunning = false;

            if (MoneyManager.CloseTransation(out totalChange))
            {
                var product = ProductsList[productId - 1];
                product.Quantity--;

                DatabaseConnector.UpdateProductList(product);

                return "THANK YOU FOR YOUR PURCHASE!";
            }

            return "ERROR OF THE MACHINE!";
        }

        public bool UnlockAdminAccess(string key)
        {
            return DatabaseConnector.CheckAdminPassword(key);
        }

        public void UpdateProduct(Product product)
        {
            DatabaseConnector.UpdateProductList(product);
        }

        public void CreatNewProduct(Product product)
        {
            DatabaseConnector.AddNewProduct(product);
        }

        public void UpdateOneCoin(Coin coin)
        {
            DatabaseConnector.UpdateCoinQuantity(coin);
        }

    }
}
