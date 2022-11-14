using System;
using System.Text.RegularExpressions;

namespace regExp2
{
    class Program
    {
        static void Main()
        {
            checkFloat();
        }

        static void checkDate()
        {
            Regex rg = new Regex(@"^([0-9]{2}\.){2}[0-9]{2,4}");

            if (rg.Match(Console.ReadLine()).Success)
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void checkTime()
        {
            Regex rg = new Regex(@"^[0-9]{2}\:[0-59]");
            Regex rg2 = new Regex(@"^[2-9][4,]\:\w*");

            string str = Console.ReadLine();

            if (rg.Match(str).Success && !rg2.Match(str).Success)
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void checkNum()
        {
            string str = Console.ReadLine();
            Regex rg = new Regex(@"^\d+$|^-\d+$");

            if (rg.Match(str).Success)
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void checkFloat()
        {
            string str = Console.ReadLine();
            Regex rg = new Regex(@"^(-|)\d+(\.\d+|)$");

            if (rg.Match(str).Success)
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void checkPhoneNumber()
        {
            string str = Console.ReadLine();
            Regex rg1 = new Regex(@"^\+7 \(863\) [0-9]{3}-[0-9]{2}-[0-9]{2}");

            if (rg1.Match(str).Success)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
