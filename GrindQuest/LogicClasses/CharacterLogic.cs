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
                    CurrentTileLocation = "tile1",
                };
                _characterMasterDbActionsRepo.InsertCharacterToCharacterMasterDb(newCharacter);
        }
        public bool CheckForOpenSaveSpaces()
        {
            List<Character> characterList = _characterMasterDbActionsRepo.GetListOfCharactersInCharactersMasterTable();
            if(characterList.Count < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Character> GetListOfCharactersForLabelData()
        {
            List<Character> characterList = _characterMasterDbActionsRepo.GetListOfCharactersInCharactersMasterTable();
            return characterList;
        }

        public void RemoveCharacterFromDatabase(string characterName)
        {
            Character characterToRemove = _characterMasterDbActionsRepo.GetCharacterByName(characterName);
            _characterMasterDbActionsRepo.RemoveCharacterFromCharacterMasterDb(characterToRemove.CharacterId);
        }
        
        [Obsolete]
        public string PopulateNameLabels(List<Character> characters)
        {
            string characterName = characters.First().CharacterName;
            characters.Remove(characters.First());
            return characterName;
        }
        
        public Character GetCharacterFromDb(object characterIdentifier)
        {
            if(characterIdentifier is string)
            {
                return _characterMasterDbActionsRepo.GetCharacterByName(characterIdentifier.ToString());
            }
            else if(characterIdentifier is int)
            {
                return _characterMasterDbActionsRepo.GetCharacterById((Int32)characterIdentifier);
            }
            else
            {
                return null;
            }
        }
    }
}
