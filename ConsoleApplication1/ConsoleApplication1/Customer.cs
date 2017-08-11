using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Customer
    {
        
        public double buyingChance;
        Random randomCustomers = new Random();   
        
        public Customer()
        {
            
        }
        public void GetCustomer(Weather weather)
        {

            if (weather.todaysWeather == "Sunny Day")
            {
                buyingChance = (9 / 10) * 100;
            }
            else if (weather.todaysWeather == "Cloudy Day")
            {
                buyingChance = (7 / 10) * 100;
            }
            else if (weather.todaysWeather == "Rainy Day")
            {
                buyingChance = (3 / 10) * 100;
            }
        }
    }



}
