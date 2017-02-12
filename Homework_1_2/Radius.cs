using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_2
{
    class Radius : A
    {
        public override double RadiusOfTheCircle(double Rad)
        {
            return Math.PI * Math.Pow(Rad, 2);
        }
        //public double RadiusOfTheCircle(double Radius)
        //{
        //    return Math.PI * Math.Pow(Radius, 2);
        //}
    }
}
