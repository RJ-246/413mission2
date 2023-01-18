using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateRolls sr = new SimulateRolls();
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            short rolls = Convert.ToInt16(Console.ReadLine());
            sr.RollDice(rolls);
        }
    }
}

