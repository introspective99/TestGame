using GrindQuest.DbRepositories;
using GrindQuest.Interfaces;
using GrindQuest.LogicClasses;
using Microsoft.Extensions.DependencyInjection;
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
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new GameStartMenuForm());
        }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ICharacterLogic, CharacterLogic>();
            services.AddSingleton<ICharacterMasterDbActionsRepo, CharacterMasterDbActionsRepo>();
            services.AddSingleton<GameDbContext>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
