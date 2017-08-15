using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Store
    {
        Inventory inventory;

        public Store()
        {
            inventory = new Inventory();
        }
        public int openStore()
        {
            int number = 0;

            Console.WriteLine("Welcome to The Store!");
            Console.WriteLine("Please enter a number: (1) to buy lemons, (2) to buy Ice, (3) to buy Cups, or (4) to buy Sugar");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("How many would you like? The cost is .10 for each.");
                int num;
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            else if (number == 2)
            {
                Console.WriteLine("How much would you like? The cost is .10 for each cup.");
                int num;
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            else if (number == 3)
            {
                Console.WriteLine("How much would you like? The cost is .10 for each.");
                int num;
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                return num;
            }

            else if (number == 4)
            {
                Console.WriteLine("How many would you like? The cost is .10 for each cup.");
                int num;
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            else 
            {

            }
            return number;

        }
        public void GetTotalPriceItems(int num)
        {
            double priceOfItem = 0.10;
            double sumOfItemPrice = num * priceOfItem;
        }
            
    }
}
