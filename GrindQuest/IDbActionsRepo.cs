using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public interface IDbActionsRepo
    {
        void InsertItemToItemsMasterDb(Item item);
        void RemoveItemFromItemsMasterDb(string itemName);
        void UpdateMaxStackValueOfItemInItemsMasterDb(string itemName, int newMaxStackSize);
        void Save();
    }
}
