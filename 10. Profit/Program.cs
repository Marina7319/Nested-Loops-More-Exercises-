using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine()); //1лв.
            int twoLev = int.Parse(Console.ReadLine()); //2лв
            int fiveLev = int.Parse(Console.ReadLine()); //5лв
            int sumPossitiveNumber = int.Parse(Console.ReadLine());// 
            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLev; j++)
                {
                    for (int k = 0; k <= fiveLev; k++)
                    { 
                        if((i * 1 + j * 2 + k * 5 )
                            == sumPossitiveNumber)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sumPossitiveNumber} lv.");                       
                        }
                    }
                }
            }
        }
    }
}
