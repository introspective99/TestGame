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
        public Character playerCharacter { get; set; }
        public static List<PictureBox> tileList = new List<PictureBox>();

        //haven't figured out how to inject this class without initialising it in the Program.Main() method yet. Doing it in main() only initialises it
        //once in the lifetime of the program so I can kind of deal with that.
        public GameWindow()
        {
            InitializeComponent();
            _tileLogic = (TileLogic)Program.ServiceProvider.GetService(typeof(TileLogic));
            TilesDb.CreateTiles();
            //you can't actually dictate unicode in the designer properties box so have to do it via code which is what this is.
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";
            foreach(Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    tileList.Add((PictureBox)control);
                }
            }

        }
        private void MoveCharacterNorth()
        {
            foreach(Tile tile in TilesDb.allTiles)
            {
                if(playerCharacter.CurrentTileLocation == tile.TileName)
                {
                    PictureBox currentLocation = _tileLogic.GetPictureBoxByName(playerCharacter.CurrentTileLocation);
                    currentLocation.Dispose();
                    PictureBox replacementBox = new PictureBox()
                    {
                        Name = currentLocation.Name,
                        Location = currentLocation.Location,
                        BackColor = currentLocation.BackColor,
                        Height = currentLocation.Height,
                        Width = currentLocation.Width,
                    };
                    playerCharacter.CurrentTileLocation = tile.NorthTileName;
                    this.Controls.Add(replacementBox);
                    break;
                }
                else
                {
                    upButton.Enabled = false;
                }
            }
        }
        private void MoveCharacterSouth()
        {
            foreach (Tile tile in TilesDb.allTiles)
            {
                if (playerCharacter.CurrentTileLocation == tile.TileName)
                {
                    PictureBox currentLocation = _tileLogic.GetPictureBoxByName(playerCharacter.CurrentTileLocation);
                    currentLocation.Dispose();
                    PictureBox replacementBox = new PictureBox()
                    {
                        Name = currentLocation.Name,
                        Location = currentLocation.Location,
                        BackColor = currentLocation.BackColor,
                        Height = currentLocation.Height,
                        Width = currentLocation.Width,
                    };
                    playerCharacter.CurrentTileLocation = tile.SouthTileName;
                    this.Controls.Add(replacementBox);
                    break;
                }
                else
                {
                    downButton.Enabled = false;
                }
            }
        }
        private void MoveCharacterEast()
        {
            foreach (Tile tile in TilesDb.allTiles)
            {
                if (playerCharacter.CurrentTileLocation == tile.TileName)
                {
                    PictureBox currentLocation = _tileLogic.GetPictureBoxByName(playerCharacter.CurrentTileLocation);
                    currentLocation.Dispose();
                    PictureBox replacementBox = new PictureBox()
                    {
                        Name = currentLocation.Name,
                        Location = currentLocation.Location,
                        BackColor = currentLocation.BackColor,
                        Height = currentLocation.Height,
                        Width = currentLocation.Width,
                    };
                    playerCharacter.CurrentTileLocation = tile.EastTileName;
                    this.Controls.Add(replacementBox);
                    break;
                }
                else
                {
                    rightButton.Enabled = false;
                }
            }
        }
        private void MoveCharacterWest()
        {
            foreach (Tile tile in TilesDb.allTiles)
            {
                if (playerCharacter.CurrentTileLocation == tile.TileName & tile.West == true)
                {
                    PictureBox currentLocation = _tileLogic.GetPictureBoxByName(playerCharacter.CurrentTileLocation);
                    currentLocation.Dispose();
                    PictureBox replacementBox = new PictureBox()
                    {
                        Name = currentLocation.Name,
                        Location = currentLocation.Location,
                        BackColor = currentLocation.BackColor,
                        Height = currentLocation.Height,
                        Width = currentLocation.Width,
                    };
                    playerCharacter.CurrentTileLocation = tile.WestTileName;
                    this.Controls.Add(replacementBox);
                    break;
                }
                else
                {
                    leftButton.Enabled = false;
                }
            }
        }
        private void MarkNewCharacterLocation(string tileName)
        {
            PictureBox currentLocation = _tileLogic.GetPictureBoxByName(tileName);
            currentLocation.Invalidate();
        }
        private void MarkCharacterLocationOnLoad(object sender, PaintEventArgs e)
        {
            var currentPlayerLocation = (PictureBox)sender;
            if (currentPlayerLocation.Name == playerCharacter.CurrentTileLocation)
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    e.Graphics.DrawString("X", myFont, Brushes.Black, new Point(2, 2));
                }
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            MoveCharacterNorth();
            MarkNewCharacterLocation(playerCharacter.CurrentTileLocation);
            Debug.WriteLine(playerCharacter.CurrentTileLocation);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            MoveCharacterEast();
            MarkNewCharacterLocation(playerCharacter.CurrentTileLocation);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            MoveCharacterWest();
            MarkNewCharacterLocation(playerCharacter.CurrentTileLocation);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            MoveCharacterSouth();
            MarkNewCharacterLocation(playerCharacter.CurrentTileLocation);
        }




        //private void AddTileToPictureBox(object sender, EventArgs e)
        //{
        //    var tile = (PictureBox)sener;
        //    if (tile.Name == playerCharacter.CurrentTileLocation)
        //    {
        //        using (Font myFont = new Font("Arial", 14))
        //        {
        //            e.Graphics.DrawString("X", myFont, Brushes.Black, new Point(2, 2));
        //        }
        //    }
        //}
    }
}
