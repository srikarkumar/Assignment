using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_day2_practice_order
{
    class Order
    {
        private int OrderId;
        private string CustomerName;
        private string ItemName;
        private double ItemPrice;
        private int ItemQuantity;
        public static int count = 1000;
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
        public double PItemPrice
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
                    this.ItemQuantity = 0;
                }
            }
        }


        public Order(string CustomerName,string ItemName,double ItemPrice,int ItemQuantity)
        {
            Order.count++;
            this.OrderId = Order.count;
            this.CustomerName = CustomerName;
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.ItemQuantity = ItemQuantity;
        }
        public double GetOrderAmount()
        {
            double amt = PItemPrice * PItemQuantity;
            return amt;
        }
        public string GetDetails()
        {
            return PCustomerName + " " + PItemName + " " + PItemPrice +" "+OrderId;
         }
    }

}
