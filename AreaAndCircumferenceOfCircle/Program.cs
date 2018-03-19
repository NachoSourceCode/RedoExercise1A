using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 

** Area and circumference of circle **
Write a program that calculates both the area and the circumference of a circle given the 
radius r. Assume that r is greater than zero, but not necessarily an integer. 
Use these formulas. The C# syntax for the square root is Math.Sqrt(). π  is 3.14159.
 
** Volume of a hemisphere **
Write a program that calculates the volume of a hemisphere given the length of the radius. Assume 
that the radius is not negative. 

*/

namespace AreaAndCircumferenceOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {

           int radius = 20;

           Program aoc = new Program();
           Program coc = new Program();

           Console.WriteLine(aoc.AreaOfCircle(radius));
           Console.WriteLine(coc.CircumOfCircle(radius));

        }

        public double AreaOfCircle(double radius)
        {
            
            double area = Math.PI * Math.Pow(radius, 2);
            
            return area;

        }

        public double CircumOfCircle(double radius)
        {

            double circum = 2 * Math.PI * radius;

            return circum;

        }


    }
}
