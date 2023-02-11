using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 4.1.18
            /// practice with Console.BackgroungColor
            /// reading color from user
            Console.WriteLine("Please enter background color");


            /// logical block
            /// 

            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You chose red color!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You chose green color!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You chose cyan color!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You chose cyan color!");

                    break;
            }

            /// 4.2 try optimisation choise color in cycle
            /// 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter new console color from 1 to 14");
                bool ColorResult = int.TryParse(Console.ReadLine(), out int Color);
                if (ColorResult && Color >= 0 && Color <= 14)
                {
                    Console.BackgroundColor = (ConsoleColor)Color;
                    if (Color == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
            }
            /// 4.1.8 try to exclude OR
            /// 
            int a = 7, b = 6;
            bool c = (a != b) ^ (a > b);
            Console.WriteLine("true ^ true = {0}", c);
            c = (a == b) ^ (a < b);
            Console.WriteLine("false ^ false = {0}", c);
            c = (a != b) ^ (a < b);
            Console.WriteLine("true ^ false = {0}", c);
            c = (a == b) ^ (a > b);
            Console.WriteLine("false ^ true = {0}", c);

            /// 4.1.13 try try to make logical brances
            /// 
            if (a == b)
            {
                Console.WriteLine("Condition true");
            }
            else if (b < 10)
            {
                Console.WriteLine("Condition false and b={0} < 10", b);
            }
            else
            {
                Console.WriteLine("Condition false and b={0} > 10", b);
            }

            /// 4.1.15 try ternary operation
            /// 
            var V = a != b ? a + b : b;
            Console.WriteLine(V);
            Console.ReadLine();

        }
    }
}
