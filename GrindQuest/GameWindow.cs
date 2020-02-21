using GrindQuest.Interfaces;
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
        //haven't figured out how to inject this class without initialising it in the Program.Main() method yet. Doing it in main() only initialises it
        //once in the lifetime of the program so I can kind of deal with that.
        private readonly IItemsLogic _itemsLogic;
        private readonly IArmourLogic _armourLogic;
        public GameWindow(IItemsLogic itemsLogic, IArmourLogic armourLogic)
        {
            this._itemsLogic = itemsLogic;
            this._armourLogic = armourLogic;
        }
        public GameWindow()
        {
            InitializeComponent();

            //you can't actually dictate unicode in the designer properties box so have to do it via code which is what this is.
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";
        }
        //mostly using these buttons to test functionalities.
        private void SelectionOneButton_Click(object sender, EventArgs e)
        {
        }
        private void SelectionTwoButton_Click(object sender, EventArgs e)
        {
            //_itemsAndInventoryLogic.RemoveItemByItemIdFromItemsMasterTable();
        }
        private void SelectionThreeButton_Click(object sender, EventArgs e)
        {

        }
        private void SelectionFourButton_Click(object sender, EventArgs e)
        {

        }


    }
}
