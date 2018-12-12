using System;
using System.Collections.Generic;
using System.Text;

namespace RPGIT
{
    public class Monster : LivingCreature
    {
        public int ID;
        public string Name;
        public int MaxDam;
        public int RewardEXP;
        public int RewardGold;
        public List<LootItem> LootTable;

        public Monster(int iD, string name, int maxDam, int rewardEXP, int rewardGold, int currentHP, int MaxHP):base(currentHP, MaxHP)
        {
            ID = iD;
            Name = name;
            MaxDam = maxDam;
            RewardEXP = rewardEXP;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
