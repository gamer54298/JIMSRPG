using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGIT
    //Devyn Kinison (AM) 2017
{
    class Program
    {
        private static Player _Player = new Player("Fred the Fearless", 10, 10, 20, 0, 1);




        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _Player.MoveTo(World.LocationByID(World.LOCATION_ID_HOME));


            while (true)
            {
                Console.Write("What would you like to do: ");
                string UserInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(UserInput))
                {
                    continue;
                }
                string cleanedInput = UserInput.ToLower();
                if (cleanedInput == "Exit")
                {
                    break;
                }
                ParseInput(cleanedInput);
            }

        }
            public static void ParseInput(string input)
            {
            if (input.Contains("help"))
            {
                Console.WriteLine("Help is coming later.. Stayed tuned.");
            } else if (input.Contains("look")) {

                DisplayCurrentLocation();
                    }

            else if (input.Contains("north")) {
                _Player.MoveNorth();
            }else if(input.Contains("east")){
                _Player.MoveEast();
            }else if (input.Contains("west"))
            {
                _Player.MoveWest();
            }else if (input.Contains("south"))
            {
                _Player.MoveSouth();
            }
            else
            {
                Console.WriteLine("I don't under stand, Sorry!");
            }


        }//Parsed

        private static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", _Player.CurrentLocation.Name);
            if (_Player.CurrentLocation.Description != "") ;
            {
                Console.Write("\t{0}", _Player.CurrentLocation.Description);
            }
        }
        
    }
}
