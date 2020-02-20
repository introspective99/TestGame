using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.Interfaces
{
    public interface IArmourMasterDbActionsRepo
    {
        void InsertItemToArmourReferenceTable(Armour armour);
        void RemoveItemFromArmourReferenceTable(int armourId);
        void ModifyArmourInArmourReferenceTable(int armourId, string nameOfColumnToUpdate, Object newValue);
        Armour GetArmourById(int armourId);

    }
}
