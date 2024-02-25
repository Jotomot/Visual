using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius
{
    internal class TemperatureConverter
    {
        
            public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
            {
            fahrenheit =  (celsius * 9 / 5) + 32;
            }

            public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
            {
             celsius = (fahrenheit - 32) * 5 / 9;
            }
        
    }
}
