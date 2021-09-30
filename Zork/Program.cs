using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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



        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }

        private enum Fields
        {
            Name = 0,
            Description
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            const string defaultRoomsFilename = "Rooms.json";

            string roomsFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFilename);
            InitializeRoomDescriptions(defaultRoomsFilename);

            Room previousRoom = null; //Refer to 3.2 page and notes on Null.
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom);//between here
                if (previousRoom != CurrentRoom) //3.2
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }



                Console.Write(">");
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
                //

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
            {new Room("Rocky Trail"), new Room ("South of House"), new Room ("Canyon View") },        //Refer to 3.1 page
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
        private static readonly Dictionary<string, Room> RoomMap; //4.1 Moved here. 


        static Program()
        {
            RoomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomMap[room.Name] = room;
            }
        }


        private static void InitializeRoomDescriptions(string roomsFilename)   //4.1
        { 
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap.Add(room.Name, room);
                roomMap[room.Name] = room;



            }

            string roomsJsonString = File.ReadAllText(roomsFilename);
            Room[] rooms = JsonConvert.DeserializeObject<Room[]>(roomsJsonString);
            foreach (Room room in rooms)
            {
                roomMap[room.Name].Description = room.Description;
            }


        }
    }
}
