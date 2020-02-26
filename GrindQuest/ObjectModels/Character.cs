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
        //this probably isn't an effective way to manage stats but we'll see in future if I need to change it, it does work well for now.
        public int CharacterStrength { get; set; }
        public int CharacterIntellect { get; set; }
        public int CharacterAgility { get; set; }
        public int CharacterStamina { get; set; }
        public int CharacterSpeed { get; set; }
        public string CurrentTileLocation { get; set; }
    }
}
