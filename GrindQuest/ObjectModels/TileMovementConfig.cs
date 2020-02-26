using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public abstract class TileMovementConfig
    {
        public bool North { get; set; }
        public string NorthTileName { get; set; }
        public bool East { get; set; }
        public string EastTileName { get; set; }
        public bool South { get; set; }
        public string SouthTileName { get; set; }
        public bool West { get; set; }
        public string WestTileName { get; set; }
    }
}
