using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
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
        public CharacterLogic()
        {
            _characterMasterDbActionsRepo = (ICharacterMasterDbActionsRepo)Program.ServiceProvider.GetService(typeof(ICharacterMasterDbActionsRepo));
        }

        public void AddNewCharacterToDb(string characterName)
        {
                var newCharacter = new Character()
                {
                    CharacterName = characterName,
                    CharacterLevel = 1,
                    CharacterInventory = new Inventory(),
                    CharacterStamina = 1,
                    CharacterStrength = 1,
                    CharacterIntellect = 1,
                    CharacterAgility = 1,
                    CharacterSpeed = 1,
                };
                _characterMasterDbActionsRepo.InsertCharacterToCharacterMasterDb(newCharacter);
        }
        public bool CheckForOpenSaveSpaces()
        {
            List<Character> characterList = _characterMasterDbActionsRepo.GetListOfCharactersInCharactersMasterTable();
            if (characterList.Count < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Character> GetListOfCharacters()
        {
            List<Character> characterList = _characterMasterDbActionsRepo.GetListOfCharactersInCharactersMasterTable();
            return characterList;
        }

        [Obsolete]
        public string PopulateNameLabels(List<Character> characters)
        {
            string characterName = characters.First().CharacterName;
            characters.Remove(characters.First());
            return characterName;
        }
    }
}
