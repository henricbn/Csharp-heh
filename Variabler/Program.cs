using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 1 
            Console.WriteLine("mata in tal 1:");
            string text1;
            text1 = Console.ReadLine();
            int tal1 = int.Parse(text1);

            Console.WriteLine("mata in tal 2:");
            string text2;
            text2 = Console.ReadLine();
            int tal2 = int.Parse(text2);

            Console.WriteLine("Summan av talen blir: " + (tal1 + tal2));

            Console.WriteLine("Produkten av talen blir: " + (tal1 * tal2));

            Console.WriteLine("Divisionen av talen blir: " + (tal1 / tal2));
            Console.ReadKey();
            //övning 2

            Console.WriteLine("Mata in ditt förnamn");
            string namn1 = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn");
            string namn2 = Console.ReadLine();
            Console.WriteLine("Hej " + namn1 + " " + namn2);

            //övning 3
            Console.WriteLine("Mata in grader i celsius:");
            string grader = Console.ReadLine();
            int celsius = int.Parse(grader);
            Console.WriteLine("Det blir: " + (1.8 * celsius + 32) + " " + "grader farenheit");

            //övning 4 
            Console.Write("Mata in grader i celsius:");
            string grader2 = Console.ReadLine();
            int celsius2 = int.Parse(grader2);
            Console.WriteLine("Det blir: " + (1.8 * celsius2 + 32) + " " + "grader farenheit");

            //övning 5
            Console.Write("Cirkelns radie:");
            string cirkel = Console.ReadLine();
            double radie = double.Parse(cirkel);
            double pi = Math.PI;
            Console.WriteLine("Area: " + (pi * radie * radie));
            Console.WriteLine("Omkrets: " + (2 * pi * radie));
        }
    }
}
