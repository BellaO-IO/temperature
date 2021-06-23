using System;

namespace thingy
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = Temp.FahrenheitToCelsius(68);
            var fahrenheit = Temp.CelsiusToFarenheit(20);
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }
    }
}
