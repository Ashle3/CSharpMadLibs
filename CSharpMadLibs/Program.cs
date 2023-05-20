using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMadLibs
{
    internal class Program
    {
        static void PrintOptions() //Lists the sentence options
        {
            Console.WriteLine();
            Console.WriteLine("Sentence 1");
            Console.WriteLine("Sentence 2");
            Console.WriteLine("Sentence 3");
            Console.WriteLine();
        }
        static void Story1(string timeofDay, string adjective1, string fname, string lname, string verb, string place)
        {
            Console.WriteLine();
            Console.WriteLine("Your sentence is: ");
            Console.WriteLine("One "+ timeofDay+ ", "+ adjective1+ " "+ fname+ " "+ lname+ " was "+ verb+ " in the "+ place+ ".");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mad Libs Sentences!");
            Console.WriteLine("Make your own hilarious sentences with Mad Libs!");
            Console.WriteLine();
            Console.WriteLine("Please select a story by typing in its number (1,2,or 3): ");
            PrintOptions();
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("You have chosen Story 1");
                Console.WriteLine();

                Console.WriteLine("Please fill in the following prompts: ");
                Console.WriteLine();

                Console.WriteLine("Time of day: ");
                string timeOfDay = Console.ReadLine();

                Console.WriteLine("Adjective: ");
                string adjective1 = Console.ReadLine();

                Console.WriteLine("First name: ");
                string fname = Console.ReadLine();

                Console.WriteLine("Last name: ");
                string lname = Console.ReadLine();

                Console.WriteLine("Verb ending in -ing: ");
                string verb = Console.ReadLine();

                Console.WriteLine("Place: ");
                string place = Console.ReadLine();

                Story1(timeOfDay,adjective1,fname,lname,verb,place);
            }

            //Written so the program doesn't terminate
            Console.ReadLine();
        }
    }
}
