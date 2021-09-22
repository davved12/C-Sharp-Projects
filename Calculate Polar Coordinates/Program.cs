using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Polar_Cordinantes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string [] initial;
            char dilimiter = ',';
            bool verify, verify2 = false;
            double x = 0;
            double y = 0;

            Console.WriteLine("This program calculates the polar coordinantes\n");

         
                Console.WriteLine("Please enter your coordinates, seprated by a comma(make sure their positive)");
                initial = Console.ReadLine().Split(dilimiter);
                verify = double.TryParse(initial[0], out x);
                verify2 = double.TryParse(initial[1], out y);
                while (verify == false || verify2 == false)
                {
                    Console.WriteLine("Please make sure that both are numbers");
                    initial = Console.ReadLine().Split(dilimiter);
                    verify = double.TryParse(initial[0], out x);
                    verify2 = double.TryParse(initial[1], out y);
                }

            Check(ref x,ref y);
            CalculatePolar(ref x, ref y);
            Display(x, y);

        }
        static void Check(ref double x, ref double y)
        {
            bool fake = false;
            bool fake2 = false;
            while (x < 0 || y < 0)
            {
                Console.Write("Positive x coordinate:");
                fake = double.TryParse(Console.ReadLine(), out x);
                Console.Write("Positive y coordinate:");
                fake2 = double.TryParse(Console.ReadLine(), out y);
            }
        }
        static void CalculatePolar(ref double x, ref double y)
        {
            double pi = Math.PI;
            double half = 180;
            double degrees;

            double radius = Math.Sqrt((x * x) + (y * y));
            double q = Math.Atan(y / x);
            degrees = q * (half / pi);
            x = radius;
            y = degrees;
        }
        static void Display(double x, double y)
        {
            Console.WriteLine("The polar coordinates are {0:D},{1:D}",x.ToString(), y.ToString());
            Console.ReadLine();
        }
    }
}
