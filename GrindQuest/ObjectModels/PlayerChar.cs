using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class PlayerChar
    {
        //The intention is to have the capacity to support multiple different players and instances of the game so multiple people can play
        //simultaneously, so having the individual CharID is an effective way to achieve that.
        
        public int PlayerCharID { get; set; }
        //I don't particularly want to do much work around the playername variable, partly because users might use weird characters in their name
        //that code won't play nicely with.
        public string PlayerCharName { get; set; }
        //somewhat of a placeholder variable, not sure how I want to handle specialisations yet.
        public int PlayerCharSpec { get; set; }
    }
}
