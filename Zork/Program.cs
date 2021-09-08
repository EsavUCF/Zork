//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");


            //Commands command = Commands.UNKNOWN;

            string outputString=""; 
           
            while (true)
                
                 

            {

                Console.Write($"{Rooms[LocationColumn]} \n");  //\N make a new line rather than a < 
                Commands command = ToCommand(Console.ReadLine().Trim());
                if (command == Commands.QUIT)//you have loops in loops. 
                {
                    break;
                }


                
                switch (command) //This segment takes your commands from commands.cs and puts a reponse which is dictated below.

                   
                
                
                
                
                {

                    case Commands.LOOK:
                    outputString = "This is an open field west of a white house, with a boarded front door. A Rubber mat saying 'Welcome to Zork! lies by the door.";
                    break;

                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.NORTH:
                    case Commands.EAST:
                    case Commands.SOUTH:
                    case Commands.WEST:
                     outputString = $"You moved {command}";
                        break;

                    default:
                        outputString = "Unknown command";
                        break;

                   
                        



                }


            Console.WriteLine(outputString);
            }
            Console.WriteLine("Finished");


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
        private static string[] Rooms = {"Forest","West of House ","Behind House","Clearing","Canyon View" };                 //initiallizer list  (Makes an array of 5 rooms)         ZORK 2.1
        private static int LocationColumn = 1; //ints are used to access the array. Aka forest would be assigned to a int

    }
}


