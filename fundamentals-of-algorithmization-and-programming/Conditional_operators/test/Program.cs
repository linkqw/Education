using System;
using System.Data;

namespace test
{
    class Program
    {
        static void Main()
        {
            //fourty_seven();
            //fivety();
            fivety_two();
        }

        static void one()
        {
            int a = 5;
            int b = 12;
            Console.WriteLine($"сумма - {a + b}");
        }

        static void two()
        {
            int a = 8; //Convert.ToInt32(Console.ReadLine());
            int b = 10; // Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"сумма - {a + b} \nразность - {a - b} \nпроизведение - {a * b}");
        }

        static void three()
        {
            float a = 8; //float.Parse(Console.ReadLine());
            float b = 6; //float.Parse(Console.ReadLine());
            Console.WriteLine($"частное - {a / b}");
        }

        static void four()
        {
            int catet1 = 9; //Convert.ToInt32(Console.ReadLine());
            int catet2 = 20; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"гипотенуза - {Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2))}");
            Console.WriteLine($"площадь - {catet1 * catet2 / 2}");
        }

        static void five()
        {
            float r1 = 9; //float.Parse(Console.ReadLine());
            float r2 = 3; //float.Parse(Console.ReadLine());
            float r3 = 6; //float.Parse(Console.ReadLine());
            Console.WriteLine($"сопротивление - {1 / r1 + 1 / r2 + 1 / r3}");

        }

        static void six()
        {
            float x = 9.8f; //float.Parse(Console.ReadLine());
            float y = 8.6f; //float.Parse(Console.ReadLine());

            Console.WriteLine($"ответ - {(Math.Abs(x) - Math.Abs(y)) / (1 + Math.Abs(x + y))}");
        }

