using System;

namespace _05._ChallengetheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int male = int.Parse(Console.ReadLine());
            int female = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int sits = tables * 2;
            int count = 0;
            for (int m = 1; m <= male; m++)
            {              
                for (int f = 1; f <= female; f++)
                {
                    Console.Write($"({m} <-> {f}) ");
                    count+=2;
                    if (count == sits)
                    {
                        return;
                    }
                    else
                    {
                       
                    }
                }
            }
            //Output : 2
            //2
            //6
            //(1 <-> 1) (1 <-> 2) (2 <-> 1) (2 <-> 2)
        }
    }
}
