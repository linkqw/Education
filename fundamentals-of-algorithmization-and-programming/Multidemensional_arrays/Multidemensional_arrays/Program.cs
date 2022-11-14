using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main()
        {
            fourteen();
        }

        static void outs(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] fill(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("enter the item ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        static int[,] randomFill(int[,] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-1, 10);
                }
            }
            return arr;
        }

        static void one()
        {
            Console.Write("input the k num (0<k<11) ");
            int k = int.Parse(Console.ReadLine()) - 1;
            int[,] arr = randomFill(new int[4, 11]);

            int summ = 0, compos = 1;

            for (int i = 0; i < 4; i++)
            {
                summ += arr[i, k];
                compos *= arr[i, k];
            }
            outs(arr);
            Console.WriteLine($"sum - {summ}\ncomposition - {compos}");
        }

        static void two()
        {
            int[,] arr = randomFill(new int[5, 9]);
            int i, sum;

            outs(arr);
            Console.WriteLine();

            //четные столбцы
            for (i = 0, sum = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j+=2)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Сумма четных столбцов " + sum);

            //четные строки
            for (i = 0, sum = 0; i < arr.GetLength(0); i+=2)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Сумма четных строк " + sum);

            //нечетные столбцы
            for (i = 0, sum = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j += 2)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Сумма нечетных столбцов " + sum);

            //нечетные строки
            for (i = 1, sum = 0; i < arr.GetLength(0); i+=2)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Сумма нечетных столбцов " + sum);
        }

        static void three()
        {
            int[,] arr = randomFill(new int[5, 10]);

            int max = int.MinValue, i, j;

            outs(arr);
            Console.WriteLine();

            for (i=0; i<arr.GetLength(0); i++)
            {
                for (j = 0, max = 0; j<arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max) max = arr[i, j];
                }
                Console.Write(max + " ");
            }
        }

        static void four()
        {
            int[,] arr = randomFill(new int[5, 10]);

            int[] sumOfRows = new int[arr.GetLength(0)];

            int count, i, j;

            outs(arr);

            for (i = 0; i<arr.GetLength(0); i++)
            {
                for (j = 0; j<arr.GetLength(1); j++)
                {
                    sumOfRows[i] += arr[i, j];
                }
            }

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0, count = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > sumOfRows[i]/arr.GetLength(0))
                    {
                        count++;
                    }
                }
                Console.Write(count + " ");
            }
        }

        static void five()
        {
            int[,] arr = randomFill(new int[5, 10]);
            int[,] toChange = new int[arr.GetLength(0), 4];

            int j, i;

            outs(arr);

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] >= toChange[i, 0])
                    {
                        toChange[i, 0] = arr[i, j];
                        toChange[i, 2] = j;
                    }
                    else if (arr[i, j] <= toChange[i, 1])
                    {
                        toChange[i, 1] = arr[i, j];
                        toChange[i, 3] = j;
                    }
                }
                arr[i, toChange[i, 2]] = toChange[i, 1];
                arr[i, toChange[i, 3]] = toChange[i, 0];
            }

            outs(arr);
        }

        static void six()
        {
            int[,] arr = randomFill(new int[5, 10]);
            int[] res = new int[2] {int.MaxValue, 0};

            int j, i, summ;

            outs(arr);

            for (i = 0; i < arr.GetLength(0); i++)
            {
                summ = 0;

                for (j = 0; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];
                }
                
                if (res[0] > summ)
                {
                    res[0] = summ;
                    res[1] = i;
                }
            }
            Console.WriteLine(string.Join(", ", res));
        }

        static void seven()
        {
            int[,] arr = randomFill(new int[5, 10]);
            int[] res = new int[arr.GetLength(0)];

            int j, i;

            outs(arr);

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > res[i]) res[i] = arr[i, j];
                }
            }
            Console.WriteLine(res.Min());
        }

        static void eight()
        {
            int[,] arr = randomFill(new int[5, 10]);

            int j, i, pos, neg;

            outs(arr);

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0, pos=0, neg=0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0) pos++;
                    else if (arr[i, j] < 0) neg++;
                }
                if (pos == neg) break;
                else if (i == arr.GetLength(0) - 1) i = 0;
            }

            Console.WriteLine(i);
        }

        static void nine()
        {
            int[,] arr = randomFill(new int[5, 10]);

            int j, i, pos;

            outs(arr);

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0, pos = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] >= 0) pos++;
                }
                if (pos == j) break;
                else if (i==arr.GetLength(0)-1) i = 0;
            }

            Console.WriteLine(i);
        }

        static void ten()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] arr = randomFill(new int[M, N]);
            int[] checkForSame = new int[arr.GetLength(1)];
            int sames=0, res=0;

            int j, i;

            outs(arr);

            for (i = 0; i < 1; i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    checkForSame[j] = arr[i, j];
                }
            }

            for (i = 1; i < arr.GetLength(0); i++)
            {
                for (j = 0, sames = 0; j < arr.GetLength(1); j++)
                {
                    if (checkForSame.Contains(arr[i, j])) sames++;
                }
                if (sames == j)
                {
                    res++;
                }
            }
            Console.WriteLine("Найдено " + res + " совпадений");
        }

        static void eleven()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] arr = randomFill(new int[M, N]);
            outs(arr);
            int res = 0;

            for (int i = 0; i < M; i++)
            {
                int[] mid = new int[N];
                for (int j = 0; j<N; j++)
                {
                    mid[j] = arr[i,j];
                }
                if (N == mid.Distinct().ToArray().Length)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }

        static void twelve()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] arr = randomFill(new int[M, N]);
            outs(arr);
            int[] res = new int[M];

            for (int i = 0; i < M; i++)
            {
                int[] mid = new int[N];
                for (int j = 0; j < N; j++)
                {
                    mid[j] = arr[i, j];
                }
                res[i] = mid.Distinct().ToArray().Length;
            }
            Console.WriteLine(res.Max());
        }

        static void threeteen()
        {
            int M = int.Parse(Console.ReadLine());

            int[,] arr = randomFill(new int[M, M]);
            int generalSum = 0;
            int secondSum = 0;

            outs(arr);

            for (int i = 0; i<M; i++)
            {
                generalSum += arr[i, i];
            }
            Console.WriteLine("сумма главной диагонали - " + generalSum);

            for (int i = 0; i < M; i++)
            {
                secondSum += arr[i, arr.GetLength(0) - i - 1];
            }
            Console.WriteLine("сумма побочной диагонали - " + secondSum);
        }

        static void fourteen()
        {
            int M = int.Parse(Console.ReadLine());

            int[,] arr = randomFill(new int[M, M]);
            outs(arr);
            int[] resH = new int[(arr.GetLength(0) - 2)];
            int[] resV = new int[(arr.GetLength(0) - 2)];

            for (int d = 1; d<=arr.GetLength(0)-2; d++)
            {
                int firstSum = 0;
                int secondSum = 0;
                for (int i = 0; i<M; i++)
                {
                    try
                    {
                        firstSum += arr[i, i + d];
                        secondSum += arr[i + d, i];
                    }
                    catch{}
                }
                resH[d-1] = firstSum;
                resV[d-1] = secondSum;
            }
            Console.WriteLine("");
            Console.WriteLine("Выше главной диагонали - " + string.Join(", ", resH));
            Console.WriteLine("Ниже главной диагонали - " + string.Join(", ", resV));
        }

        static void fiveteen()
        {

        }
    }
}