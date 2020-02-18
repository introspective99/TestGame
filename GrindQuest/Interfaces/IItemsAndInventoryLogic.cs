using System;

namespace GrindQuest
{
    public interface IItemsAndInventoryLogic
    {
        void AddTestItemsToItemsMasterTable();
        void RemoveItemByItemIdFromItemsMasterTable(int itemId);
        void ModifyItemByItemIdFromItemsMasterTable(int itemId, string nameOfColumnToUpdate, Object newValue);

    }
}