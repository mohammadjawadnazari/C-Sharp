using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char op;
            string req;
            Console.WriteLine("Enter your request");
            req = Console.ReadLine();
            req.Split('+', '-', '*', '/');
            //Console.WriteLine("Enter the first number");
            //a= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter an operator");
            //op = Convert.ToChar(Console.ReadLine());
            //if (op == '+')
            //    Console.WriteLine(a + b);
            //else if (op == '-')
            //    Console.WriteLine(a - b);
            //else if (op == '*')
            //    Console.WriteLine(a * b);
            //else if (op == '/')
            //    Console.WriteLine(a / b);
            //else
            //    Console.WriteLine("error");

            switch(op)
            {
                case '+':
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(a / b);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
