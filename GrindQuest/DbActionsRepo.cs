using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public class DbActionsRepo : IDbActionsRepo
    {
        private readonly GameDbContext context;
        public DbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }

        public void InsertItemToItemsMasterDb(Item item)
        {
            context.ItemsMasterTable.Add(item);
        }

        public void RemoveItemFromItemsMasterDb(string itemName)
        {
            List<Item> itemList = context.ItemsMasterTable.ToList();
            foreach(Item i in itemList)
            {
                if(i.ItemName == itemName)
                {
                    context.ItemsMasterTable.Remove(i);
                }
            }
        }
        public void UpdateMaxStackValueOfItemInItemsMasterDb(string itemName, int newMaxStackSize)
        {
            List<Item> itemList = context.ItemsMasterTable.ToList();
            foreach (Item i in itemList)
            {
                if (i.ItemName == itemName)
                {
                    i.ItemMaxStack = newMaxStackSize;
                }
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
