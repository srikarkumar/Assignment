using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day2_Order
{
    class Order
    {
        private int OrderId;
        private string CustomerName;
        private string ItemName;
        private int ItemPrice;
        private int ItemQuantity;

        public Order(int OrderId,string CustomerName,string ItemName,int ItemPrice,int ItemQuantity)
        {
            this.OrderId = OrderId;
            this.CustomerName = CustomerName;
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.ItemQuantity = ItemQuantity;
        }

        public int GetOrderAmount()
        {
            int Amount = ItemPrice * ItemQuantity;
            return Amount;
        }
        public string GetDetails()
        {
            return OrderId +"  "+ CustomerName+" " +ItemName+" "+ ItemPrice;
        }
    }
}
