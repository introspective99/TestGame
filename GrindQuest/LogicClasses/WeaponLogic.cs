using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.LogicClasses
{
    public class WeaponLogic : IWeaponLogic
    {
        private readonly IWeaponMasterDbActionsRepo _weaponMasterDbActionsRepo;
        
        public WeaponLogic(IWeaponMasterDbActionsRepo weaponMasterDbActionsRepo)
        {
            _weaponMasterDbActionsRepo = weaponMasterDbActionsRepo;
        }

    }
}
