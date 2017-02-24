using System;

namespace Homework_1_2
{
    class Program
    {
        private static double radiusOfTheCircle(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть радiус кола:");
            double r = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(radiusOfTheCircle(r));
            Console.Read();
        }
    }
}