// Author: Franchesca Guerra
// Date: 28/09/20
// Comments: This C# console application code demonstrate the use of methods after getting input from a user. 


using System;
using System.Dynamic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        private const string V = "  +  ";


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your real name");
            String RealName;
            RealName = Console.ReadLine();
        

            try
            {

                Console.WriteLine();
                Console.WriteLine("Hello " + RealName + " Go Bucs!");
             
               


            }
            catch
            {
                Console.WriteLine("You must enter a name to continue");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);

            }

        }
      
    }
    
}

