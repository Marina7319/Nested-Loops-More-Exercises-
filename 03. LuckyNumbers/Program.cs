using System;

namespace _03._LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int numOne = 0;
            int numTwo = 0;
            int numTree = 0;
            int numFour = 0;
            for (int i = 1; i < N; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9)
                {
                    numOne = i;
                    for (int j = 1; j < N; j++)
                    {
                        if (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9)
                        {
                            numTwo = j;
                            for (int k = 1; k < N; k++)
                            {
                                if (k == 1 || k == 2 || k == 3 || k == 4 || k == 5 || k == 6 || k == 7 || k == 8 || k == 9)
                                {
                                    numTree = k;
                                    for (int h = 1; h < N; h++)
                                    {
                                        if (h == 1 || h == 2 || h == 3 || h == 4 || h == 5 || h == 6 || h == 7 || h == 8 || h == 9)
                                        {
                                            numFour = h;
                                            if (N % (numOne + numTwo) == 0 && N % (numTree + numFour) == 0 )
                                            {
                                                if ((numOne + numTwo) == (numTree + numFour))
                                                {
                                                    Console.Write($"{numOne}{numTwo}{numTree}{numFour} ");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}





