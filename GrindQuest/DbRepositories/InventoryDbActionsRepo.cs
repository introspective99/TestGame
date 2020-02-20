using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.DbRepositories
{
    public class InventoryDbActionsRepo : IInventoryDbActionsRepo
    {
        private readonly GameDbContext context;
        public InventoryDbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }
    }
}
