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
        private readonly IItemsAndInventoryLogic _itemsAndInventoryLogic = new ItemsAndInventoryLogic(new DbActionsRepo(new GameDbContext()));
        public GameWindow()
        {
            InitializeComponent();
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";
        }

        private void SelectionOneButton_Click(object sender, EventArgs e)
        {
            _itemsAndInventoryLogic.AddItemsToItemsMasterTable();
        }
        private void SelectionTwoButton_Click(object sender, EventArgs e)
        {
            _itemsAndInventoryLogic.RemoveItemsFromItemsMasterTable();
        }
        private void SelectionThreeButton_Click(object sender, EventArgs e)
        {

        }
        private void SelectionFourButton_Click(object sender, EventArgs e)
        {

        }


    }
}