        static void seven()
        {
            int a = 9; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"объем - {Math.Pow(a, 3)} \nплощадь - {Math.Pow(a, 2)}");
        }

        static void eight()
        {
            float a = 69.4f;  //float.Parse(Console.ReadLine());
            float b = 5.4f;  //float.Parse(Console.ReadLine());

            Console.WriteLine($"среднее арифметическое - {(a + b) / 2} \nсреднее геометрическое - {Math.Sqrt(a * b)}");
        }

        static void nine()
        {
            float x = 7.8f;  //float.Parse(Console.ReadLine());
            float y = 6.7f;  //float.Parse(Console.ReadLine());
            Console.WriteLine($"среднее арифметическое квадратов - {(Math.Pow(x, 2) + Math.Pow(y, 2)) / 2} \nсреднее геометрическое модулей - {Math.Sqrt(Math.Abs(x) * Math.Abs(y))}");
        }

        static void ten()
        {
            int v = 7; //Convert.ToInt32(Console.ReadLine());
            int u = 3; //Convert.ToInt32(Console.ReadLine());
            int t1 = 1; //Convert.ToInt32(Console.ReadLine());
            int t2 = 2; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"путь равен {((v + u) * t1) + ((v - u) * t2)}");
        }

        static void eleven()
        {
            int v1 = 50; //Convert.ToInt32(Console.ReadLine());
            int v2 = 90; //Convert.ToInt32(Console.ReadLine());
            int t = 4; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"расстояние через время t - {(v1 * t) + (v2 * t)}");
        }

        static void twelve()
        {
            double pi = 3.14; //Convert.ToDouble(Console.ReadLine());
            int r = 8; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"длинна окружности - {2 * pi * r} \nплощадь круга - {pi * r * r}");
        }

        static void threeteen()
        {
            int R = 8; //Convert.ToInt32(Console.ReadLine());
            int r = 3; //Convert.ToInt32(Console.ReadLine());
            double pi = 3.14; //Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"площадь кольца - {pi * (R - r)}");
        }

        static void fourteen()
        {
            int a = 3; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"площадь - {(a * a * Math.Sqrt(3)) / 4} \nr вписанной окружности - {(a * Math.Sqrt(3)) / 6} \nr описанной окружности - {a / Math.Sqrt(3)}");
        }

        static void fiveteen()
        {
            int a = 8; //Convert.ToInt32(Console.ReadLine());
            int b = 10; //Convert.ToInt32(Console.ReadLine());
            double angle = 1.04f; //Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"площадь - {((a + b) / 2) * (Math.Sqrt(Math.Pow(1 / Math.Cos(angle), 2) - ((a - b) / 2)))} \nпериметр - {a + b + (1 / Math.Cos(angle)) * 2}");
        }

        static void sixteen()
        {
            int x1 = 8; //Convert.ToInt32(Console.ReadLine());
            int x2 = 10; //Convert.ToInt32(Console.ReadLine());
            int y1 = 9; //Convert.ToInt32(Console.ReadLine());
            int y2 = 11; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"расстояние - {Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))}");
        }

        static void seventeen()
        {
            int x1 = 5; //Convert.ToInt32(Console.ReadLine());
            int x2 = 4; //Convert.ToInt32(Console.ReadLine());
            int x3 = 3; //Convert.ToInt32(Console.ReadLine());
            int y1 = 5; //Convert.ToInt32(Console.ReadLine());
            int y2 = 4; //Convert.ToInt32(Console.ReadLine());
            int y3 = 3; //Convert.ToInt32(Console.ReadLine());

            double x1x2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double x2x3 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y3 - y3, 2));
            double x1x3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double p = (x1x2 + x1x3 + x2x3) / 2;

            Console.WriteLine($"площадь - {Math.Sqrt(Math.Abs((p * (p - x1x2) * (p - x2x3) * (p - x1x3))))} \nпериметр - {x1x2 + x1x3 + x2x3}");
        }

        static void eighteen()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"сумма чисел - {(num / 1000) + (num % 1000 / 100) + (num % 1000 % 100 / 10) + (num % 1000 % 100 % 10)}");
        }

        static void nineteen()
        {
            int x = 7; //Convert.ToInt32(Console.ReadLine());
            int y = 9; //Convert.ToInt32(Console.ReadLine());
            int z = 10; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a1 = {(Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + (x * x / 2) + (y * y / 4))}");
            Console.WriteLine($"a2 = {(1 + y) * ((x + y) / (x * x + 4)) / (Math.Exp(-x - 2) + (1 / (x * x + 4)))}");
            Console.WriteLine($"a3 = {(3 + Math.Exp(y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(z)))}");
            Console.WriteLine($"a4 = {Math.Log10(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - (y / (z + x * x / 4)))))}");
            Console.WriteLine($"a5 = {y + (x / (y * y + (Math.Abs(x * x / (y + Math.Pow(x, 3) / 4)))))}");
            Console.WriteLine($"b1 = {1 + Math.Abs(y - x) + ((Math.Pow(y - x, 2)) / 2) + ((Math.Pow(Math.Abs(y - x), 3)) / 3)}");
            Console.WriteLine($"b2 = {1 + (z * z / (3 + z * z / 5))}");
        }

        static void twenty()
        {
            double x = 3.64618; //Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Целая часть числа x - " + Math.Floor(x));
            Console.WriteLine("Округленное число x - " + Math.Round(x));

        }

        static void twenty_one()
        {
            int a = 50; //Convert.ToInt32(Console.ReadLine());
            int b = 30; //Convert.ToInt32(Console.ReadLine()); 
            int A = 20; //Convert.ToInt32(Console.ReadLine());
            int B = 10; //Convert.ToInt32(Console.ReadLine());

            int m = a - A;
            int c = b - B;

            Console.WriteLine($"Площадь дома - {A * B}");
            Console.WriteLine($"Площадь территории - {m * b + A * c}");
            Console.WriteLine($"Длина забора -  {a + a + b + c}");
        }

        static void twenty_two()
        {
            string Ptitle1 = Console.ReadLine();
            string Ptitle2 = Console.ReadLine();

            double r1 = Convert.ToDouble(Console.ReadLine());
            double r2 = Convert.ToDouble(Console.ReadLine());
            double v1 = Convert.ToDouble(Console.ReadLine());
            double v2 = Convert.ToDouble(Console.ReadLine());

            double l1 = 2 * Math.PI * r1;
            double l2 = 2 * Math.PI * r2;

            Console.WriteLine($"Продолжительность года на планете {Ptitle1} - {Math.Round(l1 / v1)} суток, а на планете {Ptitle2} - {Math.Round(l2 / v2)} суток.");
        }

        static void twenty_three()
        {
            int a = 8; //Convert.ToInt32(Console.ReadLine());
            int b = 10; //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b));
        }

        static void twenty_four()
        {
            int a = 8; //Convert.ToInt32(Console.ReadLine());
            int b = 10; //Convert.ToInt32(Console.ReadLine());
            int c = 3; //Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) Console.WriteLine(a);
            else if (b > c && b > a) Console.WriteLine(b);
            else Console.WriteLine(c);
        }

        static void twenty_five()
        {
            int a = 12; //Convert.ToInt32(Console.ReadLine());
            int b = 13; //Convert.ToInt32(Console.ReadLine());
            int c = 14; //Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c) Console.WriteLine($"{a}, {b}, {c}");
                else Console.WriteLine($"{a}, {c}, {b}");
            }

            else if (b > a && b > c)
            {
                if (a > c) Console.WriteLine($"{b}, {a}, {c}");
                else Console.WriteLine($"{a}, {c}, {b}");
            }

            else
            {
                if (b > a) Console.WriteLine($"{c}, {b}, {a}");
                else Console.WriteLine($"{c}, {a}, {b}");
            }
        }

        static void twenty_six()
        {
            int x = -12; //Convert.ToInt32(Console.ReadLine());

            if (x < 0) x = -x;
            Console.WriteLine(x);
        }

        static void twenty_seven()
        {
            int x = 12; //Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 5; i++)
            {
                if (i == x) Console.WriteLine("true");
            }
        }

        static void twenty_eight()
        {
            double sum = 12000; //Convert.ToDouble(Console.ReadLine());

            sum = sum > 10000 ? sum *= 0.9 : sum;

            Console.WriteLine(sum);
        }

        static void twenty_nine()
        {
            int num = 13; //Convert.ToInt32(Console.ReadLine());

            if (num % 13 == 0) Console.WriteLine("число делится на 13");
            else Console.WriteLine("число не делится на 13");
        }

        static void theerty()
        {
            int day = 5; //Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("пн");
                    break;
                case 2:
                    Console.WriteLine("вт");
                    break;
                case 3:
                    Console.WriteLine("ср");
                    break;
                case 4:
                    Console.WriteLine("чт");
                    break;
                case 5:
                    Console.WriteLine("пт");
                    break;
                case 6:
                    Console.WriteLine("сб");
                    break;
                case 7:
                    Console.WriteLine("вс");
                    break;
                default:
                    Console.WriteLine("введите число в диапозоне 1-7");
                    break;
            }
        }

        static void theerty_one()
        {
            int num = 598; //Convert.ToInt32(Console.ReadLine());
            int max = 0;

            int first = num / 100;
            int second = (num - first * 100) / 10;
            int third = ((num - first * 100) - second) / 10;

            Console.WriteLine($"{first}, {second}, {third}");

            if (first > second)
            {
                if (first > third) max = first;
                else max = third;
            }
            if (second > first)
            {
                if (second > third) max = second;
                else max = third;
            }
            if (third > first)
            {
                if (third > second) max = third;
                else max = second;
            }
            Console.WriteLine(max);
        }

        static void theerty_two()
        {
            int num1 = 1; //Convert.ToInt32(Console.ReadLine());
            int num2 = -8; //Convert.ToInt32(Console.ReadLine());
            int num3 = 5; //Convert.ToInt32(Console.ReadLine());
            int summ = 0;

            int[] arr = new int[] { num1, num2, num3 };

            for (int i = 0; i < 3; i++)
            {
                if (arr[i] < 0) arr[i] = 0;
                summ += arr[i];
            }

            Console.WriteLine(summ);
        }

        static void threerty_three()
        {
            int num1 = 1; //Convert.ToInt32(Console.ReadLine());
            int num2 = -8; //Convert.ToInt32(Console.ReadLine());
            int num3 = 5; //Convert.ToInt32(Console.ReadLine());
            int summ = 0;

            int[] arr = new int[] { num1, num2, num3 };

            for (int i = 0; i < 3; i++)
            {
                if (arr[i] == 0) summ += 1;
            }

            Console.WriteLine(summ);
        }

        static void threety_four()
        {
            int num1 = 1; //Convert.ToInt32(Console.ReadLine());
            int num2 = -8; //Convert.ToInt32(Console.ReadLine());
            int num3 = 5; //Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[] { num1, num2, num3 };

            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > 0) arr[i] *= arr[i];
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void threety_five()
        {
            int x = 1; //Convert.ToInt32(Console.ReadLine());
            string result;

            result = x % 2 == 0 ? "четное" : "нечетное";
            Console.WriteLine(result);
        }

        static void threety_six()
        {
            int a = 1; //Convert.ToInt32(Console.ReadLine());
            int b = -8; //Convert.ToInt32(Console.ReadLine());
            int c = 5; //Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[] { a, b, c };

            if (a <= b && b <= c)
            {
                for (int i = 0; i < 3; i++) arr[i] *= arr[i];
            }

            else if (a > b && b > c)
            {
                int m = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (arr[i] > m) m = arr[i];
                    arr[i] = m;
                }
            }

            else
            {
                for (int i = 0; i < 3; i++) arr[i] = -arr[i];
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void threety_seven()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c) Console.WriteLine(a * b);
            else if (b > a && c > a) Console.WriteLine(b * c);
            else Console.WriteLine(c * a);
        }

        static void threety_eight()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c && c == a) Console.WriteLine("равносторонний");
            else if (a == b || c == a || b == c) Console.WriteLine("равнобедренный");
            else if ((Math.Sqrt(a * a + b * b) == c)) Console.WriteLine("прямоугольный");
            else Console.WriteLine("разносторонний");
        }

        static void threety_nine()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (Math.Min(a, b) == a) a = 0;
            else if (Math.Min(a, b) == b) b = 0;
            else { a = 0; b = 0; }
        }

        static void fourty()
        {
            int a, m;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m = a / 10 > a % 10 ? a / 10 : a % 10);
        }

        static void fourty_one()
        {
            int num = 13; //Convert.ToInt32(Console.ReadLine());

            if (num % 13 == 0) Console.WriteLine("число делится на 13");
            else Console.WriteLine("число не делится на 13");
        }

        static void fourty_two()
        {
            Random rand = new Random();

            int secret = rand.Next(1, 5);
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == secret) Console.WriteLine("Вы отгадали");
            else Console.WriteLine("Вы не угадали");
        }

        static void fourty_three()
        {
            Random rand = new Random();

            int secret = rand.Next(1, 5);

            for (int i = 0; i < 3; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == secret) { Console.WriteLine("Вы отгадали"); break; }
                else if (num < secret) Console.WriteLine($"Меньше! Осталось попыток: {2 - i}");
                else Console.WriteLine($"Больше! Осталось попыток {2 - i}");
            }
        }

        static void fourty_four()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            int SumAge = 0;

            if (age > 100)
            {
                Console.WriteLine($"голов - {300 + (SumAge - 100) * 2}, глаз - {(300 + (SumAge - 100) * 2) * 2}");
            }

            else if (age >= 100)
            {
                Console.WriteLine($"голов - {SumAge * 3}, глаз - {(SumAge * 3) * 2}");
            }
        }

        static void fourty_five()
        {
            int height = Convert.ToInt32(Console.ReadLine());
            string eyesColor = Console.ReadLine();

            if (height < 160 && eyesColor == "cyan") Console.WriteLine("Вы мне подойдете");
            else Console.WriteLine("До свидания");
        }

        static void fourty_six()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0) Console.WriteLine("Не бей по своим");
            else if (num <= 28) Console.WriteLine("Недолет");
            else if (num <= 30) Console.WriteLine("Попал");
            else Console.WriteLine("Перелет");
        }

        static void fourty_seven()
        {
            string[] marksString = new string[] { "Это печально", "Кол это кол", "Неуд", "Удов", "Хорошо", "Отлично" };

            Console.WriteLine($"{marksString[Convert.ToInt32(Console.ReadLine())]}");
        }

        static void fourty_eight()
        {
            /////////////////////
        }

        static void fourty_nine()
        {
            string[] soglZ = new string[] { "б", "в", "г", "д", "з", "л", "м", "н", "п", "р", "ж" };
            string[] soglG = new string[] { "к", "п", "с", "т", "ф", "х", "ц", "ч", "ш", "щ" };

            string chr = Console.ReadLine();

            if (soglG.Contains(chr)) Console.WriteLine("глухой согласный");
            else if (soglZ.Contains(chr)) Console.WriteLine("звонкий согласный");
            else Console.WriteLine("гласный");
        }

        static void fivety()
        {
            while (true)
            {
                Console.WriteLine(new DataTable().Compute(Console.ReadLine(), ""));
            }
        }

        static void fivety_one()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"В России - {(1000/409.5)*num}\nВ Англии - {(1000 / 453.592) * num}\nВ Германии, Дании, Исландии - {(1000 / 500) * num}");
        }

        static void fivety_two()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            if(day < 30)
            {
                day += 1;
            }
            else
            {
                if (month<12)
                {
                    month += 1;
                    day = 1;
                }
                else
                {
                    year += 1;
                    day = 1;
                    month = 1;
                }
            }

            Console.WriteLine(day.ToString() + "/" + month.ToString() + "/" + year.ToString());
        }
    }
}
