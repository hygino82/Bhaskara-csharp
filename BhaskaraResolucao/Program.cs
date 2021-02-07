using System;
using System.Globalization;

namespace BhaskaraResolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o valor de a -> ");
                double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe o valor de b -> ");
                double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe o valor de c -> ");
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double delta = Math.Pow(b, 2.0) - 4 * a * c;
                double xv = -b / 2 * a;

                Console.WriteLine($"Delta = {delta.ToString("F4", CultureInfo.InvariantCulture)}");

                if (delta > 0)
                {
                    Console.WriteLine("Possui duas raízes distintas");
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("x1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                    Console.WriteLine("x2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
                }
                else if (delta == 0.0)
                {
                    Console.WriteLine("Possui duas raízes iguais");
                    Console.WriteLine("x1 = x2 = " + xv.ToString("F4", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Possuí raízes complexas");

                    double imaginaria = Math.Sqrt(-delta) / 2 * a;//parte imaginaria
                    if (xv != 0.0)
                    {
                        Console.WriteLine("x1 = " + xv.ToString("F4", CultureInfo.InvariantCulture) + " + " + imaginaria.ToString("F4", CultureInfo.InvariantCulture) + "i");
                        Console.WriteLine("x2 = " + xv.ToString("F4", CultureInfo.InvariantCulture) + " - " + imaginaria.ToString("F4", CultureInfo.InvariantCulture) + "i");
                    }
                    else
                    {
                        Console.WriteLine("x1 =  + " + imaginaria.ToString("F4", CultureInfo.InvariantCulture) + "i");
                        Console.WriteLine("x2 =  - " + imaginaria.ToString("F4", CultureInfo.InvariantCulture) + "i");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Formato inválido, tente novamente");
            }
        }
    }
}
