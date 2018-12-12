using System;
using System.Collections.Generic;
using System.Text;

namespace RPGIT
{
    public class HealingPotion : Item
    {
        public int AmountToHeal;

        public HealingPotion(int ID, string name, string NamePlural, int amountToHeal):base (ID, name, NamePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
