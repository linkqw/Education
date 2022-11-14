using System;
using System.Collections.Generic;
using System.IO;

namespace task
{
    class Program
    {
        static void Main()
        {
            //one();
            //two();
            //three();
            //eight();
            //nine();
            //ten();
            //eleven();
            //fourteen();
            //threeteen();
            //fiveteen();
            //seventeen();
            eighteen();
        }

        static int[] fillArray(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter the item ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int[] checkTheNear(int first, int second, int[] res, int R)
        {
            if (Math.Abs((R - (first + second))) < Math.Abs((R - (res[0] + res[1]))))
            {
                return new int[] { first, second };
            }

            else
            {
                return res;
            }

        }

        static void one()
        {
            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            Console.WriteLine(string.Join(", ", arr.Reverse()));
        }

        static void two()
        {
            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            Console.WriteLine("even: ");
            for (int i = 0; i < n; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("odd: ");
            for (int i = 1; i < n; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void three()
        {
            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            for (int i = 0; i < n; i++)
            {
                if (arr[0] < arr[i] && arr[i] < arr[9])
                {
                    Console.WriteLine(Array.IndexOf(arr, arr[i]));
                    break;
                }
                else if (i == n - 1)
                {
                    Console.WriteLine(0);
                }
            }
        }

        static void four()
        {
            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] % 2 == 0) arr[i] += arr[0];
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        static void five()
        {
            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] % 2 == 0) Console.WriteLine($"this index is even: {arr[i]}");
            }
            Console.WriteLine();
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] % 2 != 0) Console.WriteLine($"this index is odd: {arr[i]}");
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        static void six()
        {
            int n = 10;

            int[] arr = fillArray(n, new int[n]);

            int temp = arr[0];
            arr[0] = arr[n - 1];
            arr[n - 1] = temp;

            Console.WriteLine(string.Join(", ", arr));
        }

        static void seven()
        {
            int n = 10;

            int[] arr = fillArray(n, new int[n]);

            for (int i = 1; i < 0; i++)
            {
                if (arr[i] > 0) arr[i] = arr.Min();
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        static void eight()
        {
            int n = 10;

            int[] arr = fillArray(n, new int[n]);
            List<int> res = new List<int>();

            int indexOfMin = Array.IndexOf(arr, arr.Min());
            int indexOfMax = Array.IndexOf(arr, arr.Max());

            if (indexOfMin < indexOfMax)
            {
                for (int i = indexOfMax; i >= indexOfMin; i--)
                {
                    res.Add(arr[i]);
                }
            }
            else if (indexOfMin > indexOfMax)
            {
                for (int i = indexOfMin; i >= indexOfMax; i--)
                {
                    res.Add(arr[i]);
                }
            }
            Console.WriteLine(string.Join(", ", res));
        }

        static void nine()
        {
            int n = 10;

            int[] arr = fillArray(n, new int[n]);
            int last = arr[arr.GetUpperBound(0)];

            for (int i = arr.GetUpperBound(0) - 1; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[0] = last;
            Console.WriteLine(string.Join(", ", arr));
        }

        static void ten()
        {
            Console.Write("enter the k number (0<k<5) ");
            int k = int.Parse(Console.ReadLine());

            if (!(0 < k && k < 5))
            {
                Console.WriteLine("k isnt match the condition");
            }
            else
            {
                Console.Write("enter the number of array items ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = fillArray(n, new int[n]);

                for (int j = 0; j < k; j++)
                {
                    int last = arr[arr.GetUpperBound(0)];
                    for (int i = arr.GetUpperBound(0) - 1; i >= 0; i--)
                    {
                        arr[i + 1] = arr[i];
                    }
                    arr[0] = last;
                }

                Console.WriteLine(string.Join(", ", arr));
            }
        }

        static void eleven()
        {
            Console.Write("enter the R number ");
            int R = int.Parse(Console.ReadLine());

            Console.Write("enter the number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);
            int answ = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs((R - arr[i])) < Math.Abs((R - answ)))
                {
                    answ = arr[i];
                }
            }

            Console.WriteLine(answ);
        }

        static void twelve()
        {
            Console.Write("enter the R number ");
            int R = int.Parse(Console.ReadLine());

            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);
            int[] res = new int[2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res = checkTheNear(arr[i], arr[j], res, R);
                }
            }
            Console.WriteLine(string.Join(", ", res));
        }

        static void threeteen()
        {
            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);
            int[] res = new int[2] { arr[0], arr[1] };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) < Math.Abs(res[0] - res[1]))
                    {
                        if (Array.IndexOf(arr, arr[i]) != Array.IndexOf(arr, arr[j]))
                        {
                            res[0] = arr[i];
                            res[1] = arr[j];
                        }
                    }
                }
            }
            Console.WriteLine(Array.IndexOf(arr, res[0]) + " " + Array.IndexOf(arr, res[1]));
        }

        static void fourteen()
        {
            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            List<int> listArr = arr.ToList<int>();
            List<int> res = new List<int>();

            foreach (int item in arr)
            {
                int repeats = 0;

                for (int i = 0; i < n; i++)
                    if (item == listArr[i])
                        repeats++;

                res.Add(repeats);
            }

            Console.WriteLine(res.Max());
        }

        static void fiveteen()
        {
            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            List<int> listArr = arr.ToList<int>();

            foreach (int item in arr)
            {
                int repeats = 0;

                for (int i = 0; i < listArr.Count - 1; i++)
                    if (item == listArr[i])
                        repeats++;

                if (repeats < 2)
                {
                    listArr.Remove(item);
                }
            }
            Console.WriteLine(String.Join(", ", listArr));
        }

        static void sexteen()
        {
            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            List<int> listArr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    listArr.Add(arr[0]);
                    listArr.Add(arr[i]);
                }
                else
                {
                    listArr.Add(arr[i]);
                }
            }
            Console.WriteLine(string.Join(", ", listArr));
        }

        static void seventeen()
        {
            Console.Write("enter number of first array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = fillArray(n, new int[n]);

            Console.Write("enter number of second array items ");
            int n1 = int.Parse(Console.ReadLine());

            int[] arr2 = fillArray(n1, new int[n1]);

            List<int> res = new List<int>();

            foreach(int item in arr1)
            {
                res.Add(item);
            }

            foreach (int item in arr2)
            {
                res.Add(item);
            }

            int[] outs = res.ToArray();
            Array.Sort(outs);
            Console.WriteLine(String.Join(", ", outs));
        }

        static void eighteen()
        {
            Console.Write("enter number of array items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);

            Array.Sort(arr);

            Console.WriteLine(String.Join(", ", arr));
        }

        static void nineteen()
        {
            Console.Write("enter the A number ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("enter the number of B items ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = fillArray(n, new int[n]);
            int answ = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs((A - arr[i])) < Math.Abs((A - answ)))
                {
                    answ = arr[i];
                }
            }

            Console.WriteLine(answ);
        }
    }
}
