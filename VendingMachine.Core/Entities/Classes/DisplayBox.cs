using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Core.Entities.Classes
{
    public class DisplayBox
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public double TotalGivenCoins { get; set; }
        public double TotalChange { get; set; }
        public double MissingValue { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {

            var display = $"PRODUCT: {ProductName}@PRICE: {ProductPrice}@@GIVEN AMOUNT: {TotalGivenCoins:0.00}@MISSING VALUE: {MissingValue:0.00}@TOTAL CHANGE: {TotalChange:0.00}@@{Message}";

            return display.Replace("@", System.Environment.NewLine);

        }

    }
}
