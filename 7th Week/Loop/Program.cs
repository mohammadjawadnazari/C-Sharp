using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            Console.Write("Enter The Number that You You want to count: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write(i + "\t");
                i++;
            } while (i <= n);
            Console.WriteLine();
            i = 0;
            while(i<=n)
            {
                Console.Write(i + "\t");
                i++;
            }
            Console.WriteLine();
            for(i=0;i<=n;i++)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
