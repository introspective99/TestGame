using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class InventorySlot
    {
        public int InventorySlotID { get; set; }
        public int InventoryOwnerID { get; set; }
        public bool OccupiedTrueOrFalse { get; set; }
        public int ItemID { get; set; }
        
    }
}
