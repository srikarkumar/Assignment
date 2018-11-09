using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day2_Order
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter OrderId");
            int OrderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customerName:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("enter Item name:");
            string ItemName = Console.ReadLine();
            Console.WriteLine("enter ItemPrice");
            int ItemPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ItemQuantity");
            int ItemQuantity = Convert.ToInt32(Console.ReadLine()); 

            Order obj = new Order(OrderId,CustomerName,ItemName,ItemPrice,ItemQuantity);

            int Amount = obj.GetOrderAmount();
            Console.WriteLine("orderamount is :" +Amount);

            string str = obj.GetDetails();
            Console.WriteLine("orderdetails are :" +str);





            Console.ReadLine();

        }
    }
}
