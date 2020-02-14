using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public class ItemsAndInventoryLogic
    {
        private readonly IDbActionsRepo dbActionsRepo;
        public ItemsAndInventoryLogic()
        {
            this.dbActionsRepo = new DbActionsRepo(new GameDbContext());
        }
        public ItemsAndInventoryLogic(IDbActionsRepo dbActionsRepo)
        {
            this.dbActionsRepo = dbActionsRepo;
        }

        public void CreateItemAndInsertIntoItemsMasterDbAndSaveChanges(int itemMaxStack, string itemName, string itemEffect, string itemType)
        {
            Item newItem = new Item()
            {
                ItemName = itemName,
                ItemMaxStack = itemMaxStack,
                ItemEffect = itemEffect,
                ItemType = itemType,
            };
            dbActionsRepo.InsertItemToItemsMasterDb(newItem);
            dbActionsRepo.Save();
        }
        public void FindAndRemoveItemFromItemsMasterDbAndSaveChanges(string itemName)
        {
            dbActionsRepo.RemoveItemFromItemsMasterDb(itemName);
            dbActionsRepo.Save();
        }

        public void FindItemAndUpdateMaxStackValueAndSaveChanges(string itemName, int newMaxStackSize)
        {
            dbActionsRepo.UpdateMaxStackValueOfItemInItemsMasterDb(itemName, newMaxStackSize);
            dbActionsRepo.Save();
        }
    }
}
