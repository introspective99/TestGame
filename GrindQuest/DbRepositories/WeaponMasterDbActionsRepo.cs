using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.DbRepositories
{
    public class WeaponMasterDbActionsRepo : IWeaponMasterDbActionsRepo
    {
        private readonly GameDbContext context;
        public WeaponMasterDbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }

    }
}
