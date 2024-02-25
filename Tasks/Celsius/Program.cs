// See https://aka.ms/new-console-template for more information
using Celsius;

Console.WriteLine("Hello, World!");
TemperatureConverter temperatureConverter = new TemperatureConverter();
double fahrenheit = 0;
temperatureConverter.ConvertCelsiusToFahrenheit(35, out fahrenheit);

double celsius = 0;
temperatureConverter.ConvertFahrenheitToCelsius(0, ref celsius);

Console.WriteLine($" 0 stopni fahrenheit'a to {celsius} stopni celsjusza");
Console.WriteLine($" 35 stopnie celsjusza to {fahrenheit} stopni fahrenheit'a");