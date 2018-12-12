using System;
using System.Collections.Generic;
using System.Text;

namespace RPGIT
{
    public class Weapon : Item
    {
        public int MaxDam;
        public int MinDam;

        public Weapon(int ID, string name, string NamePlural, int minDam, int maxDam):base(ID, name, NamePlural)
        {
            MaxDam = maxDam;
            MinDam = minDam; 
        }
    }
}
