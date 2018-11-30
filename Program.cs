using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimRPG
    //Devyn Kinison (AM) 2017
{
    class Program
    {
        private static Player _Player = new Player();



        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _Player.Name = "Fred"; 
            Console.ReadLine();
        }
    }
}
