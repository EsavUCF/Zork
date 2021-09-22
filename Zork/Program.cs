using System;
using System.Collections.Generic;


namespace Zork
{

    internal class Program
    { 

        public static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            InitializeRoomDescriptions(); //This calls for the descriptions which are below. 
            
            Room previousRoom = null; //3.2 stuff
            Commands command = Commands.UNKNOWN;
            while (command !=Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom);//between here
                if (previousRoom != CurrentRoom) //3.2 stuff Double Check if this is a valid spot (STARTS)
                { 
                    Console.WriteLine(CurrentRoom.Description); //3.2
                    previousRoom = CurrentRoom; //3.2
                }                               //3.2 stuff Double Check if this is a valid spot   (ENDS) 3.2
                Console.Write(">"); //between here
                command = ToCommand(Console.ReadLine().Trim());

                 


                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;


                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST: 
                        if (Move(command) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown Command.");
                        break;



                }
                

            }


        }


        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "invalid direction");
            
            bool isValidMove = true;
            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    isValidMove = false;
                    break;








            }

            return isValidMove;


        }
        private static Commands ToCommand(string commandString) =>
            Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static readonly Room[,] Rooms =
        {
            {new Room("Rocky Trail"), new Room ("South of House"), new Room ("Canyon View") },        //3.1 Stuff
            {new Room ("Forest"), new Room ("West of House"), new Room ("Behind House") },
            {new Room("Dense Woods"), new Room ("North of House"), new Room ("Clearing") }
        };


        private static readonly List<Commands> Directions = new List<Commands>
        {   Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static (int Row, int Column) Location = (1, 1);






        private static void InitializeRoomDescriptions()   //3.1 stuff
        {
            var roomMap = new Dictionary<string, Room>(); //3.2 
            foreach (Room room in Rooms)                  
            {                                             
                roomMap[room.Name] = room;               
            }                                           //3.2 




            roomMap["Rocky Trail"].Description = "You are on a rock-strewn trail."; //Rocky Trail
            roomMap["South of House"].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred. "; //South of House
            roomMap["Canyon View"].Description = "You are at the top of the Great Canyon on its south wall"; //Canyon View

            roomMap["Forest"].Description = "This is a forest, with trees in all directions around you"; //Forest
            roomMap["West of House"].Description = "This is a open field west of a white house, with a boarded front door."; //west of house
            roomMap["Behind House"].Description = "You are behind the white house. In one corner of the house there is a small window that is slightly ajar"; //behind house

            roomMap["Dense Woods"].Description = "This is a dimly lit forest, with large trees all around. To the east there appears to be sunlight"; //Dense Woods
            roomMap["North of House"].Description = "You are facing the north side of a white house. There is no door here and all windows are barred"; //North of house
            roomMap["Clearing"].Description = "You are in a clearing with a forest surrounding you on the west and south";                        //Clearing

        }


       

    }
 




}