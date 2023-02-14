using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4Final
{
    internal class Program
    {
        /// 4.5 
        /// Final homework of modul 4

        static void Main(string[] args)
        {
            /// 4.5.1
            /// Create user tuple
            /// with user firstname, surname, login, login lenght, pet, age, three favourite colors
            (string Firstname, string Surname, string Login, int LoginLenght, bool Pet, double Age, string[] Colors) User;

            /// 4.5.6
            /// add three users
            for (int i = 0; i < 3; i++)
            {

                /// 4.5.2
                /// enter user tuple from console
                Console.Write("PLease enter your firstname: ");
                User.Firstname = Console.ReadLine();
                Console.Write("PLease enter your surname: ");
                User.Surname = Console.ReadLine();
                Console.Write("PLease enter your login: ");
                User.Login = Console.ReadLine();

                /// 4.5.3
                /// find the user login lenght
                User.LoginLenght = User.Login.Length;

                /// 4.5.4
                /// enter pet
                Console.Write("Do you have pets? Yes or No: ");
                if (Console.ReadLine() == "Yes")
                {
                    User.Pet = true;
                }
                else
                {
                    User.Pet = false;
                }

                /// 4.5.5
                /// enter age and colors
                Console.Write("PLease enter your age: ");
                User.Age = double.Parse(Console.ReadLine());
                Console.Write("PLease enter your three favourite colors: ");
                User.Colors = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    User.Colors[i] = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
