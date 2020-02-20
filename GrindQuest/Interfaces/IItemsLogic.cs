using System;

namespace GrindQuest
{
    public interface IItemsLogic
    {
        void AddTestItemsToItemsMasterTable();
        void RemoveItemByItemIdFromItemsMasterTable(int itemId);
        void ModifyItemByItemIdFromItemsMasterTable(int itemId, string nameOfColumnToUpdate, Object newValue);

    }
}