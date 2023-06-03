using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string x in args)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
