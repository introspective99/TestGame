using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.ObjectModels
{
    public class Tile : TileMovementConfig
    {
        public string TileName { get; set; }
        public TileMovementConfig TileMovementConfig { get; set; }

    }
}
