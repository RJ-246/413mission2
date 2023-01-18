using System;
namespace Mission2
{
	public class SimulateRolls
	{
		public void RollDice(short rollNum)
		{
			Random random = new Random();
			int[] rollResults = new int[rollNum];
			int[] rollTotals = new int[11] {0,0,0,0,0,0,0,0,0,0,0};

			for (int i = 0; i < rollResults.Length; i++)
			{
				rollResults[i] = random.Next(2, 13);
			}

			for (int i=0; i < rollResults.Length; i++)
			{
				switch (rollResults[i])
				{
					case 2:
						rollTotals[0] = rollTotals[0] + 1;
						break;
                    case 3:
                        rollTotals[1] = rollTotals[1] + 1;
                        break;
                    case 4:
                        rollTotals[2] = rollTotals[2] + 1;
                        break;
                    case 5:
                        rollTotals[3] = rollTotals[3] + 1;
                        break;
                    case 6:
                        rollTotals[4] = rollTotals[4] + 1;
                        break;
                    case 7:
                        rollTotals[5] = rollTotals[5] + 1;
                        break;
                    case 8:
                        rollTotals[6] = rollTotals[6] + 1;
                        break;
                    case 9:
                        rollTotals[7] = rollTotals[7] + 1;
                        break;
                    case 10:
                        rollTotals[8] = rollTotals[8] + 1;
                        break;
                    case 11:
                        rollTotals[9] = rollTotals[9] + 1;
                        break;
                    case 12:
                        rollTotals[10] = rollTotals[10] + 1;
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Dice Rolling Simulation Results");
            Console.WriteLine("Each '*' represensts 1% of the total number of rolls.");
            Console.WriteLine("Total Number of Rolls = " + rollNum + ".");
            Console.WriteLine();


            for (int i = 2; i < 13; i++)
                {
                string asterisks = "";
                    for (int j = 0; j < ((rollTotals[i -2] / (float)rollNum) * 100); j++)
                    {

                    asterisks = asterisks + "*";
                    }
                    //Console.WriteLine(rollTotals[i - 2] / (float)rollNum);
                    Console.WriteLine(i + ": " + asterisks);
                }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
		}
	}
}

