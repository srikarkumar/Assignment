using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_day2_AssignOrder
{
    class Order
    {
        private int OrderId;
        private string CustomerName;
        private string ItemName;
        private int ItemPrice;
        private int ItemQuantity;
        public static int count = 100;

        public int POrderId
        {
            get
            {
                return this.OrderId;
            }
        }
        public string PCustomerName
        {
            get
            {
                return this.CustomerName;
            }
        }
        public string PItemName
        {
            get
            {
                return this.ItemName;
            }
        }
        public int PItemPrice
            {
            get
            {
                return this.ItemPrice;
            }
            }
        public int PItemQuantity
        {
            get
            {
                return this.ItemQuantity;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                     this.ItemQuantity = value;
                }
                else
                {
                     this.ItemQuantity = 1;
                }
            }
        }


        public Order(string CustomerName, string ItemName, int ItemPrice, int ItemQuantity)
        {
            Order.count++;
            this.OrderId = Order.count;
            this.CustomerName = CustomerName;
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.ItemQuantity = ItemQuantity;
        }

        public int GetOrderAmount()
        {
            int Amount = PItemPrice * PItemQuantity;
            return Amount;
        }
        public string GetDetails()
        {
            return PCustomerName + " " + PItemName + " " + PItemPrice + " " + POrderId;
        }
    }
}
