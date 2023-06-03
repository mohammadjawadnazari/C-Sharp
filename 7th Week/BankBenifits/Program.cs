using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBenifits
{
    class Program
    {
        static void Main(string[] args)
        {
            double Blc, BG, BB;
            int months_waite=0;
            Console.WriteLine("Enter your Balance");
            Blc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Goal");
            BG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Bank_Benifits");
            BB = Convert.ToDouble(Console.ReadLine());

            while(Blc<=BG)
            {
                Blc = (Blc * (BB / 100)) + Blc;
                months_waite++;
                Console.WriteLine("Your Balance aftr \t" + months_waite+"\t is \t" + Blc);
            }
            //Console.WriteLine("your Balance after one month: ");
            //BG = (Blc * (BB / 100)) + Blc;

            Console.WriteLine("Number of month that you should wait is \t" + months_waite);
            Console.ReadLine();
        }
    }
}
