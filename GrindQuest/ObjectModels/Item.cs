using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrindQuest.ObjectModels
{
    public class Item
    {
        //Primary key for the tables generated against this object. 
        public int ItemId { get; set; }
        public int ItemGoldValue { get; set; }
        //the intention is for the max stack of some items to be increased to allow for unlocking upgrades.
        public int ItemMaxStack { get; set; }
        //Item name is used in a lot of methods to locate entries in tables, will need to validate the spelling somehow later on.
        public string ItemName { get; set; }
        //Still not sure how to handle item effects, will likely be updated when I implement stats.
        public string ItemEffect { get; set; }
        //Not sure this field is necessary anymore, potentially use for it to be the determining factor for random shopkeeper inventories
        //based on a specific type, like an alchemist or restuaraunt.
        public string ItemType { get; set; }
    }
}
