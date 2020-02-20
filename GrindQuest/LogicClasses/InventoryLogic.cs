using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.LogicClasses
{
    public class InventoryLogic
    {
        private readonly IInventoryLogic _inventoryLogic;
        public InventoryLogic(IInventoryLogic inventoryLogic)
        {
            _inventoryLogic = inventoryLogic;
        }
    }
}
