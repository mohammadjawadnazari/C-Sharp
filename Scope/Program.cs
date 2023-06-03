using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10;
            for (int i = 0; i<5; i++)
            {
                int j = 90;
                Console.Write(i + "\t" );
                
                Console.Write(j + "\t" );
                
                Console.WriteLine(a + "\t");
            }
            for (int i = 0; i < 5; i++)
            {
                int j = 90;
                Console.Write(i + "\t");

                Console.Write(j + "\t");

                Console.WriteLine(a + "\t");
            }
            Console.ReadLine();
        }
    }
}
