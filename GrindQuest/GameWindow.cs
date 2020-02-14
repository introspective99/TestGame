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
    public partial class GameWindow : Form
    {
        readonly ItemsAndInventoryLogic itemLogic = new ItemsAndInventoryLogic();
        public GameWindow()
        {
            InitializeComponent();
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";
        }
        private void SelectionThreeButton_Click(object sender, EventArgs e)
        {
            itemLogic.CreateItemAndInsertIntoItemsMasterDbAndSaveChanges(1, "Health Potion", "HP +10", "Consumable");
        }
        private void SelectionFourButton_Click(object sender, EventArgs e)
        {
            itemLogic.FindAndRemoveItemFromItemsMasterDbAndSaveChanges("Health Potion");
        }
        private void SelectionTwoButton_Click(object sender, EventArgs e)
        {
            itemLogic.FindItemAndUpdateMaxStackValueAndSaveChanges("Health Potion", 3);
        }
    }
}
