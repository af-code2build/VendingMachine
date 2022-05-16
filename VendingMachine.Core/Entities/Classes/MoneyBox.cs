using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Core.Entities.Classes
{
    public class MoneyBox
    {
        private double currectPrice;
        private double currectAmount;
        private double accumulatedChange;
        private double changeToCollectFromReserves;
        public bool isReadyToBuy;

        public Dictionary<string, Coin> CoinReserves { get; set; }
        public DisplayBox TransationInfo { get; set; }

        public MoneyBox(double price, DisplayBox transation)
        {
            this.currectPrice = price;
            this.currectAmount = 0;
            this.isReadyToBuy = false;
            this.accumulatedChange = this.currectAmount - this.currectPrice;
            this.changeToCollectFromReserves = 0;
            this.CoinReserves = DatabaseConnector.LoadCoinReserves().ToDictionary(x => x.Name);
            this.TransationInfo = transation;
            this.TransationInfo.MissingValue = price;          
        }

        public DisplayBox CollectMoney(string coin)
        {
            var coinType = CoinReserves[coin];

            coinType.Quantity++;

            currectAmount += coinType.Value;

            var missingValue = TransationInfo.MissingValue - coinType.Value;
            TransationInfo.MissingValue = missingValue < 0 ? 0 : missingValue;

            TransationInfo.TotalGivenCoins = currectAmount;

            UpdateTransationChange();

            return TransationInfo;
        }

        private void UpdateTransationChange()
        {
            accumulatedChange = currectAmount - currectPrice;

            if (accumulatedChange < 0)
            {
                return;
            }

            if (accumulatedChange == 0)
            {
                isReadyToBuy = true;
                TransationInfo.Message = "READY TO BUY!";
                return;
            }

            if (accumulatedChange > 0)
            {
                TransationInfo.TotalChange = accumulatedChange;

                var collect = accumulatedChange - changeToCollectFromReserves;

                TransationInfo.Message = CollectChangeFromReserves(collect);

                changeToCollectFromReserves = accumulatedChange;
    
            }
        }

        private string CollectChangeFromReserves(double collect)
        {
            var coinList = CoinReserves.OrderBy(x => x.Value.Value).Select(kvp => kvp.Value).ToList();

            while (collect >= 0.01)
            {
                var pos = coinList.FindIndex(x => x.Value >= collect);

                if (pos < 0)
                {
                    isReadyToBuy = false;
                    return "NOT ENOUGH CHANGE IN THE MACHINE! PLEASE, CONTACT ADMIN.";
                }

                if (!(Math.Abs(coinList[pos].Value - collect) < 0.01))
                {
                    pos--;
                }

                var coin = coinList[pos];

                if (coin.Quantity <= 0)
                {
                    isReadyToBuy = false;
                    return "NOT ENOUGH CHANGE IN THE MACHINE! PLEASE, CONTACT ADMIN.";
                }

                coin.Quantity--;

                collect -= coin.Value;
            }

            isReadyToBuy = true;

            return "READY TO BUY!";
        }

        public bool CloseTransation(out string totalChange)
        {
            try
            {
                isReadyToBuy = false;

                DatabaseConnector.UpdateCoinReserves(CoinReserves);

                totalChange = accumulatedChange.ToString("0.00");

                return true;
            }
            catch (Exception)
            {
                totalChange = string.Empty;
                return false;
            }
        }

    }
}
