using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest.Databases
{
    public class TilesDb
    {
        public static  List<Tile> allTiles = new List<Tile>();

        public static void CreateTiles()
        {
            Tile jTwo = new Tile()
            {
                TileName = "jTwo",
                North = true,
                NorthTileName = "iTwo",
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(jTwo);

            Tile iTwo = new Tile()
            {
                TileName = "iTwo",
                North = true,
                NorthTileName = "hTwo",
                East = true,
                EastTileName = "iThree",
                West = true,
                WestTileName = "iOne",
                South = false,
            };
            allTiles.Add(iTwo);

            Tile iOne = new Tile()
            {
                TileName = "iOne",
                North = false,
                East = true,
                EastTileName = "iTwo",
                West = false,
                South = false,
            };
            allTiles.Add(iOne);

            Tile iThree = new Tile()
            {
                TileName = "iThree",
                North = false,
                East = false,
                West = true,
                WestTileName = "iTwo",
                South = false,
            };
            allTiles.Add(iThree);

            Tile hTwo = new Tile()
            {
                TileName = "hTwo",
                North = true,
                NorthTileName = "gTwo",
                East = false,
                West = true,
                WestTileName = "hOne",
                South = true,
                SouthTileName = "ITwo"
            };
            allTiles.Add(hTwo);
        }
    }
}
