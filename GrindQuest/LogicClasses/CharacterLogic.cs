using GrindQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.LogicClasses
{
    public class CharacterLogic : ICharacterLogic
    {
        private readonly ICharacterMasterDbActionsRepo _characterMasterDbActionsRepo;
        public CharacterLogic(ICharacterMasterDbActionsRepo characterMasterDbActionsRepo)
        {
            _characterMasterDbActionsRepo = characterMasterDbActionsRepo;
        }
    }
}
