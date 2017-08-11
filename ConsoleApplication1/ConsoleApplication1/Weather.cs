using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Weather
    {
        public string todaysWeather;
        public int currentTemperature;

        public Weather(int currentTemperature)
        {
            this.currentTemperature = currentTemperature;
        }
        public void GetWeather()
        {
            if (currentTemperature >= 70)
            {
                todaysWeather = "Sunny Day";
            }
            else if (currentTemperature <= 69)
            {
                todaysWeather = "Cloudy Day";
            }
            else if (currentTemperature <= 55)
            {
                todaysWeather = "Rainy Day";
            }
        }
    }
}
