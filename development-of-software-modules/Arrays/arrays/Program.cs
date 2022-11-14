using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main()
        {
            
        }

        static int[] fill(int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write("enter the item ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void one()
        {
            int[] A = new int[20];
            int size = 0;

            for (int i = 0; i<A.Length; i++)
            {
                if ((A[i] = int.Parse(Console.ReadLine())) <= 888)
                {
                    size += 1;
                }
            }

            int[] B = new int[size];

            for (int i = 0, j = 0; j < size; i++)
            {
                if (A[i] <= 888)
                {
                    B[j] = A[i];
                    j += 1;
                }
            }

            Array.Sort(B);
            Array.Reverse(B);

            Console.WriteLine(string.Join(", ", A));
            Console.WriteLine(string.Join(", ", B));
        }

        static void two()
        {
            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();
            Array.Sort(inputArr);
            Array.Reverse(inputArr);

            Console.WriteLine(string.Join("", inputArr));
        }

        static void threeOnList()
        {
            Console.Write("enter the N num ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("enter the M num ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("enter the K num ");
            int K = int.Parse(Console.ReadLine());

            int[] A = fill(new int[N]);
            Console.WriteLine();
            int[] B = fill(new int[M]);

            List<int> res = new List<int>(A);

            for (int i = 0; i<B.Length; i++)
            {
                if (B[i] % K == 0) res.Add(B[i]);
            }

            Console.WriteLine(string.Join(", ", res));
        }

        static void four()
        {
            Console.Write("enter the N num ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("enter the M num ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = fill(new int[N]);
            Console.WriteLine();
            int[] B = fill(new int[M]);

            int j = 0;

            decimal size = Math.Round((decimal)A.Length / 2 + B.Length / 2);

            int[] C = new int[Convert.ToInt32(size)];

            for (int i = 0; i<A.Length; i+=2)
            {
                C[j] = A[i];
                j++;
            }

            for (int i = 0; i < B.Length; i += 2)
            {
                C[j] = B[i];
                j++;
            }

            Console.WriteLine(string.Join(", ", C));
        }

        static void five()
        {
            
            Console.Write("enter the N num ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("enter the M num ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = fill(new int[N]);
            Console.WriteLine();
            int[] B = fill(new int[M]);

            int j = 0;
            decimal size = Math.Round((decimal)A.Length / 2 + B.Length / 2);

            int[] C = new int[Convert.ToInt32(size)];

            for (int i = 0; i < A.Length; i += 2)
            {
                C[j] = A[i];
                j++;
            }

            for (int i = 1; i < B.Length; i += 2)
            {
                C[j] = B[i];
                j++;
            }

            Console.WriteLine(string.Join(", ", C));
        }
    }
}
