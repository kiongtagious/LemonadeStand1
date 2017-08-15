using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Day
    {
        Customer customer;
        Store store;

        public Day()
        {
            customer = new Customer();
            store = new Store();
        }
        static void Main(string[]args)
        {
            DateTime now = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            }
        }
        
    }
}
