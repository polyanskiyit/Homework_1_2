using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть радiус кола:");
            double R = Convert.ToDouble(Console.ReadLine());

            Radius radius = new Radius();

            Console.WriteLine("Hellow Git IV");

            Console.WriteLine("Hellow Git V");

            Console.WriteLine(
                radius.RadiusOfTheCircle(R)
                );

            Console.Read();

        }
    }
}
