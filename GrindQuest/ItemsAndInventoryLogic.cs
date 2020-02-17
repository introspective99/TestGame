using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    //this class is intended to do Logic around item management and inventory management, as well as being used to populate the ItemsMasterTable
    public class ItemsAndInventoryLogic : IItemsAndInventoryLogic
    {
        //dependency injecting the DbActionsRepo so I don't have to initialise any other classes.
        private readonly IDbActionsRepo _dbActionsRepo;
        public ItemsAndInventoryLogic(IDbActionsRepo actionsRepo)
        {
            _dbActionsRepo = actionsRepo;
        }

        //group of Items to Add or Remove from the ItemsMasterTable
        public List<Item> ItemsToAdd = new List<Item>();
        public List<string> ItemsToRemove = new List<string>();

        public void AddItemsToItemsMasterTable()
        {
            //some example items added for testing
            Item HealthPotion = new Item()
            {
                ItemName = "Health Potion",
                ItemMaxStack = 1,
                ItemEffect = "Restore 10 HP",
                ItemType = "Consumable",
            };
            Item StrengthPotion = new Item()
            {
                ItemName = "Strength Potion",
                ItemMaxStack = 1,
                ItemEffect = "Increases Basic Attack Damage by 3 for 3 turns",
                ItemType = "Consumable"
            };
            Item PepsiMax = new Item()
            {
                ItemName = "Pepsi Max",
                ItemMaxStack = 3,
                ItemEffect = "Full HP Recovery",
                ItemType = "Consumable",
            };

            ItemsToAdd.Add(HealthPotion);
            ItemsToAdd.Add(StrengthPotion);
            ItemsToAdd.Add(PepsiMax);

            //succesful usage of the DbActionsRepo methods to do EF work.
            foreach(Item i in ItemsToAdd)
            {
                _dbActionsRepo.InsertItemToItemsMasterDb(i);
            }
            _dbActionsRepo.Save();
        }

        //again just more examples to clean up what the previous method adds to the datatbase until I start adding items for real.
        public void RemoveItemsFromItemsMasterTable()
        {
            string HealthPotion = "Health Potion";
            string StrengthPotion = "Strength Potion";
            string PepsiMax = "Pepsi Max";

            ItemsToRemove.Add(HealthPotion);
            ItemsToRemove.Add(StrengthPotion);
            ItemsToRemove.Add(PepsiMax);

            foreach(var i in ItemsToRemove)
            {
                _dbActionsRepo.RemoveItemFromItemsMasterDb(i);
            }
            _dbActionsRepo.Save();
        }

        public void ModifyItemInItemsMasterDb(string columnToUpdate, string entryToFind, object newValue)
        {
            _dbActionsRepo.ModifyItemInItemsMasterDb(columnToUpdate, entryToFind, newValue);
        }
    }
}
