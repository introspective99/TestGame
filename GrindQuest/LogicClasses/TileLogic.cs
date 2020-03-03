using GrindQuest.Databases;
using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindQuest.LogicClasses
{
    public class TileLogic : ITileLogic
    {
        public Label GetLabelByTileName(string tileName)
        {
            foreach (Label tile in GameWindow.tileNames)
            {
                if (tile.Name == tileName)
                {
                    return tile;
                }
            }
            return null;
        }

        public Tile GetTileByLabelName(string tileName)
        {
            Tile selectedTile = new Tile();

            foreach(Tile tile in TilesDb.allTiles)
            {
                if(tile.TileName == tileName)
                {
                    selectedTile = tile;
                }
            }
            return selectedTile;
        }
    }
}
