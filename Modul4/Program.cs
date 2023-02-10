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
            /// 4.1.8 try to exclude OR
            /// 
            int a=7, b=6;
            bool c = (a != b) ^ (a > b); 
            Console.WriteLine("true ^ true = {0}", c);
            c = (a == b) ^ (a < b);
            Console.WriteLine("false ^ false = {0}", c);
            c = (a != b) ^ (a < b);
            Console.WriteLine("true ^ false = {0}", c);
            c = (a == b) ^ (a > b);
            Console.WriteLine("false ^ true = {0}", c);
            Console.ReadLine();
        }
    }
}
