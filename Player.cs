using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGIT
{
    public class Player:LivingCreature
    {
        public string Name { set; get; }
        public Location CurrentLocation { set; get; }
        public int Gold;
        public int EXP;
        public int Level;
        public List<PlayerQuest> Quests;
        public List<InventoryItem> Inventory;

        public Player(string name, int currentHP, int maxHP, int gold, int eXP, int level): base (currentHP, maxHP)
        {
            Name = name;
            EXP = eXP;
            Gold = gold;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();  
        }

        public void MoveTo(Location loc)
        {
            CurrentLocation = loc;
        }

        public void MoveNorth()
        {
            if (CurrentLocation.LocationToNorth != null)
            {
                MoveTo(CurrentLocation.LocationToNorth);
            }
            else
            {
                Console.WriteLine("You Can not move north! ");
            }
        }
        public void MoveEast()
        {
            if (CurrentLocation.LocationToEast != null)
            {
                MoveTo(CurrentLocation.LocationToEast);
            }
            else
            {
                Console.WriteLine("You Can not move east! ");
            }
        }

        public void MoveWest()
        {
            if (CurrentLocation.LocationToWest != null)
            {
                MoveTo(CurrentLocation.LocationToWest);
            }
            else
            {
                Console.WriteLine("You Can not move West! ");
            }
        }

        public void MoveSouth()
        {
            if (CurrentLocation.LocationToSouth != null)
            {
                MoveTo(CurrentLocation.LocationToSouth);
            }
            else
            {
                Console.WriteLine("You Can not move South! ");
            }
        }
        public Player()
        {

        }


    }//Class Player
}
