using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.DbRepositories
{
    public class ArmourMasterDbActionsRepo : IArmourMasterDbActionsRepo
    {
        private readonly GameDbContext context;
        public ArmourMasterDbActionsRepo(GameDbContext context)
        {
            this.context = context;
        }
        private void Save()
        {
            context.SaveChanges();
        }
        public void InsertItemToArmourReferenceTable(Armour armour)
        {
            context.ArmourReferenceTable.Add(armour);
            Save();
        }
        public void RemoveItemFromArmourReferenceTable(int armourId)
        {
            context.ArmourReferenceTable.Remove(GetArmourById(armourId));
            Save();
        }
        public void ModifyArmourInArmourReferenceTable(int armourId, string nameOfColumnToUpdate, Object newValue)
        {
            var foundEntry = GetArmourById(armourId);
            foreach (var prop in foundEntry.GetType().GetProperties())
            {
                if (prop.Name == nameOfColumnToUpdate)
                {
                    prop.SetValue(foundEntry, newValue);
                }
            }
            Save();
        }
        public Armour GetArmourById(int armourId)
        {
            return context.ArmourReferenceTable.FirstOrDefault(p => p.ArmourId == armourId);
        }

    }
}
