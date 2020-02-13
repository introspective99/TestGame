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
        public GameWindow()
        {
            InitializeComponent();
            leftButton.Text = "\u2190";
            rightButton.Text = "\u2192";
            upButton.Text = "\u2191";
            downButton.Text = "\u2193";
        }
    }
}
