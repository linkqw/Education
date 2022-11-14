using System;
using System.Text.RegularExpressions;

namespace task
{
    class Program
    {
        static void Main()
        {
            four();
        }

        static void one()
        {
            Console.WriteLine(Regex.Matches(Console.ReadLine(), "H").Count());
        }

        static void two()
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            string res = "";

            foreach (string s in arr)
            {
                if (Regex.Matches(s, "d").Count() <= 0)
                {
                    res += s + " ";
                }
            }
            Console.WriteLine(res);
        }

        static void three()
        {
            string s = Console.ReadLine();
            string res = "";
            foreach (char i in s)
            {
                res += i.ToString();
                res += i.ToString();
            }
            Console.WriteLine(res);
        }

        static void four()
        {
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join("", arr));
        }
    }
}