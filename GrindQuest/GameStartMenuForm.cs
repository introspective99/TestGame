using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public GameStartMenuForm()
        {
            InitializeComponent();
            Size = startMenuFormSize;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            startMenuPanel.Hide();
            this.Size = newCharacterFormSize;
            newCharacterPanel.Show();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {

        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            newCharacterPanel.Hide();
            this.Size = startMenuFormSize;
            startMenuPanel.Show();
        }

        private void CharacterNameInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z-\b]+$"))
                e.Handled = true;
        }
    }
}
