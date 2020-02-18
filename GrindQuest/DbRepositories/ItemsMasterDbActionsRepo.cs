using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public class ItemsMasterDbActionsRepo : IItemsMasterDbActionsRepo
    {
        //Injects the GameDbContext into the actionsRepo so I can create methods for EF without needing a new instance of the DbContext.
        private readonly GameDbContext context;
        public ItemsMasterDbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }

        //self explanatory, inserts an Item to the ItemsMasterDb, I'll need another method for any other tables.
        public void InsertItemToItemsMasterDb(Item item)
        {
            context.ItemsMasterTable.Add(item);
        }
        //Fetches an Item from the ItemsMasterDb that has the specified ItemId, mostly for use by other methods.
        public Item GetItemById(int itemId)
        {
            return context.ItemsMasterTable.FirstOrDefault(p => p.ItemID == itemId);
        }
        public void RemoveItemFromItemsMasterDb(int itemId)
        {
            context.ItemsMasterTable.Remove(GetItemById(itemId));
        }
        
        public void ModifyItemByItemIdFromItemsMasterDb(int itemId, string nameOfColumnToUpdate, Object newValue)
        {
            var foundEntry = GetItemById(itemId);
            foreach(var prop in foundEntry.GetType().GetProperties())
            {
                if(prop.Name == nameOfColumnToUpdate)
                {
                    prop.SetValue(foundEntry, newValue);
                }
            }
        }

        //again self explanatory, pulls from the table and removes whatever you tell it to remove.

        //not sure I need to explain this one.
        public void Save()
        {
            context.SaveChanges();
        }
    }
}


