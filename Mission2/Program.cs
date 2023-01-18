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

            // Gets number of rolls from user
            short rolls = Convert.ToInt16(Console.ReadLine());

            // Runs the dice roll method
            sr.RollDice(rolls);
        }
    }
}

