//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

           while(ToCommand != Commands.QUIT) //Doublecheck at home.


            string inputString = Console.ReadLine().Trim();
            Commands command = ToCommand(inputString.Trim().ToUpper());
           switch (command)
            {
                case Commands.QUIT:
                outputString = "Thanks for playing!"
                break;

                case Commands.LOOK:
                outputString = "This is an open field west of a white house, with a boarded front door. /nA Rubber mat saying "Welcome to Zork!"
                break;

                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    outputString = $"You moved {command.ToString()}";
                    break;
            }

        }
        private static Commands ToCommand(string commandString)
        {
            // if (Enum.TryParse<Commands>(commandString, true, out Commands result))

            // {
            //  return result;
            //  }

            //   else                                                                                               [ALTERNATE METHOD OF DOING BELOW Try/Catch Block]

            // {

            //    return Commands.UNKNOWN;
            // }
            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;            // <-- This is an Expression Bodied Method  //
        }
    }
}


