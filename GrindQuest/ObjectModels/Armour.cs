using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Armour
    {
        [Key]
        public int ArmourId { get; set; }
        public string ArmourName { get; set; }
        public int ArmourGoldValue { get; set; }
        public int ArmourMaxStrength { get; set; }
        public int ArmourMinStrength { get; set; }
        public int ArmourMaxIntellect { get; set; }
        public int ArmourMinIntellect { get; set; }
        public int ArmourMaxAgility { get; set; }
        public int ArmourMinAgility { get; set; }
        public int ArmourMaxStamina { get; set; }
        public int ArmourMinStamina { get; set; }
        public int ArmourMaxSpeed { get; set; }
        public int ArmourMinSpeed { get; set; }
        public int ArmourDurability { get; set; }
        public string ArmourQuality { get; set; }
        public string ArmourSlot { get; set; }
    }
}
