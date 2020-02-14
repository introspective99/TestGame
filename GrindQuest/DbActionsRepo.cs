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
        public void Save()
        {
            context.SaveChanges();
        }

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
