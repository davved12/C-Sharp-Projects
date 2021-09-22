using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Function_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string equation;
            string[] problem;
            char[] dilimiter = { '+', '-', '/', '*', '^' };
            char[] statement;
            int num1;
            int num2;
            string operater;
            bool response;

            Console.WriteLine("This is a six function calculator (+,-,*,/,^)\n");

            do
            {


                Console.WriteLine("Please enter your number, followed by operator followed by another number");
                equation = Console.ReadLine();
                statement = equation.ToCharArray();
                problem = equation.Split(dilimiter);

                while (problem.Length < 2)
                {
                    Console.WriteLine("Please make sure to enter an operator thank you");
                    equation = Console.ReadLine();
                    statement = equation.ToCharArray();
                    problem = equation.Split(dilimiter);
                }
                num1 = int.Parse(problem[0]);
                num2 = int.Parse(problem[1]);
                for (int i = 0; i < statement.Length; i++)
                {
                    switch (statement[i])
                    {
                        case '+':
                            Console.WriteLine(num1 + "+" + num2 + "=" + Addition(num1, num2));
                            break;
                        case '-':
                            Console.WriteLine(num1 + "-" + num2 + "=" + Subtraction(num1, num2));
                            break;
                        case '*':
                            Console.WriteLine(num1 + "*" + num2 + "=" + Multiply(num1, num2));
                            break;
                        case '/':
                            Console.WriteLine(num1 + "/" + num2 + "=" + Divide(ref num1, num2));
                            break;
                        case '^':
                            Console.WriteLine(num1 + "^" + num2 + "=" + Power(num1, num2));
                            break;

                    }
                }
                response = YayOrNay();
            } while (response == true);
        }

        static double Addition(int num1, int num2)
        {
            double sum;
            sum = num1 + num2;
            return sum;
        }

        static double Subtraction(int num1, int num2)
        {
            double difference;
            difference = num1 - num2;
            return difference;
        }

        static double Multiply(double num1, double num2)
        {
            double product = 0;
            for (int i = 0; i < num2; i++)
            {
                product = product + num1;
            }
            return product;
        }

        static double Divide(ref int num1, double num2)
        {
            double quotient = 0;
            double tmp = num1;
            double tmp2 = num2;

            while (num1 > 0)
            {
                num1 = (int)(num1 - num2);
                quotient++;
            }

            return quotient;
        }

        static double Power(int num1, int num2)
        {
            double power = Multiply(num1, num1);
            double tmp = 0;
            for (int i = 2; i < num2; i++)
            {
                if (num2 == 2)
                {
                    tmp = Multiply(num1, num1);
                    return tmp;
                }
                else if (num2 == 0)
                {
                    return 1;
                }
                else if (num2 == 1)
                {
                    return num1;
                }
                else
                {
                    power = Multiply(power, num1);
                    power = Multiply(power, num1);
                    //power = Multiply(power, num1);
                }
            }
            return power;
        }

        //Purpose:Makes sure user is typing valid input
        //Parameters: None
        //Returns: True if they said yes false if they said no
        //Pre-Conditions: None
        //Post-conditions: True or False
        static bool YayOrNay()
        {
            char response = 'n';
            while (true)
            {
                Console.WriteLine("Would you like to calculate another equation (y or n)");
                bool flag = char.TryParse(Console.ReadLine(), out response);
                while (flag == false)
                {
                    Console.WriteLine("Please make sure you only type in one character thank you");
                    flag = char.TryParse(Console.ReadLine(), out response);
                }
                response = char.ToLower(response);
                if (response == 'y')
                {
                    return true;
                }
                else if (response == 'n')
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please make sure its either y or n, thanks");
                }
            }
        }
    }
    
}
