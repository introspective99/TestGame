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
            //first row of tiles
            Tile tile1 = new Tile()
            {
                TileName = "tile1",
                North = false,
                East = true,
                EastTileName = "tile2",
                South = true,
                SouthTileName = "tile11",
                West = false,
            };
            allTiles.Add(tile1);

            Tile tile2 = new Tile()
            {
                TileName = "tile2",
                North = false,
                East = true,
                EastTileName = "tile3",
                West = true,
                WestTileName = "tile1",
                South = true,
                SouthTileName = "tile12",
            };
            allTiles.Add(tile2);

            Tile tile3 = new Tile()
            {
                TileName = "tile3",
                North = false,
                East = true,
                EastTileName = "tile4",
                West = true,
                WestTileName = "tile2",
                South = true,
                SouthTileName = "tile13",
            };
            allTiles.Add(tile3);

            Tile tile4 = new Tile()
            {
                TileName = "tile4",
                North = false,
                East = true,
                EastTileName = "tile5",
                West = true,
                WestTileName = "tile3",
                South = true,
                SouthTileName = "tile14",
            };
            allTiles.Add(tile4);

            Tile tile5 = new Tile()
            {
                TileName = "tile5",
                North = false,
                East = true,
                EastTileName = "tile6",
                West = true,
                WestTileName = "tile4",
                South = true,
                SouthTileName = "tile15",
            };
            allTiles.Add(tile5);

            Tile tile6 = new Tile()
            {
                TileName = "tile6",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile16",
                West = true,
                WestTileName = "tile5",
            };
            allTiles.Add(tile6);

            Tile tile7 = new Tile()
            {
                TileName = "tile7",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile7);

            Tile tile8 = new Tile()
            {
                TileName = "tile8",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile8);

            Tile tile9 = new Tile()
            {
                TileName = "tile9",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile9);

            Tile tile10 = new Tile()
            {
                TileName = "tile10",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile10);

            //second row of tiles
            Tile tile11 = new Tile()
            {
                TileName = "tile11",
                North = true,
                NorthTileName = "tile1",
                East = true,
                EastTileName = "tile12",
                South = true,
                SouthTileName = "tile21",
                West = false,
            };
            allTiles.Add(tile11);

            Tile tile12 = new Tile()
            {
                TileName = "tile12",
                North = true,
                NorthTileName = "tile2",
                East = true,
                EastTileName = "tile13",
                West = true,
                WestTileName = "tile11",
                South = true,
                SouthTileName = "tile22",
            };
            allTiles.Add(tile12);

            Tile tile13 = new Tile()
            {
                TileName = "tile13",
                North = true,
                NorthTileName = "tile3",
                East = true,
                EastTileName = "tile14",
                West = true,
                WestTileName = "tile12",
                South = true,
                SouthTileName = "tile23",
            };
            allTiles.Add(tile13);

            Tile tile14 = new Tile()
            {
                TileName = "tile14",
                North = true,
                NorthTileName = "tile4",
                East = true,
                EastTileName = "tile15",
                West = true,
                WestTileName = "tile13",
                South = true,
                SouthTileName = "tile24",
            };
            allTiles.Add(tile14);

            Tile tile15 = new Tile()
            {
                TileName = "tile15",
                North = true,
                NorthTileName = "tile5",
                East = true,
                EastTileName = "tile16",
                West = true,
                WestTileName = "tile14",
                South = true,
                SouthTileName = "tile25",
            };
            allTiles.Add(tile15);

            Tile tile16 = new Tile()
            {
                TileName = "tile16",
                North = true,
                NorthTileName = "tile6",
                East = false,
                South = true,
                SouthTileName = "tile26",
                West = true,
                WestTileName = "tile15",
            };
            allTiles.Add(tile16);

            Tile tile17 = new Tile()
            {
                TileName = "tile17",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile17);

            Tile tile18 = new Tile()
            {
                TileName = "tile18",
                North = false,
                East = false,
                West = false,
                South = true,
                SouthTileName = "tile28",
            };
            allTiles.Add(tile18);

            Tile tile19 = new Tile()
            {
                TileName = "tile19",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile19);

            Tile tile20 = new Tile()
            {
                TileName = "tile20",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile20);

            //third row of tiles
            Tile tile21 = new Tile()
            {
                TileName = "tile21",
                North = true,
                NorthTileName = "tile11",
                East = true,
                EastTileName = "tile22",
                South = false,
                West = false,
            };
            allTiles.Add(tile21);

            Tile tile22 = new Tile()
            {
                TileName = "tile22",
                North = true,
                NorthTileName = "tile12",
                East = true,
                EastTileName = "tile23",
                South = false,
                West = true,
                WestTileName = "tile21",
            };
            allTiles.Add(tile22);

            Tile tile23 = new Tile()
            {
                TileName = "tile23",
                North = true,
                NorthTileName = "tile13",
                East = true,
                EastTileName = "tile24",
                West = true,
                WestTileName = "tile22",
                South = false,
            };
            allTiles.Add(tile23);

            Tile tile24 = new Tile()
            {
                TileName = "tile24",
                North = true,
                NorthTileName = "tile14",
                East = true,
                EastTileName = "tile25",
                West = true,
                WestTileName = "tile23",
                South = false,
            };
            allTiles.Add(tile24);

            Tile tile25 = new Tile()
            {
                TileName = "tile25",
                North = true,
                NorthTileName = "tile15",
                East = true,
                EastTileName = "tile26",
                West = true,
                WestTileName = "tile24",
                South = false,
            };
            allTiles.Add(tile25);

            Tile tile26 = new Tile()
            {
                TileName = "tile26",
                North = true,
                NorthTileName = "tile16",
                East = false,
                South = true,
                SouthTileName = "tile36",
                West = true,
                WestTileName = "tile25",
            };
            allTiles.Add(tile26);

            Tile tile27 = new Tile()
            {
                TileName = "tile27",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile27);

            Tile tile28 = new Tile()
            {
                TileName = "tile28",
                North = true,
                NorthTileName = "tile18",
                East = false,
                West = false,
                South = true,
                SouthTileName = "tile38",
            };
            allTiles.Add(tile28);

            Tile tile29 = new Tile()
            {
                TileName = "tile29",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile29);

            Tile tile30 = new Tile()
            {
                TileName = "tile30",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile30);

            //fourth row of tiles
            Tile tile31 = new Tile()
            {
                TileName = "tile31",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile31);

            Tile tile32 = new Tile()
            {
                TileName = "tile32",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile32);

            Tile tile33 = new Tile()
            {
                TileName = "tile33",
                North = false,
                East = false,
                South = false,
                West = false,

            };
            allTiles.Add(tile33);

            Tile tile34 = new Tile()
            {
                TileName = "tile34",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile34);

            Tile tile35 = new Tile()
            {
                TileName = "tile35",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile35);

            Tile tile36 = new Tile()
            {
                TileName = "tile36",
                North = true,
                NorthTileName = "tile26",
                East = false,
                South = true,
                SouthTileName = "tile46",
                West = false,
            };
            allTiles.Add(tile36);

            Tile tile37 = new Tile()
            {
                TileName = "tile37",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile37);

            Tile tile38 = new Tile()
            {
                TileName = "tile38",
                North = true,
                NorthTileName = "tile28",
                East = false,
                West = false,
                South = true,
                SouthTileName = "tile48",
            };
            allTiles.Add(tile38);

            Tile tile39 = new Tile()
            {
                TileName = "tile39",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile39);

            Tile tile40 = new Tile()
            {
                TileName = "tile40",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile40);

            //fifth row of tiles
            Tile tile41 = new Tile()
            {
                TileName = "tile41",
                North = false,
                East = true,
                EastTileName = "tile42",
                South = false,
                West = false,
            };
            allTiles.Add(tile41);

            Tile tile42 = new Tile()
            {
                TileName = "tile42",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile52",
                West = true,
                WestTileName = "tile41"
            };
            allTiles.Add(tile42);

            Tile tile43 = new Tile()
            {
                TileName = "tile43",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile53",
                West = false,

            };
            allTiles.Add(tile43);

            Tile tile44 = new Tile()
            {
                TileName = "tile44",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile54",
                West = false,
            };
            allTiles.Add(tile44);

            Tile tile45 = new Tile()
            {
                TileName = "tile45",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile45);

            Tile tile46 = new Tile()
            {
                TileName = "tile46",
                North = true,
                NorthTileName = "tile36",
                East = false,
                South = true,
                SouthTileName = "tile56",
                West = false,
            };
            allTiles.Add(tile46);

            Tile tile47 = new Tile()
            {
                TileName = "tile47",
                North = false,
                East = false,
                West = false,
                South = false,
            };
            allTiles.Add(tile47);

            Tile tile48 = new Tile()
            {
                TileName = "tile48",
                North = true,
                NorthTileName = "tile38",
                East = true,
                EastTileName = "tile49",
                West = false,
                South = true,
                SouthTileName = "tile58",
            };
            allTiles.Add(tile48);

            Tile tile49 = new Tile()
            {
                TileName = "tile49",
                North = false,
                East = true,
                EastTileName = "tile50",
                South = false,
                West = true,
                WestTileName = "tile48",
            };
            allTiles.Add(tile49);

            Tile tile50 = new Tile()
            {
                TileName = "tile50",
                North = false,
                East = false,
                South = false,
                West = true,
                WestTileName = "tile49",
            };
            allTiles.Add(tile50);

            //sixth row of tiles
            Tile tile51 = new Tile()
            {
                TileName = "tile51",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile61",
                West = false,
            };
            allTiles.Add(tile51);

            Tile tile52 = new Tile()
            {
                TileName = "tile52",
                North = true,
                NorthTileName = "tile42",
                East = false,
                South = true,
                SouthTileName = "tile62",
                West = false,
            };
            allTiles.Add(tile52);

            Tile tile53 = new Tile()
            {
                TileName = "tile53",
                North = true,
                NorthTileName = "tile43",
                East = false,
                South = true,
                SouthTileName = "tile63",
                West = false,

            };
            allTiles.Add(tile53);

            Tile tile54 = new Tile()
            {
                TileName = "tile54",
                North = true,
                NorthTileName = "tile44",
                East = false,
                South = true,
                SouthTileName = "tile64",
                West = false,
            };
            allTiles.Add(tile54);

            Tile tile55 = new Tile()
            {
                TileName = "tile55",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile55);

            Tile tile56 = new Tile()
            {
                TileName = "tile56",
                North = true,
                NorthTileName = "tile46",
                East = false,
                South = true,
                SouthTileName = "tile66",
                West = false,
            };
            allTiles.Add(tile56);

            Tile tile57 = new Tile()
            {
                TileName = "tile57",
                North = false,
                East = false,
                South = false,
                West = false,

            };
            allTiles.Add(tile57);

            Tile tile58 = new Tile()
            {
                TileName = "tile58",
                North = true,
                NorthTileName = "tile48",
                East = false,
                South = true,
                SouthTileName = "tile68",
                West = false,
            };
            allTiles.Add(tile58);

            Tile tile59 = new Tile()
            {
                TileName = "tile59",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile59);

            Tile tile60 = new Tile()
            {
                TileName = "tile60",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile60);

            //seventh row of tiles
            Tile tile61 = new Tile()
            {
                TileName = "tile61",
                North = true,
                NorthTileName = "tile51",
                East = true,
                EastTileName = "tile62",
                South = false,
                West = false,
            };
            allTiles.Add(tile61);

            Tile tile62 = new Tile()
            {
                TileName = "tile62",
                North = true,
                NorthTileName = "tile52",
                East = true,
                EastTileName = "tile63",
                South = true,
                SouthTileName = "tile72",
                West = true,
                WestTileName = "tile61",
            };
            allTiles.Add(tile62);

            Tile tile63 = new Tile()
            {
                TileName = "tile63",
                North = false,
                East = true,
                EastTileName = "tile64",
                South = false,
                West = true,
                WestTileName = "tile62",
            };
            allTiles.Add(tile63);

            Tile tile64 = new Tile()
            {
                TileName = "tile64",
                North = true,
                NorthTileName = "tile54",
                East = true,
                EastTileName = "tile65",
                South = true,
                SouthTileName = "tile74",
                West = true,
                WestTileName = "tile63",
            };
            allTiles.Add(tile64);

            Tile tile65 = new Tile()
            {
                TileName = "tile65",
                North = false,
                East = true,
                EastTileName = "tile66",
                South = false,
                West = true,
                WestTileName = "tile64",
            };
            allTiles.Add(tile65);

            Tile tile66 = new Tile()
            {
                TileName = "tile66",
                North = true,
                NorthTileName = "tile56",
                East = true,
                EastTileName = "tile67",
                South = true,
                SouthTileName = "tile76",
                West = true,
                WestTileName = "tile65",
            };
            allTiles.Add(tile66);

            Tile tile67 = new Tile()
            {
                TileName = "tile67",
                North = false,
                East = true,
                EastTileName = "tile68",
                South = true,
                SouthTileName = "tile77",
                West = true,
                WestTileName = "tile66",

            };
            allTiles.Add(tile67);

            Tile tile68 = new Tile()
            {
                TileName = "tile68",
                North = true,
                NorthTileName = "tile58",
                East = true,
                EastTileName = "tile69",
                South = true,
                SouthTileName = "tile78",
                West = true,
                WestTileName = "tile67",
            };
            allTiles.Add(tile68);

            Tile tile69 = new Tile()
            {
                TileName = "tile69",
                North = false,
                East = false,
                South = true,
                SouthTileName = "tile79",
                West = true,
                WestTileName = "tile68",
            };
            allTiles.Add(tile69);

            Tile tile70 = new Tile()
            {
                TileName = "tile70",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile70);

            //Eighth row of tiles
            Tile tile71 = new Tile()
            {
                TileName = "tile71",
                North = false,
                East = true,
                EastTileName = "tile72",
                South = false,
                West = false,
            };
            allTiles.Add(tile71);

            Tile tile72 = new Tile()
            {
                TileName = "tile72",
                North = true,
                NorthTileName = "tile62",
                East = false,
                South = true,
                SouthTileName = "tile82",
                West = true,
                WestTileName = "tile71",
            };
            allTiles.Add(tile72);

            Tile tile73 = new Tile()
            {
                TileName = "tile73",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile73);

            Tile tile74 = new Tile()
            {
                TileName = "tile74",
                North = true,
                NorthTileName = "tile64",
                East = false,
                South = true,
                SouthTileName = "tile84",
                West = false,
            };
            allTiles.Add(tile74);

            Tile tile75 = new Tile()
            {
                TileName = "tile75",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile75);

            Tile tile76 = new Tile()
            {
                TileName = "tile76",
                North = true,
                NorthTileName = "tile66",
                East = true,
                EastTileName = "tile77",
                South = true,
                SouthTileName = "tile86",
                West = false,
            };
            allTiles.Add(tile76);

            Tile tile77 = new Tile()
            {
                TileName = "tile77",
                North = true,
                NorthTileName = "tile67",
                East = true,
                EastTileName = "tile78",
                South = true,
                SouthTileName = "tile87",
                West = true,
                WestTileName = "tile76",

            };
            allTiles.Add(tile77);

            Tile tile78 = new Tile()
            {
                TileName = "tile78",
                North = true,
                NorthTileName = "tile68",
                East = true,
                EastTileName = "tile79",
                South = true,
                SouthTileName = "tile88",
                West = true,
                WestTileName = "tile77",
            };
            allTiles.Add(tile78);

            Tile tile79 = new Tile()
            {
                TileName = "tile79",
                North = true,
                NorthTileName = "tile69",
                East = false,
                South = true,
                SouthTileName = "tile89",
                West = true,
                WestTileName = "tile78",
            };
            allTiles.Add(tile79);

            Tile tile80 = new Tile()
            {
                TileName = "tile80",
                North = false,
                East = false,
                South = false,
                West = false,
            };
            allTiles.Add(tile80);
        }
    }
}
