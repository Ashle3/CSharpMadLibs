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
            Console.WriteLine("1. Sentence 1");
            Console.WriteLine("2. Sentence 2");
            Console.WriteLine("3. Sentence 3");
            Console.WriteLine("4. Exit program");
            Console.WriteLine();
        }
        static void Story1(string timeofDay, string adjective1, string fname, string lname, string verb, string place)
        {
            //Puts together the sentence for option 1.
            Console.WriteLine();
            Console.WriteLine("Your sentence is: ");
            Console.WriteLine("One "+ timeofDay+ ", "+ adjective1+ " "+ fname+ " "+ lname+ " was "+ verb+ " in the "+ place+ ".");
            Console.WriteLine();
        }
        static void Story2(string exclamation, string relative, string number, string party, string time)
        {
            //Puts together the sentence for option 2.
            Console.WriteLine();
            Console.WriteLine("Your sentence is: ");
            Console.WriteLine(exclamation+"! "+ "I completely forgot about my " +  relative + "'s " + number + "th " +  party + "! It's happening in " + time + ".");
            Console.WriteLine();
        }
        static void Story3(string verb, string transport, string relative, string name, string adjective, string place)
        {
            //Puts togeter the sentence for option 3.
            Console.WriteLine();
            Console.WriteLine("Your sentence is: ");
            Console.WriteLine("I am currently " + verb + " in a " + transport + " to go visit my " + relative + ", " + name + ", in the " + adjective + " hills of " + place + ".");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mad Libs Sentences!");
            Console.WriteLine("Make your own hilarious sentences with Mad Libs!");
            Console.WriteLine();
            bool programIsRunning = true;
            while (programIsRunning == true)
            {
                Console.WriteLine("Please select a story by typing in its number (1,2,3, or 4 to exit): ");
                PrintOptions();
                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have chosen Sentence 1");
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

                    Story1(timeOfDay, adjective1, fname, lname, verb, place);
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have chosen Sentence 2");
                    Console.WriteLine();

                    Console.WriteLine("Please fill in the following prompts: ");
                    Console.WriteLine();

                    Console.WriteLine("Exclamation: ");
                    string exclamation = Console.ReadLine();

                    Console.WriteLine("Relative: ");
                    string relative = Console.ReadLine();

                    Console.WriteLine("Number: ");
                    string number = Console.ReadLine();

                    Console.WriteLine("Event: ");
                    string party = Console.ReadLine();

                    Console.WriteLine("Length of time: ");
                    string time = Console.ReadLine();

                    Story2(exclamation, relative, number, party, time);
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have chosen Sentence 3.");
                    Console.WriteLine();

                    Console.WriteLine("Please fill in the following prompts: ");
                    Console.WriteLine();

                    Console.WriteLine("Verb ending in -ing: ");
                    string verb = Console.ReadLine();

                    Console.WriteLine("Mode of transportation: ");
                    string transport = Console.ReadLine();

                    Console.WriteLine("Relative: ");
                    string relative = Console.ReadLine();

                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Adjective: ");
                    string adjective = Console.ReadLine();

                    Console.WriteLine("State, city, or Country: ");
                    string place = Console.ReadLine();

                    Story3(verb, transport, relative, name, adjective, place);
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for playing!");
                    programIsRunning = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Number");
                    Console.WriteLine();
                }
            }
            //Written so the program doesn't terminate automatically
            Console.ReadLine();
        }
    }
}
