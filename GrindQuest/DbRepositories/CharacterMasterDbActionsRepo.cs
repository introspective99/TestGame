using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.DbRepositories
{
    public class CharacterMasterDbActionsRepo : ICharacterMasterDbActionsRepo
    {
        private readonly GameDbContext context;
        public CharacterMasterDbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }
        private void Save()
        {
            context.SaveChanges();
        }
        public void InsertItemToCharacterMasterDb(Character character)
        {
            context.CharacterMasterTable.Add(character);
            Save();
        }
        public Character GetCharacterById(int characterId)
        {
            return context.CharacterMasterTable.FirstOrDefault(p => p.CharacterId == characterId);
        }
        public void RemoveCharacterFromCharacterMasterDb(int characterId)
        {
            context.CharacterMasterTable.Remove(GetCharacterById(characterId));
            Save();
        }
        public void ModifyCharacterbyCharacterId(int characterId, string nameOfColumnToUpdate, Object newValue)
        {
            var foundEntry = GetCharacterById(characterId);
            foreach (var prop in foundEntry.GetType().GetProperties())
            {
                if (prop.Name == nameOfColumnToUpdate)
                {
                    prop.SetValue(foundEntry, newValue);
                }
            }
            Save();
        }
    }
}
