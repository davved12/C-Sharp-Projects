using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Power_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            Resistors r = new Resistors();

            string path = r.GetP();
            string resistancePower;
            string[] initial;
            double[] dissipatation;
            string[] pass;
            

            r.SetPath(path);

            StreamReader data = new StreamReader(path);
            resistancePower = data.ReadLine();
            initial = resistancePower.Split(null);

            r.SetResistance(int.Parse(initial[0]));
            r.SetPower(int.Parse(initial[1]));
            r.SetVoltages();
            Console.WriteLine("Res#\tDissipation\tPassed");
            r.CalcDissip(r.GetVoltages());
            dissipatation = r.GetDissip();
            r.Pass(dissipatation);
            pass = r.GetPass();
            
            
            for(int i = 0; i<r.GetLength(); i++)
            {
                Console.WriteLine($"{i+1}\t{r.GetDissip(i)}\t\t{pass[i]}");
            }
            Console.ReadLine();
                         
        }
    }
}
