using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork

{
    public class World
    {
        [JsonIgnore]
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            try
            {
                mRoomsByName = Rooms?.ToDictionary(room => room.Name, room => room);
            }
            catch (Exception e)
            {
                Console.Write($"{e} occured while attempting to create mRoomsByName Dictionary");
            }

            if ( Rooms != null )
            {
                foreach (Room room in Rooms)
                {
                    room.UpdateNeighbors(this);
                }
            }

        }

        public void AddRoom(Room room)
        {
            Rooms?.Add(room);
        }

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

        public static implicit operator World(Game v)
        {
            throw new NotImplementedException();
        }
    }
}
