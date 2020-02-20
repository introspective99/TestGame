using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class InventorySlot
    {
        public int InventorySlotId { get; set; }
        public int ParentInventoryId { get; set; }
        public int ItemId { get; set; }
        public bool SlotUnlocked { get; set; }
    }
}
