using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Recipe
    {
        Inventory inventory;
        public int numberOfLemons;
        public int totalIcePerCup;
        public int totalSugarPerCup;
        public int numberOfCups;
       
        public Recipe()
        {
            inventory = new Inventory();
        }

        public void chooseRecipe(Weather weather)
        {
            if (weather.todaysWeather == "Sunny Day")
            {
                numberOfLemons = 3;
                totalIcePerCup = 3;
                totalSugarPerCup = 3;
                numberOfCups = 3;
            }
            else if (weather.todaysWeather == "Cloudy Day")
            {
                numberOfLemons = 2;
                totalIcePerCup = 2;
                totalSugarPerCup = 2;
                numberOfCups = 2;
            }
            else if (weather.todaysWeather == "Rainy Day")
            {
                numberOfLemons = 1;
                totalIcePerCup = 1;
                totalSugarPerCup = 1;
                numberOfCups = 1;
            }
        }
        
      
    }
}
