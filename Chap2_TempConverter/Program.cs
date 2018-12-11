using System;

namespace Chap2_TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature in Fahrenheit: ");
            Double.TryParse(Console.ReadLine(), out double fTemp);
            double fahrenheit = FahrenheitAndCelsius.CelsiusTemperature(fTemp);
            Console.WriteLine($"The temperature in celsius is {fahrenheit:N1}");

            Console.WriteLine("Please enter a temperature in Celsius: ");
            Double.TryParse(Console.ReadLine(), out double cTemp);
            double celsius = FahrenheitAndCelsius.FarhenheitTemperature(cTemp);
            Console.WriteLine($"The temperature in celsius is {celsius:N1}");
        }
    }
}
