using System;

namespace GrindQuest
{
    public interface IItemsAndInventoryLogic
    {
        void AddItemsToItemsMasterTable();
        void RemoveItemsFromItemsMasterTable();
        void ModifyItemInItemsMasterDb(string columnToUpdate, string entryToFind, Object newValue);

    }
}