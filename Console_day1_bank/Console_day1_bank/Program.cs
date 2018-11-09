using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_day1_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter acc no");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter cust add");
            int address = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of acc");
            string typeofacc =Console.ReadLine();
            //Console.WriteLine("enter balance");
            //int balance = Convert.ToInt32(Console.ReadLine());
            int amount = 500;

            bool flag = true;
            while(flag)
            {
               
                Console.WriteLine("enter 1 :withdraw:\n 2:deposite\n  3:check balance\n  4:exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("amount available is" + amount);
                        Console.WriteLine("enter amount to withdraw:");
                        amount = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("enter amount to deposite");
                        int amountt = Convert.ToInt32(Console.ReadLine());
                        if (amountt > 500)
                        {
                            amount = amount + amountt;
                            Console.WriteLine("deposite successful");
                        }
                        break;
                    case 3:
                        Console.WriteLine("amount balance is");
                        Console.WriteLine(amount);
                        break;
                    case 4:
                        Console.WriteLine("press enter to exit");
                        flag = false;
                        break;

                }
            }

        }
    }
}
