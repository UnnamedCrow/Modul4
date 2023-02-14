using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Program
    {
        /// 4.4.5
        /// Add a tuple for pet information
        enum PetType
        {
            dog = 1,
            cat,
            fish,
            hamster,
            turtile
        }
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

            /// 4.2 
            /// try optimisation choise color in cycle
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Please enter new console color from 1 to 14");
                bool colorResult = int.TryParse(Console.ReadLine(), out int color);
                if (colorResult && color >= 0 && color <= 14)
                {
                    Console.BackgroundColor = (ConsoleColor)color;
                    if (color == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
                else
                {
                    break;
                }
            }

            /// 4.2 
            /// try to use cycle "while" for choise console color
            bool ColorResult = true;
            while (ColorResult)
            {
                Console.WriteLine("Please enter new console color from 1 to 14");
                ColorResult = int.TryParse(Console.ReadLine(), out int Color);
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

            /// 4.1.8 
            /// try to exclude OR
            int a = 7, b = 6;
            bool c = (a != b) ^ (a > b);
            Console.WriteLine("true ^ true = {0}", c);
            c = (a == b) ^ (a < b);
            Console.WriteLine("false ^ false = {0}", c);
            c = (a != b) ^ (a < b);
            Console.WriteLine("true ^ false = {0}", c);
            c = (a == b) ^ (a > b);
            Console.WriteLine("false ^ true = {0}", c);

            /// 4.1.13 
            /// try try to make logical brances
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

            /// 4.1.15 
            /// try ternary operation
            var V = a != b ? a + b : b;
            Console.WriteLine(V);

            /// 4.3.2
            /// try to read and write string array
            /// 
            Console.WriteLine("Please enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Your name to spell:");

            // cycle foreach
            foreach (char letter in Name)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("Last letter in your name {0}", Name[Name.Length - 1]);

            /// 4.3.7
            /// try to write Name from the end
            Console.WriteLine("Your name to spell from the end:");
            for (int i = Name.Length - 1; i >= 0; --i)
            {
                Console.Write(Name[i] + " ");
            }
            Console.WriteLine("Last letter in your name {0}", Name[0]);

            /// 4.3.9
            /// try to use array with rank 2
            int[,] NewArray = { { 1, 2, 4, 6 }, { 1, 3, 5, 7 } };
            foreach (int newArray in NewArray)
            {
                Console.Write(newArray + " ");
            }
            Console.WriteLine();

            /// 4.3.11
            /// write values of colomns
            int[,] ArrayEleven = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < ArrayEleven.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < ArrayEleven.GetUpperBound(0) + 1; k++)
                {
                    Console.Write(ArrayEleven[k, i] + " ");
                }
                Console.WriteLine();
            }

            /// 4.3.12 and 4.3.13
            /// array sorting and sum of array elements
            int ArraySum = 0;
            int[] ArrayTwelve = { 5, 6, 9, 1, 3, 2, 4 };
            for (int k = 0; k < ArrayTwelve.Length - 1; k++)
            {
                for (int i = 0; i < ArrayTwelve.Length - 1; i++)
                {

                    if (ArrayTwelve[i] > ArrayTwelve[i + 1])
                    {
                        int item = ArrayTwelve[i];
                        ArrayTwelve[i] = ArrayTwelve[i + 1];
                        ArrayTwelve[i + 1] = item;
                    }

                }
            }
            for (int i = 0; i <= ArrayTwelve.Length - 1; i++)
            {
                ArraySum += ArrayTwelve[i];
                Console.WriteLine(ArrayTwelve[i]);
            }
            Console.WriteLine("Sum of aray elements = {0}", ArraySum);

            /// 4.3.14 
            /// write all values of jagged array
            int[][] ArrayFourteen = new int[3][];
            ArrayFourteen[0] = new int[2] { 1, 2 };
            ArrayFourteen[1] = new int[7] { 1, 2, 3, 1, 6, 2, 1 };
            ArrayFourteen[2] = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var Sting in ArrayFourteen)
            {
                foreach (var item in Sting)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            /// 4.3.15 
            /// find all positive elements
            int[] ArrayFifteen = { 3, -1, 2, -2, 5, 5, 7, 0, 8, -7, -2, -4 };
            int PositiveCounter = 0;
            foreach (int item in ArrayFifteen)
            {
                Console.Write(item + " ");
                if (item > 0)
                {
                    PositiveCounter++;
                }
            }
            Console.WriteLine("\n Amount of positive values = " + PositiveCounter);

            /// 4.3.16
            /// find amount of positive values in array with rank 2
            PositiveCounter = 0;
            int[,] ArraySixteen = { { -5, 6, 9, 1, 2, -3, -10 }, { -8, 8, 1, 1, 2, -3, -20 } };
            foreach (var item in ArraySixteen)
            {
                Console.Write(item + " ");
                if (item > 0)
                {
                    PositiveCounter++;
                }
            }
            Console.WriteLine("\n Amount of positive values = " + PositiveCounter);

            /// 4.3.17
            /// sorting of array with rank 2
            // show the array
            Console.WriteLine("This is array without sorting:");
            for (int i = 0; i < ArraySixteen.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < ArraySixteen.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(ArraySixteen[i, k] + " ");
                }
                Console.WriteLine();
            }

            // sorting of array
            for (int i = 0; i < ArraySixteen.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < ArraySixteen.GetUpperBound(1); k++)
                {
                    for (int t = 0; t < ArraySixteen.GetUpperBound(1) - k; t++)
                    {
                        if (ArraySixteen[i, t] > ArraySixteen[i, t + 1])
                        {
                            int item = ArraySixteen[i, t + 1];
                            ArraySixteen[i, t + 1] = ArraySixteen[i, t];
                            ArraySixteen[i, t] = item;
                        }
                    }
                }
            }
            // show sorting array
            Console.WriteLine("This is array after sorting:");
            for (int i = 0; i < ArraySixteen.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < ArraySixteen.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(ArraySixteen[i, k] + " ");
                }
                Console.WriteLine();
            }

            /// 4.4.1
            /// Add a tuple for user information
            (string name, int age, string birthday, string color) Anketa;
            Console.Write("Please enter your name: ");
            Anketa.name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            Anketa.age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your favourite color: ");
            Anketa.color = Console.ReadLine();
            Console.WriteLine("Your name is {0}, your age is {1}\n and your favourite color is {2}", Anketa.name, Anketa.age, Anketa.color);

            /// 4.4.5
            /// Add a tuple for pet information
            (string Name, PetType Type, double Age, int NameCount) Pet;
            Console.Write("Please enter name of your pet: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Please enter type of your pet Dog - 1, Cat - 2, Hamster - 3, turtile -4 : ");
            Pet.Type = (PetType)int.Parse(Console.ReadLine());
            Console.Write("Please enter age your pet : ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Your pet name is {0}, his type is {1}, his age is {2}\n and his name consist {3} letters", Pet.Name, Pet.Type, Pet.Age, Pet.NameCount);
            Console.ReadLine();
        }

            
            
            
            
        
    }
}
