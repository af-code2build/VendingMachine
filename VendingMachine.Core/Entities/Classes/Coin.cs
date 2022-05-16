using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Core.Entities.Classes
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
    }
}
