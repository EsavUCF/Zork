namespace Zork
{
    public class Room
    {

        public string Name { get; }

        public string Description { get; set; }


       
        public Room(string name, string description = "")

        {
            Name = name;
            Description = Description;

        }

        public override string ToString() => Name;
    }

}