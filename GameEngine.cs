﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimRPG
{
    public static class GameEngine
    {
        public static string Version = "0.0.1";
        public static void Initialize()
        {
            Console.WriteLine("Initializing Game Engine: " + Version);

            Console.WriteLine("\n\nWelcome to the world of " + World.WorldName);

            Console.WriteLine();
        }

    }
}
