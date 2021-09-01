//Note, the notes in my pushes are for me, as I'm still learning. If I should not have these. Please let me know ASAP. 
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine().Trim();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);


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


