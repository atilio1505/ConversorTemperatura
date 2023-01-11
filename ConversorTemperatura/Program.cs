using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("Conversor de temperatura");
            Console.Write("Insira a temperatura em Celcius: ");
            Console.WriteLine("----------------------");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;
            k = c + 273.15;

            Console.WriteLine(f + " graus celcius ");
            Console.WriteLine(f + " graus fahrenheit");
            Console.WriteLine(k + " graus kelvin");
            Console.ReadKey();
        }
    }
}
