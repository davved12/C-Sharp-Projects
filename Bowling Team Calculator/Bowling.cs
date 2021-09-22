using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Team_1
{
    class Bowling
    {
        private int[] scores;
        private string[] names;
        private string combined;
        private int length = 0;

        //Default Constructer
        public Bowling()
        {
            scores = new int[10];
            names = new string[10];
        }
        //Purpose: Calculates highest score by sorting from greatest to lowest
        //Returns: Nothing
        public void CalcHighest(ref int[] s, ref string [] n)
        {

            for (int i = 0; i < GetLength() - 1; i++)
            {
                for(int j =0; j<GetLength() - 1; j++)
                {
                    if (scores[i + 1] > scores[i])
                    {
                        int tmp = scores[i + 1];
                        int tmp2 = scores[i];
                        scores[i] = tmp;
                        scores[i + 1] = tmp2;

                        string tmp3 = names[i + 1];
                        string tmp4 = names[i];
                        names[i] = tmp3;
                        names[i + 1] = tmp4;

                    }
                }
              
            }

        }
        //Purpose: Calculates average score
        //Returns: Average
        public int CalcAverage(int [] score)
        {
            int average = 0;
            for(int i = 0; i< GetLength(); i++)
            {
                average = score[i] + average;
            }
            average = average / GetLength();
            return average;
        }   
        //Purpose: Sets the length of the array in variable length
        //Returns: Nothing
        public void SetLength()
        {
            string[] names = GetNames();
            for (int i =0; i< 10; i++)
            {
                
                if(names[i] == null)
                {
                    break;
                }
                length++;
            }
        }
        public int GetLength()
        {
            return length;
        }
        public int [] GetScores()
        {
            return scores;
        }
        public string [] GetNames()
        {
            return names;
        }
        public void SetScores(int[] score)
        {
            scores = score;
        }
        public void SetName(string[] name)
        {
            names = name;
        }
        //Purpose: To split the initial string into two arrays one for the names of the bowling team and the other for the scores
        //Returns: Nothing
        public void Initialize(ref int [] scores, ref string [] names)
        {
            string [] initial;
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Please input team member name followed by their score. E.G David 26");
                combined = Console.ReadLine();
                if(combined == "")
                {
                    break;
                }
                initial = combined.Split(null);
                names[i] = initial[0];
                scores[i] = int.Parse(initial[1]);
                SetScores(scores);
                SetName(names);
            }
        }
    }
}
