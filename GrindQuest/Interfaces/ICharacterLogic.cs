using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.Interfaces
{
    public interface ICharacterLogic
    {
        void AddNewCharacterToDb(string characterName);
        bool CheckForOpenSaveSpaces();
        List<Character> GetListOfCharactersForLabelData();
        string PopulateNameLabels(List<Character> characters);
        void RemoveCharacterFromDatabase(string characterName);

    }
}
