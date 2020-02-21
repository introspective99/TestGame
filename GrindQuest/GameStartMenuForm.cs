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
            List<Character> characterList = _characterLogic.GetListOfCharactersForLabelData();

            var nameLabels = new List<Label> { slotOneNameLabel, slotTwoNameLabel, slotThreeNameLabel, slotFourNameLabel };
            var levelLabels = new List<Label> { slotOneLevelLabel, slotTwoLevelLabel, slotThreeLevelLabel, slotFourLevelLabel };
            var goldLabels = new List<Label> { slotOneGoldLabel, slotTwoGoldLabel, slotThreeGoldLabel, slotFourGoldLabel };
            var deleteButtons = new List<Button> { slotOneDeleteButton, slotTwoDeleteButton, slotThreeDeleteButton, slotFourDeleteButton };

            int counter = 0;
            foreach (Character character in characterList)
            {
                nameLabels[counter].Text = character.CharacterName;
                levelLabels[counter].Text = character.CharacterLevel.ToString();
                goldLabels[counter].Text = character.CharacterGold.ToString();
                deleteButtons[counter].Enabled = true;
                counter++;
            }

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

            if (!String.IsNullOrEmpty(characterNameInputTextBox.Text))
            {
                if (_characterLogic.CheckForOpenSaveSpaces().Equals(true))
                {
                    _characterLogic.AddNewCharacterToDb(characterNameInputTextBox.Text);

                    //switches to the load character panel and hides the start menu panel
                    List<Character> characterList = _characterLogic.GetListOfCharactersForLabelData();

                    var nameLabels = new List<Label> { slotOneNameLabel, slotTwoNameLabel, slotThreeNameLabel, slotFourNameLabel };
                    var levelLabels = new List<Label> { slotOneLevelLabel, slotTwoLevelLabel, slotThreeLevelLabel, slotFourLevelLabel };
                    var goldLabels = new List<Label> { slotOneGoldLabel, slotTwoGoldLabel, slotThreeGoldLabel, slotFourGoldLabel };
                    var deleteButtons = new List<Button> { slotOneDeleteButton, slotTwoDeleteButton, slotThreeDeleteButton, slotFourDeleteButton };

                    int counter = 0;
                    foreach (Character character in characterList)
                    {
                        nameLabels[counter].Text = character.CharacterName;
                        levelLabels[counter].Text = character.CharacterLevel.ToString();
                        goldLabels[counter].Text = character.CharacterGold.ToString();
                        deleteButtons[counter].Enabled = true;
                        counter++;
                    }

                    newCharacterPanel.Hide();
                    startMenuPanel.Hide();
                    this.Size = loadCharacterFormSize;
                    loadCharacterPanel.Show();

                }
                else if (_characterLogic.CheckForOpenSaveSpaces().Equals(false))
                {
                    MessageBox.Show("Not Enough Character Spaces, delete one to make room");
                }
            }

        }

        private void SlotOneDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is permanent!", "Are you sure you want to delete this hero?",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _characterLogic.RemoveCharacterFromDatabase(slotOneNameLabel.Text);
                slotOneNameLabel.Text = "Empty";
                slotOneLevelLabel.Text = "0";
                slotOneGoldLabel.Text = "0";
                slotOneDeleteButton.Enabled = false;
                this.Refresh();
            }
        }

        private void SlotTwoDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is permanent!", "Are you sure you want to delete this hero?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _characterLogic.RemoveCharacterFromDatabase(slotTwoNameLabel.Text);
                slotTwoNameLabel.Text = "Empty";
                slotTwoLevelLabel.Text = "0";
                slotTwoGoldLabel.Text = "0";
                slotTwoDeleteButton.Enabled = false;
                this.Refresh();
            }
        }
        private void SlotThreeDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is permanent!", "Are you sure you want to delete this hero?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _characterLogic.RemoveCharacterFromDatabase(slotThreeNameLabel.Text);
                slotThreeNameLabel.Text = "Empty";
                slotThreeLevelLabel.Text = "0";
                slotThreeGoldLabel.Text = "0";
                slotThreeDeleteButton.Enabled = false;
                this.Refresh();
            }
        }
        private void SlotFourDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is permanent!", "Are you sure you want to delete this hero?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _characterLogic.RemoveCharacterFromDatabase(slotFourNameLabel.Text);
                slotFourNameLabel.Text = "Empty";
                slotFourLevelLabel.Text = "0";
                slotFourGoldLabel.Text = "0";
                slotFourDeleteButton.Enabled = false;
                this.Refresh();
            }
        }

        private void LoadSlotOneButton_Click(object sender, EventArgs e)
        {
            GameWindow openGame = new GameWindow();
            openGame.Show();
            this.Close();
        }
    }
}
