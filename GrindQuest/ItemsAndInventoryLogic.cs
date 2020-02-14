using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public class ItemsAndInventoryLogic : IItemsAndInventoryLogic
    {
        private readonly IDbActionsRepo _dbActionsRepo;
        public ItemsAndInventoryLogic(IDbActionsRepo actionsRepo)
        {
            _dbActionsRepo = actionsRepo;
        }

        public List<Item> ItemsToAdd = new List<Item>();
        public List<string> ItemsToRemove = new List<string>();

        public void AddItemsToItemsMasterTable()
        {
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

            foreach(Item i in ItemsToAdd)
            {
                _dbActionsRepo.InsertItemToItemsMasterDb(i);
            }
            _dbActionsRepo.Save();
        }
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
    }
}
