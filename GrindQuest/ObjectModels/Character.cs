using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Character
    {
        //The intention is to have the capacity to support multiple different players and instances of the game so multiple people can play
        //simultaneously, so having the individual CharID is an effective way to achieve that.
        [Key]
        public int CharacterId { get; set; }
        //I don't particularly want to do much work around the playername variable, partly because users might use weird characters in their name
        //that code won't play nicely with.
        public string CharacterName { get; set; }
        public Inventory CharacterInventory { get; set; }
        public int CharacterLevel { get; set; }
        public int CharacterGold { get; set; }
        //I think this is the best way to handle stats, instead of trying to create subtables in SQL for confusing stat tables.
        public int CharacterStrength { get; set; }
        public int CharacterIntellect { get; set; }
        public int CharacterAgility { get; set; }
        public int CharacterStamina { get; set; }
        public int CharacterSpeed { get; set; }
    }
}
