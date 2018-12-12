using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGIT
{
    public static class GameEngine
    {
        public static string Version = "0.0.2";
        public static void Initialize()
        {
            Console.WriteLine("Initializing Game Engine: " + Version);

            Console.WriteLine("\n\nWelcome to the world of " + World.WorldName);

            Console.WriteLine();
            
        }
        public static void DeBugList()
        {
            /*
            Console.WriteLine("*********************************");
            World.ListItems();
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            World.ListLocations();
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            World.ListMonsters();
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            World.ListQuests();
            Console.WriteLine("*********************************");
            */
        }

    }
}
