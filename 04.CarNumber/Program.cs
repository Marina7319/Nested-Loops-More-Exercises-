using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //започва с четна и завършва с нечетна 
            //започва с нечетна и завършва с четна 
            //първата цифра > последната цифра 
            //сумата от вторат и третата цифра = четно число 
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            //изчисляване на възможните комбинации 
            for (int i = numOne; i <= numTwo; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9)
                {
                    for (int j = numOne; j <= numTwo; j++)
                    {
                        if (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9)
                        {
                            for (int k = numOne; k <= numTwo; k++)
                            {
                                if (k == 1 || k == 2 || k == 3 || k == 4 || k == 5 || k == 6 || k == 7 || k == 8 || k == 9)
                                {
                                    for (int e = numOne; e <= numTwo; e++)
                                    {
                                        if (e == 1 || e == 2 || e == 3 || e == 4 || e == 5 || e == 6 || e == 7 || e == 8 || e == 9)
                                        {
                                            if (i > e)
                                            {
                                                if ((j + k) % 2 == 0)
                                                {
                                                    if (i % 2 == 0 && e % 2 != 0)
                                                    {
                                                        Console.Write($"{i}{j}{k}{e} ");
                                                    }
                                                    if (i % 2 != 0 && e % 2 == 0)
                                                    {
                                                        Console.Write($"{i}{j}{k}{e} ");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            //Output : 4333 4353 4443 4533 4553 5334 5354 5444 5534 5554
                        }
                    }
                }
            }
        }
    }
}
