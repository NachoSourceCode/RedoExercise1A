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
            int denominator = 2;
            int a = 3;
            int b = 4;
            int c = 3;
            int aa = 1;
            int bb = 6;
            int cc = -16;

            Program aoc = new Program();
            Program coc = new Program();
            Program voh = new Program();
            Program aot = new Program();
            Program qe = new Program();

            Console.WriteLine($"Area of a circle: {aoc.AreaOfCircle(radius)}");
            Console.WriteLine($"Circumference of a circle: {coc.CircumOfCircle(radius)}");
            Console.WriteLine($"Volume of a hemisphere: {voh.VolOfHemisphere(radius, denominator)}");
            Console.WriteLine($"Area of a triangle: {aot.AreaOfTriangle(a, b, c, denominator)}");

            var res = qe.QuadraticEquation( aa, bb, cc);
            Console.WriteLine($"Quadratic coordinates: {res[0]}, {res[1]}");

        }

        public double AreaOfCircle(int radius)
        {
            
            double area = Math.PI * Math.Pow(radius, 2);
            
            return area;

        }

        public double CircumOfCircle(int radius)
        {

            double circum = 2 * Math.PI * radius;

            return circum;

        }

        public double VolOfHemisphere(int radius, int denominator)
        {
            double volume = (1.33 * Math.PI * Math.Pow(radius, 3)) / denominator;

            return volume;
        }
        
        public double AreaOfTriangle(int a, int b, int c, int denominator)
        {

            //calculate half the circumference of a triangle(semi parameter)
            double sp = (a + b + c) / denominator;

            //calculate area of circle
            double triangleArea = Math.Sqrt(sp * (sp -a) * (sp -b) * (sp - c));

            return triangleArea;
        }

        public double[] QuadraticEquation(int aa, int bb, int cc)
        {
            int denominatorQuadratic = (2 * aa);


            double underSqrt = Math.Pow(bb, 2) - (4 * aa * cc);

            double left = (-bb) / denominatorQuadratic;
            double right = Math.Sqrt(underSqrt) / denominatorQuadratic;
            double x1 = left + right;
            double x2 = left - right;
            double[] answer = new double[2];
            answer[0] = x1;
            answer[1] = x2;

            return answer;
            
        }
    }
}
