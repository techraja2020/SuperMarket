using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace SuperMarket
{
    public class Billing
    {
        public double calculatePriceforselecteditem(List<Item> iit)
        {
            double billRate = 0;
            foreach (Item it in iit)
            {
                billRate += it.Price - (it.Price * it.discount);
            }
            return billRate;
        }
        public List<Item> loadAllItems()
        {
            List<Item> itm = new List<Item>();
            itm.Add(new Item() { ItemName = "Apple", Price = 45.50, discount = 0.06 });
            itm.Add(new Item() { ItemName = "Pen", Price = 23.90, discount = 0.20 });
            return itm;
        }
    }
}
