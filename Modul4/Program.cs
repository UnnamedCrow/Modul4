﻿using System;
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
            if (a==b)
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
            var V = a != b ? a + b : b;
            Console.WriteLine(V);
            Console.ReadLine();
                        
        }
    }
}
