using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            //четем 
            //последния сектор от секторите B-Z  +1ред 
            char lastSector = char.Parse(Console.ReadLine());
            //броя на редовете в първия сектор 
            int numRows = int.Parse(Console.ReadLine());//редове 
            // int rowsSum = numRows;
            //броят на sits на нечет ред  , а на четните + 2 
            int sitsOdd = int.Parse(Console.ReadLine());
            int sitsEven = sitsOdd + 2;
            for (char i = 'A'; i <= lastSector; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j <= numRows; j++)
                {
                    for (char f = 'a'; f <= numRows; f++)
                    {
                        
                    }
                    //отпечатваме резултата 
                    //{сектор}{ред}{място}
                    //броя на всички места 

                }
            }
        }
    }
}
