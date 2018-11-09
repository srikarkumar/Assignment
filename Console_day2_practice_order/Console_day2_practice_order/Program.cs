using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_day2_practice_order
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("enter order Id:");
           // int Oid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter cust Name");
            string Cname = Console.ReadLine();
            Console.WriteLine("enter item name");
            string Iname = Console.ReadLine();
            Console.WriteLine("enter item price");
            int Iprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter item quantity");
            int Iqnty = Convert.ToInt32(Console.ReadLine());

            Order obj = new Order(Cname, Iname, Iprice, Iqnty);
            int OrderId = obj.POrderId;

            double a = obj.GetOrderAmount();
            Console.WriteLine("amount " +a);


            string b = obj.GetDetails();
            Console.WriteLine("details are:" + b);


            Console.ReadLine();

        }
    }
}
