//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            //inputstring is a variable
            //ToUpper is a METHOD
            string inputString = Console.ReadLine().Trim(); //Added trim
            inputString = inputString.ToUpper(); //This converts lowercase text commands to upper vise versa. 
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing!");
            }
            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door. /nA rubber mat saying 'Welcome to Zork!' lies by the door.");
            }
            else
            {
                Console.WriteLine("Unrecognized command");
            }
        }
    }

}

