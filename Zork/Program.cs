//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");


            Commands command = Commands.UNKNOWN;

            string outputString=""; 
           
            while (command != Commands.QUIT)
                
                 

            {
                Console.Write(">");
                command = ToCommand(Console.ReadLine().Trim());


                
                switch (command) //This segment takes your commands from commands.cs and puts a reponse which is dictated below.

                   
                
                
                
                
                {

                    case Commands.LOOK:
                    outputString = "This is an open field west of a white house, with a boarded front door. A Rubber mat saying 'Welcome to Zork! lies by the door.";
                    break;

                    case Commands.NORTH:
                        outputString = "You moved NORTH";
                        break;

                    case Commands.EAST:
                        outputString = "You moved EAST";
                        break;

                    case Commands.SOUTH:
                        outputString = "You moved SOUTH";
                        break;

                        case Commands.WEST:
                        outputString = "You moved WEST";
                        break;

                    case Commands.UNKNOWN:
                        outputString = "Unknown command";
                        break;

                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;
                        



                }


            Console.WriteLine(outputString);
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


