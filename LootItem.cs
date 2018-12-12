using System;
using System.Collections.Generic;
using System.Text;

namespace RPGIT
{
    public class LootItem
    {
        public Item Details;
        public int Droppercentage;
        public bool IsDefultItem;

        public LootItem(Item details, int droppercentage, bool isDefultItem)
        {
            Details = details;
            Droppercentage = droppercentage;
            IsDefultItem = isDefultItem;
        }
        public LootItem()
        {

        }
    }
}
