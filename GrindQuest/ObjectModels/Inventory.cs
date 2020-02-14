using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int InventoryOwnerID { get; set; }
        public int InventorySize { get; set; }
        public List<InventorySlot> InventoryItems { get; set; }
    }
}
