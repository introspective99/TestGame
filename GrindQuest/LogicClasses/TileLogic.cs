using GrindQuest.Interfaces;
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
        public PictureBox GetPictureBoxByName(string tileName)
        {
            foreach(PictureBox tile in GameWindow.tileList)
            {
                if(tile.Name == tileName)
                {
                    return tile;
                }
            }
            return null;
        }
    }
}
