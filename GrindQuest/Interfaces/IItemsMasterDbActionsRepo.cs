﻿using GrindQuest.ObjectModels;
using System;

namespace GrindQuest
{
    public interface IItemsMasterDbActionsRepo
    {
        void InsertItemToItemsMasterDb(Item item);
        Item GetItemById(int itemId);
        void RemoveItemFromItemsMasterDb(int itemId);
        void ModifyItemByItemIdFromItemsMasterDb(int itemId, string nameOfValueToUpdate, Object newValue);
        void Save();
    }
}