using GrindQuest.Interfaces;
using GrindQuest.ObjectModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindQuest
{
    public partial class GameStartMenuForm : Form
    {

        private Size startMenuFormSize = new Size()
        {
            Height = 290,
            Width = 215,
        };
        private Size newCharacterFormSize = new Size()
        {
            Height = 200,
            Width = 375,
        };
        private Size loadCharacterFormSize = new Size()
        {
            Height = 360,
            Width = 275,
        };
        private readonly ICharacterLogic _characterLogic;
        //public GameStartMenuForm(ICharacterLogic characterLogic)
        //{
            //_characterLogic = characterLogic;
        //}

        public GameStartMenuForm()
        {
            InitializeComponent();
            Size = startMenuFormSize;
            _characterLogic = (ICharacterLogic)Program.ServiceProvider.GetService(typeof(ICharacterLogic));
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            //Switches to the new character panel and hides the start menu panel 
            startMenuPanel.Hide();
            loadCharacterPanel.Hide();
            this.Size = newCharacterFormSize;
            newCharacterPanel.Show();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            //switches to the load character panel and hides the start menu panel
            List<Character> characterList = _characterLogic.GetListOfCharacters();

            //First Character slot labels
            slotOneNameLabel.Text = characterList[0].CharacterName;
            slotOneLevelLabel.Text = characterList[0].CharacterLevel.ToString();
            slotOneGoldLabel.Text = characterList[0].CharacterGold.ToString();
            //Second Character slot labels
            slotTwoNameLabel.Text = characterList[1].CharacterName;
            slotTwoLevelLabel.Text = characterList[1].CharacterLevel.ToString();
            slotTwoGoldLabel.Text = characterList[1].CharacterGold.ToString();
            //Third Character slot labels
            slotThreeNameLabel.Text = characterList[2].CharacterName;
            slotThreeLevelLabel.Text = characterList[2].CharacterLevel.ToString();
            slotThreeGoldLabel.Text = characterList[2].CharacterGold.ToString();
            //Fourth Character slot label
            slotFourNameLabel.Text = characterList[3].CharacterName;
            slotFourLevelLabel.Text = characterList[3].CharacterLevel.ToString();
            slotFourGoldLabel.Text = characterList[3].CharacterGold.ToString();

            this.Size = loadCharacterFormSize;
            startMenuPanel.Hide();
            newCharacterPanel.Hide();
            loadCharacterPanel.Show();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            //closes new character panel and shows the start menu again
            newCharacterPanel.Hide();
            loadCharacterPanel.Hide();
            this.Size = startMenuFormSize;
            startMenuPanel.Show();
        }
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            //closes the load character panel and shows the start menu again
            loadCharacterPanel.Hide();
            newCharacterPanel.Hide();
            this.Size = startMenuFormSize;
            startMenuPanel.Show();
        }

        private void CharacterNameInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z-\b]+$"))
                e.Handled = true;
        }

        private void ConfirmCharacterCreationButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(characterNameInputTextBox.Text) & _characterLogic.CheckForOpenSaveSpaces().Equals(true))
            {
                _characterLogic.AddNewCharacterToDb(characterNameInputTextBox.Text);
                newCharacterPanel.Hide();
                startMenuPanel.Hide();
                this.Size = loadCharacterFormSize;
                loadCharacterPanel.Show();
            }
            else if(_characterLogic.CheckForOpenSaveSpaces().Equals(false))
            {
                MessageBox.Show("Not Enough Character Spaces, delete one to make room");
                newCharacterPanel.Hide();
                startMenuPanel.Hide();
                this.Size = loadCharacterFormSize;
                loadCharacterPanel.Show();
            }
        }
    }
}
