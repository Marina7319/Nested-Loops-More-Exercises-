using System;

namespace _07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABxyBA

            //+1 A
            //>55 => 35 A 

            //B 
            //>96   =>64

            //
            //•	На първия ред a – цяло число в интервала [1 … 1000]
            int a = int.Parse(Console.ReadLine());
            //•	На втория ред b – цяло число в интервала[1 … 1000]
            int b = int.Parse(Console.ReadLine());
            //•	На третия ред максимален брой генерирани пароли – цяло число в интервала[1 … 1000000]
            int maxPasswords = int.Parse(Console.ReadLine());

            //•	A е символ с ASCII стойност в диапазона [35… 55]
            //•	B е символ с ASCII стойност в диапазона[64 … 96]
            //•	x e цяло число в диапазона[1… a] 
            //•	y e цяло число в диапазона[1… b]





        }
    }
}
