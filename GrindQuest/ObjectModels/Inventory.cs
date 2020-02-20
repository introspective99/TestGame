using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public int InventoryOwnerId { get; set; }
        public InventorySlot InventorySlotOne { get; set; }
        public InventorySlot InventorySlotTwo { get; set; }
        public InventorySlot InventorySlotThree { get; set; }
        public InventorySlot InventorySlotFour { get; set; }
        public InventorySlot InventorySlotFive { get; set; }
        public InventorySlot InventorySlotSix { get; set; }
        public InventorySlot InventorySlotSeven { get; set; }
        public InventorySlot InventorySlotEight { get; set; }
        public InventorySlot InventorySlotNine { get; set; }
        public InventorySlot InventorySlotTen { get; set; }

    }
}
