using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterTree = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = letterOne; i <= letterTwo; i++)
            {
                for (char ii = letterOne; ii <= letterTwo; ii++)
                {
                    for (char iii = letterOne; iii <= letterTwo; iii++)
                    {

                        if (i == letterTree || ii == letterTree || iii == letterTree)
                        {
                            continue;
                        }else
                        {
                            count++;
                            Console.WriteLine($"{i}{ii}{iii}");
                        }
                    }
                }
            }
             Console.WriteLine(count);
        }
    }
}
