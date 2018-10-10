using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userDiceSize;
            int diceSize, dice1, dice2, count = 1;
            Random rnd = new Random();

            //Initiate game
            Console.WriteLine("Welcome to the Grand Circus Casino!  Roll the dice? Y/N");
            string answer1 = Console.ReadLine().ToUpper();

            while (true)
            {
                if (answer1 == "N")
                {
                    break;
                }

                //Ask user to enter the number of sides for a pair of dice
                Console.WriteLine("How many sides should each die have?");
                userDiceSize = Console.ReadLine();
                bool isNumber = int.TryParse(userDiceSize, out diceSize);

                //"Roll" dice, display the results of each
                try
                {
                    dice1 = RollDice(diceSize, rnd);
                    dice2 = RollDice(diceSize, rnd);
                    Console.WriteLine("Roll " + (count++) + ":");
                    Console.WriteLine(dice1);
                    Console.WriteLine(dice2);

                    //Ask the user if they want to roll again
                    Console.WriteLine("Roll again? Y/N");
                    string answer2 = Console.ReadLine().ToUpper();
                    if (answer2 == "N")
                    {
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }   
            } 
        }

        public static int RollDice(int x, Random roll)
            {
                    //roll a pair of dice, number of sides determined by user
                    int dice = roll.Next(1, x);
                    return dice;

            }
        }
    }
