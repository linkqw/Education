using System;

namespace solution
{
    class Program
    {
        static void Main()
        {
            seventy_nine();
        }

        static void fivety_three()
        {
            int summ = 0;

            for (int i = 1; i < 100; i++)
            {
                summ += i;
            }

            Console.WriteLine(summ);
        }

        static void fivety_four()
        {
            int summ = 0;

            for (int i = 1; i < 100; i++)
            {
                summ += i % 2 == 0 ? i : 0;
            }

            Console.WriteLine(summ);
        }

        static void fivety_five()
        {
            int summ = 0;

            for (int i = 1; i < 100; i++)
            {
                summ += i % 2 == 0 ? i * i : 0;
            }

            Console.WriteLine(summ);
        }

        static void fivety_six()
        {
            int summ = 0;

            for (int i = 1; i < 100; i++)
            {
                summ += i % 3 == 0 ? i : 0;
            }

            Console.WriteLine(summ);
        }

        static void fivety_seven()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        static void fivety_eight()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 11; i < 100; i++)
            {
                if (i / 10 + i % 10 == num) Console.WriteLine(i);
            }
        }

        static void fivety_nine()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 11; i < 100; i++)
            {
                if (i / 10 == num || i % 10 == num || i == num || i % num == 0) Console.WriteLine(i);
            }
        }

        static void sixty()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i < num + 1; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

        static void sixty_one()
        {
            for (int i = 200; ; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void sixty_two()
        {
            for (int i = 4999; i > 0; i--)
            {
                if (i % 39 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void sixty_three()
        {
            double money = 1000;

            for (int i = 1; ; i++)
            {
                money += money * 0.02;
                if (money >= 1200)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void sixty_four()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num.ToString().Length);
        }

        static void sixty_five()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int summ = 1;

            foreach (char item in num.ToString())
            {
                summ *= Convert.ToInt32(item);
            }
            Console.WriteLine(summ);
        }

        static void sixty_six()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int summ = 0;

            foreach (char item in num.ToString())
            {
                summ += Int32.Parse(item.ToString());
            }
            Console.WriteLine(summ / Convert.ToInt32(num.ToString().Length));
        }

        static void sixty_seven()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double summ = 0;

            foreach (char item in num.ToString())
            {
                summ += Math.Pow(int.Parse(item.ToString()), 2);
            }
            Console.WriteLine(summ);
        }

        static void sixty_eight()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double summ = 0;

            foreach (char item in num.ToString())
            {
                summ += Math.Pow(int.Parse(item.ToString()), 3);
            }
            Console.WriteLine(summ);
        }

        static void sixty_nine()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num.ToString()[0]);
        }

        static void seventy()
        {
            string num = Console.ReadLine();
            int first = int.Parse(num[0].ToString());
            int last = int.Parse(num[num.Length - 1].ToString());
            Console.WriteLine(first + last);
        }

        static void seventy_one()
        {
            int y;
            double z;

            for (int x = 2700; ; x /= 3)
            {
                y = x / 4 + 20;
                z = 2 * y + 0.23;

                if (z * y < 1 / x)
                {
                    break;
                }
                Console.WriteLine($"{y}, {z}");
            }
        }

        static void seventy_two()
        {
            string put;

            do
            {
                put = Console.ReadLine();
                Console.WriteLine(put + "!");
            } while (put != "Хватит");

            Console.WriteLine("Хватит так хватит");
        }

        static void seventy_three()
        {
            string put;
            int i = 0;

            do
            {
                i += 1;
                put = Console.ReadLine();
                Console.WriteLine(put + $"!\n{i}");
            } while (put != "Хватит");

            Console.WriteLine("Хватит так хватит");
        }

        static void seventy_four()
        {
            int v = 20;

            for (float t = 0; ; t += 0.2f)
            {
                float s = v * t;
                double h = 100 - (9.81 * t * t) / 2;

                Console.WriteLine($"s={s}, v={v}, t={t}");

                if (h <= 0)
                {
                    break;
                }
            }
        }

        static void seventy_five()
        {
            int num = 900;

            while (num > 0)
            {
                Console.WriteLine(Math.Sqrt(num));
                num -= 7;
            }
        }

        static void seventy_six()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(N, 3));
        }

        static void seventy_seven()
        {
            int i = 0;

            while (true)
            {
                if (Convert.ToInt32(Console.ReadLine()) > 0) Console.WriteLine(i += 1);
            }
        }

        static void seventy_eight()
        {
            int i = 0;

            for (int j = 0; j < 10; j++)
            {
                if (Convert.ToInt32(Console.ReadLine()) > 0) i += 1;
            }

            Console.WriteLine(i);
        }

        static void seventy_nine()
        {
            double i, wCount = 0;
            double ddCount = 0;
            char put = 'n';

            for (i = 0; put != '/'; i++)
            {
                put = char.Parse(Console.ReadLine());
                if (put == ':') ddCount++;
                else if (put == 'W') wCount++;
            }
            Console.WriteLine($": - {Math.Round(ddCount / i, 2) * 100}%\nW - {Math.Round(wCount / i, 2)*100}%");
        }

        static void eighty()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int pos = 0, neg = 0, biggerTen = 0;

            for (int i = 0; i < N; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= 0) neg += 1;
                if (num > 0) pos += 1;
                if (num > 10) biggerTen += 1;
            }

            Console.WriteLine($"bigger then ten - {biggerTen}\npositive - {pos}\nnegative - {neg}");
        }

        static void eighty_one()
        {
            for (int i = 3; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(i + "" + j);
                }
            }
        }

        static void eighty_two()
        {
            int num, m = 0;

            while (true)
            {
                if ((num = Convert.ToInt32(Console.ReadLine())) > m) m = num;
                Console.WriteLine($"max number - {m}");
            }
        }

        static void eighty_three()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] putArr = new int[N];

            for (int i = 0; i < N; i++)
            {
                putArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Array.IndexOf(putArr, putArr.Min()));
        }
    }
}