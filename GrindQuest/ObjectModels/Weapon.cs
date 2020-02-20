using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Weapon
    {
        [Key]
        public int WeaponId { get; set; }
        public string WeaponName { get; set; }
        public int WeaponGoldValue { get; set; }
        public int WeaponMaxBaseDamage { get; set; }
        public int WeaponMinBaseDamage { get; set; }
        public string WeaponQuality { get; set; }
        public string WeaponSlot { get; set; }
        public string WeaponEfffect { get; set; }
    }
}
