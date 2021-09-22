using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Number_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int binary;
            int[] number;
            bool flag = false;
            bool isYes = false;
            bool isBinary = false;
			double decNum;
            double total = 0;
            int multiple = 2;
            string response;

            Console.WriteLine("This program converts binary numbers into decimal numbers.\n");
            do
            {
                
                do
                {
                    Console.WriteLine("Please enter your binary number e.g 1010");
                    flag = int.TryParse(Console.ReadLine(), out binary);
                    while (flag == false)
                    {
                        Console.WriteLine("Input numbers only");
                        flag = int.TryParse(Console.ReadLine(), out binary);
                    }

                    string temp = binary.ToString();
                    number = new int[temp.Length];

                    for (int i = 0; i < number.Length; i++)
                    {
                        number[i] = (binary / (int)(Math.Pow(10, (temp.Length - 1) - i)));
                        if (i > 0)
                        {
                            number[i] = number[i] % 10;
                        }

                        if (number[i] < 0 || number[i] > 1)
                        {
                            isBinary = false;
                            Console.Write("Make sure it contains only 1's and 0's. ");
                            break;
                        }
                        else { isBinary = true; }

                    }

                }
                while (isBinary == false);

              
                    for (int i = 0; i < number.Length; i++)
                    {
                        decNum = number[i] * Math.Pow(multiple, i);
                        total = decNum + total;

                    }
                    Console.WriteLine("The decimal conversion is: " + total);
                    Console.WriteLine("Would you like to do it again, y or n");
                    response = Console.ReadLine().ToLower();
                    isYes = response == "y";
            } while (isYes == true);
        }
    }
}
