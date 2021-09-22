using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Team_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowling bowl = new Bowling();

            int[] scores = bowl.GetScores();
            string[] names = bowl.GetNames();
           

            bowl.Initialize(ref scores, ref names);
            bowl.SetLength();
            int length = bowl.GetLength();
            bowl.CalcHighest(ref scores, ref names);
            Console.WriteLine("The average score was:" + bowl.CalcAverage(scores) + "\n");
            for (int i = 0; i< length; i++)
            {
                Console.WriteLine($"{names[i]} scored {scores[i]}");
            }
            Console.WriteLine($"\n{names[0]} scored the highest with a score of {scores[0]}");
            Console.WriteLine($"{names[length - 1]} scored the lowest with a score of {scores[length - 1]}");      
            Console.ReadLine();
        }
    }
}
