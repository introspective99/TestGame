using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
using GrindQuest.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrindQuest.LogicClasses;

namespace GrindQuest
{
    public partial class GameWindow : Form
    {
        private readonly TileLogic _tileLogic;
        public Character PlayerCharacter { get; set; }
        public static List<Label> tileNames = new List<Label>();

        public GameWindow(Character playerCharacter)
        {
            InitializeComponent();
            _tileLogic = (TileLogic)Program.ServiceProvider.GetService(typeof(TileLogic));
            TilesDb.CreateTiles();
            //you can't actually dictate unicode in the designer properties box so have to do it via code which is what this is.
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";

            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("tile"))
                {
                    tileNames.Add((Label)c);
                }
            }
            _tileLogic.GetLabelByTileName(playerCharacter.CurrentTileLocation).Text = "X";
        }
        private void MoveCharacterNorth(Label CurrentTile)
        {
            Tile currentTile = _tileLogic.GetTileByLabelName(CurrentTile.Name);
            Label northTileLabel = _tileLogic.GetLabelByTileName(currentTile.NorthTileName);
            if (currentTile.North == true)
            {
                PlayerCharacter.CurrentTileLocation = currentTile.NorthTileName;
                CurrentTile.Text = "";
                northTileLabel.Text = "X";
            }
        }
        private void MoveCharacterEast(Label CurrentTile)
        {
            Tile currentTile = _tileLogic.GetTileByLabelName(CurrentTile.Name);
            Label EastTileLabel = _tileLogic.GetLabelByTileName(currentTile.EastTileName);
            if (currentTile.East == true)
            {
                PlayerCharacter.CurrentTileLocation = currentTile.EastTileName;
                CurrentTile.Text = "";
                EastTileLabel.Text = "X";
            }
        }
        private void MoveCharacterSouth(Label CurrentTile)
        {
            Tile currentTile = _tileLogic.GetTileByLabelName(CurrentTile.Name);
            Label southTileLabel = _tileLogic.GetLabelByTileName(currentTile.SouthTileName);
            if (currentTile.South == true)
            {
                PlayerCharacter.CurrentTileLocation = currentTile.SouthTileName;
                CurrentTile.Text = "";
                southTileLabel.Text = "X";
            }
        }
        private void MoveCharacterWest(Label CurrentTile)
        {
            Tile currentTile = _tileLogic.GetTileByLabelName(CurrentTile.Name);
            Label westTileLabel = _tileLogic.GetLabelByTileName(currentTile.WestTileName);
            if (currentTile.West == true)
            {
                PlayerCharacter.CurrentTileLocation = currentTile.WestTileName;
                CurrentTile.Text = "";
                westTileLabel.Text = "X";
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            MoveCharacterNorth(_tileLogic.GetLabelByTileName(PlayerCharacter.CurrentTileLocation));
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            MoveCharacterEast(_tileLogic.GetLabelByTileName(PlayerCharacter.CurrentTileLocation));
        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            MoveCharacterSouth(_tileLogic.GetLabelByTileName(PlayerCharacter.CurrentTileLocation));
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            MoveCharacterWest(_tileLogic.GetLabelByTileName(PlayerCharacter.CurrentTileLocation));
        }
    }
}
