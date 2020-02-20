using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.Interfaces
{
    public interface ICharacterMasterDbActionsRepo
    {
        void InsertItemToCharacterMasterDb(Character character);
        Character GetCharacterById(int characterId);
        void RemoveCharacterFromCharacterMasterDb(int characterId);
        void ModifyCharacterbyCharacterId(int characterId, string nameOfColumnToUpdate, Object newValue);
    }
}
