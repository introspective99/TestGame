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
        void InsertCharacterToCharacterMasterDb(Character character);
        Character GetCharacterById(int characterId);
        Character GetCharacterByName(string characterName);
        void RemoveCharacterFromCharacterMasterDb(int characterId);
        List<Character> GetListOfCharactersInCharactersMasterTable();
        void ModifyCharacterbyCharacterId(int characterId, string nameOfColumnToUpdate, Object newValue);
    }
}
