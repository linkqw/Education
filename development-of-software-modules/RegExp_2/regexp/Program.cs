using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main()
        {
            nine();
        }

        static void one()
        {
            Console.WriteLine(Regex.Matches(Console.ReadLine(), "H").Count);
        }

        static void two()
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            string res = "";

            foreach (string s in arr)
            {
                if (Regex.Matches(s, "d").Count <= 0)
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

        static void five()
        {
            Console.WriteLine(Regex.Matches(Console.ReadLine(), @"A\w*").Count);
        }

        static void six()
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            int matches = 0;

            foreach (string s in arr)
            {
                if (Regex.Matches(s, @$"^{s[0]}\w*{s[0]}$").Count > 0)
                {
                    matches++;
                }
            }

            Console.WriteLine(matches);
        }

        static void checkEmail()
        {
            string str = Console.ReadLine();

            Regex rg = new Regex(@"^\w*@[a-z]{4,5}.[a-z]{2,3}", RegexOptions.IgnoreCase);

            if (rg.IsMatch(str))
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void checkPass()
        {
            string str = Console.ReadLine();

            Regex rg1 = new Regex(@"[0-9]+");
            Regex rg2 = new Regex(@"[A-Z]+");
            Regex rg3 = new Regex(@".{8,}");
            if (rg1.IsMatch(str) && rg2.IsMatch(str) && rg3.IsMatch(str))
            {
                Console.WriteLine("its correct");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }

        static void seven()
        {
            string str = Console.ReadLine();
            char ch = Convert.ToChar(Console.Read());

            Regex rg = new Regex(@$"^{ch}\w*");

            foreach(string s in str.Split(" "))
            {
                if (rg.IsMatch(s) && s.Length%2==0)
                {
                    Console.WriteLine(s);
                    break;
                }
            }
        }

        static void eight()
        {
            string str = Console.ReadLine();
            string res = "";
            int min = int.MinValue;
            
            foreach (string s in str.Split(" "))
            {
                if (min > s.Length)
                {
                    res = s;
                }
            }
            Console.WriteLine(res);
        }

        static void nine()
        {
            string str = Console.ReadLine();
            char ch = Convert.ToChar(Console.Read());
            string res = "";
            
            foreach (string s in str.Split(" "))
            {
                if (!(Regex.IsMatch(s, @$"^{ch}\w*")))
                {
                    res += s + " ";
                }
            }
            Console.WriteLine(res);
        }
    }
}