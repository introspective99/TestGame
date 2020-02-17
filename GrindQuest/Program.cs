using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindQuest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IItemsAndInventoryLogic _itemsAndInventoryLogic = new ItemsAndInventoryLogic(new ItemsMasterDbActionsRepo(new GameDbContext()));
            Application.Run(new GameWindow(_itemsAndInventoryLogic));
        }
    }
}
