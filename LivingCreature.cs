using System;
using System.Collections.Generic;
using System.Text;

namespace RPGIT
{
    public class LivingCreature
    {
        public int CurrentHP;
        public int MaxHP;

        public LivingCreature(int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }

        public LivingCreature()
        {

        }
    }
}
