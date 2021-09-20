using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maths Calculation");
            Calculation calc = new Calculation();
            Console.WriteLine("Addition : " + calc.Add(3, 7));
            Console.ReadLine();
        }
    }
}
