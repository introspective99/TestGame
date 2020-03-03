using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindQuest.Interfaces
{
    interface ITileLogic
    {
        Tile GetTileByLabelName(string tileName);
        Label GetLabelByTileName(string tileName);
    }
}
