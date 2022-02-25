using System;

namespace _11._HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            int daysCount = 0;
            for (int i = 1; i <= days; i++)
            {
                for (double j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            evenSum = evenSum + 2.5;
                        }
                        else
                        {
                            evenSum = evenSum + 1;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        if (j % 2 == 0)
                        {
                            oddSum += 1.25;
                        }
                        else
                        {
                            oddSum += 1;
                        }
                    }
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Day: {i} – {oddSum:f2} leva");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Day: {i} – {evenSum:f2} leva");
                }

                //Console.WriteLine($"Total: {(evenSum + oddSum):f2} leva");
            }
            Console.WriteLine($"Total: {(evenSum + oddSum):f2} leva");
        }
    }
}


