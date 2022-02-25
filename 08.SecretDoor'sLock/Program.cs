using System;

namespace _08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numTree = int.Parse(Console.ReadLine());
            int numFirst = 0;
            int numSecond = 0;
            int numThird = 0;
            bool prime = true;
            for (int i = 0; i <= numOne; i++)
            {
                if (i == 2 || i == 4 || i == 6 || i == 8)
                {
                    for (int j = 2; j <= numTwo; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int ii = 0; ii <= numTree; ii++)
                            {
                                if (ii == 2 || ii == 4 || ii == 6 || ii == 8)
                                {
                                    Console.WriteLine($"{i} {j} {ii}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
