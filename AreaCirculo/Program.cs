using System;
using System.Globalization;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AreaCirculo(x);
        }

        public static double AreaCirculo(double n1)
        {
            double a = (n1 * n1) * 3.14;

            Console.WriteLine("Área do circulo " + a.ToString("F2", CultureInfo.InvariantCulture));

            return a;

        }
    }
}
