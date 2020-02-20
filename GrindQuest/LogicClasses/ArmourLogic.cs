using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.LogicClasses
{
    public class ArmourLogic : IArmourLogic 
    {
        private readonly IArmourMasterDbActionsRepo _armourMasterDbActionsRepo;
        public ArmourLogic(IArmourMasterDbActionsRepo armourMasterDbActionsRepo)
        {
            _armourMasterDbActionsRepo = armourMasterDbActionsRepo;
        }
    }
}
