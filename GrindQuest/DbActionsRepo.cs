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
        //Injects the GameDbContext into the actionsRepo so I can create methods for EF without needing a new instance of the DbContext.
        private readonly GameDbContext context;
        public DbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }

        //self explanatory, inserts an Item to the ItemsMasterDb, I'll need another method for any other tables.
        public void InsertItemToItemsMasterDb(Item item)
        {
            context.ItemsMasterTable.Add(item);
        }

        //again self explanatory, pulls from the table and removes whatever you tell it to remove.
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
        //not sure I need to explain this one.
        public void Save()
        {
            context.SaveChanges();
        }
        //Nice method that finds and modifies any specified value in and specified column, could use this methodology to 
        //make a table-non-specific method as well, but might be too cluttered for one method.
        public void ModifyItemInItemsMasterDb(string itemName, string valueToUpdate, Object newValue)
        {
            List<Item> itemList = context.ItemsMasterTable.ToList();
            foreach (Item i in itemList)
            {
                if (i.ItemName == itemName)
                {
                    if (newValue.GetType() == typeof(string))
                    {
                        if (valueToUpdate == "ItemName")
                        {
                            i.ItemName = newValue.ToString();
                        }
                        else if (valueToUpdate == "ItemEffect")
                        {
                            i.ItemEffect = newValue.ToString();
                        }
                        else if (valueToUpdate == "ItemType")
                        {
                            i.ItemType = newValue.ToString();
                        }
                    }
                    else if (newValue.GetType() == typeof(int))
                    {
                        i.ItemMaxStack = (Int32)newValue;
                    }
                }
            }
        }
    }
}
