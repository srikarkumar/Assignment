using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_day2_AssignOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter customerName:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("enter Item name:");
            string ItemName = Console.ReadLine();
            Console.WriteLine("enter ItemPrice");
            int ItemPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ItemQuantity");
            int ItemQuantity = Convert.ToInt32(Console.ReadLine());

            Order obj = new Order(CustomerName, ItemName, ItemPrice, ItemQuantity);
            int OrderId = obj.POrderId;

            int Amount = obj.GetOrderAmount();
            Console.WriteLine("order amount is:" + Amount);

            string str = obj.GetDetails();
            Console.WriteLine("order details are:" + str);

            Console.ReadLine();



    }
    }
}
