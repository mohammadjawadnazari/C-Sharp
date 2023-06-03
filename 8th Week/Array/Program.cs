using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Score;
            //int[] = score{ 3,5,7,10};
            //int[] Score = new int[4] { 3, 5, 7, 9 };
            //int[] Score = new int[6];
            //int[] Score;
            //Score = new int[4];

            int[] Score = new int[4];
            String[] Lesson = new string[4];
            int Sum = 0;
            double Avg;
            for(int i=0;i< Lesson.Length; i++)
            {
                Console.WriteLine("Enter Lesson's Name");
                    Lesson[i] = Console.ReadLine();
                Console.WriteLine("Enter Lesson's Score");
                Score[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i< Lesson.Length; i++)
            {
                Sum = Sum + Score[i];
            }
            Avg = (double)Sum/Lesson.Length;

            Console.WriteLine("| Lessons    |   Score   |  Category |");
            Console.WriteLine("|------------|-----------|-----------|");
            for (int i=0;i< Lesson.Length; i++)
            {
                string temp;
                Console.Write($"|{Lesson[i]}        |{Score[i]}         |");
                switch (Lesson[i])
                {
                    case string t when t.StartsWith("prog"):
                        Console.Write("PROGRAMING |\n");
                            break;
                    case string t when t.StartsWith("math"):
                        Console.Write("MATH       |\n");
                        break;
                    case string t when t.StartsWith("islm"):
                        Console.Write("GENERAL    |\n");
                        break;
                }
            }
            Console.WriteLine("|------------|-----------|");
            Console.WriteLine($"|Avrage      |{Avg}        |");
            Console.ReadLine();


        }
    }
}
