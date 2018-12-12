using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGIT
{
   public class Location
    {
        public int ID;
        public string Name;
        public string Description;
        public Item ItemRequieredToEnter;
        public Quest QuestAvailableHere;
        public Monster MonsterLivingHere;
        public Location LocationToNorth;
        public Location LocationToEast;
        public Location LocationToSouth;
        public Location LocationToWest;


        //Constructor
        public Location(int iD, string name, string description, Item itemRTE = null, Quest qAH = null, Monster monsterLivingHere = null) 
        {
            ID = iD;
            Name = name;
            Description = description;

        }



    }
}
