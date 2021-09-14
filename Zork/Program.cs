//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {

        private static string Location //private static string Location => Rooms[LocationColumn];
        {
            get
            {
                return Rooms[LocationRow,LocationColumn];          //Properties are known as attributes. It describes the class. For example a pizza class would have the toppings in it, size etc.
                 
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");


            //Commands command = Commands.UNKNOWN;

            string outputString=""; 
           
            while (true)
                
                 

            {

                Console.Write($"{Location} \n");  //\N make a new line rather than a < 
                Commands command = ToCommand(Console.ReadLine().Trim());
                if (command == Commands.QUIT)//you have loops in loops. 
                {
                    break;
                }

               // Console.WriteLine(CurrentRoom);
               // Console.Write(">");
               // command = ToCommand(Console.ReadLine().Trim());
                
                switch (command) //This segment takes your commands from commands.cs and puts a reponse which is dictated below.

                   
                
                
                
                
                {

                    case Commands.LOOK:
                    outputString = "This is an open field west of a white house, with a boarded front door. A Rubber mat saying 'Welcome to Zork! lies by the door.";
                    break;

                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." :"The way is shut!";




                   //   if (Move(command))
                   //   {
                   //       outputString = $"You moved {command}.";
                    //  }
                    //  else
                   //   {
                   //       outputString = "The way is shut!";
                   //   }

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
           
            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;            // <-- This is an Expression Bodied Method  //
        }
        
        
        private static string[,] Rooms =
        {
            {"Rocky Trail", "South of House","Canyon View"},
            {"Forest","West of House","Behind House" },       
            {"Dense Woods", "North of House", "Clearing" }

        };                 //initiallizer list  (Makes an array of 5 rooms)         ZORK 2.1

      //  private static readonly List<Commands> Directions = new List<Commands>
      //  { Commands.NORTH,
       //   Commands.SOUTH,
        //  Commands.EAST,
        //  Commands.WEST
        //};
        //private static (int Row, int Column) Location = (1, 1);

        private static int LocationColumn = 1; //ints are used to access the array. Aka forest would be assigned to a int     Rooms and Locationcolumn are known as fields
        private static int LocationRow = 1;
        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when LocationRow < Rooms.GetLength(0) - 1:
                    LocationRow++;
                    didMove = true;
                    break;

                case Commands.SOUTH when LocationRow > 0:
                    LocationRow--;
                    didMove = true;  //whens can only be in switches.
                    break;

                    

                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1:
                    LocationColumn++;
                    didMove = true;
                    break;
               
                case Commands.WEST when LocationColumn > 0:
                 LocationColumn--;
                  didMove = true;  //whens can only be in switches.
                    break;
               
                
            }
            
            return didMove;
        }
    }
}//


