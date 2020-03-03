using GrindQuest.ObjectModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindQuest
{
    public class GameDbContext : DbContext 
    {
        //Instructs EF to create tables of <type> with the specified name.
        public DbSet<Character> CharacterMasterTable { get; set; }
        public DbSet<Item> ItemsReferenceTable { get; set; }
        public DbSet<Armour> ArmourReferenceTable { get; set; }
        public DbSet<Weapon> WeaponReferenceTable { get; set; }
        public DbSet<Inventory> InventoryReferenceTable { get; set; }

       
        //instructions for configuring the connection to the SQL server correctly.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                   //.UseSqlServer(@"Data Source=.\Asura;Initial Catalog=GrindQuestDb;Integrated Security=True");
                 .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=GrindQuestDb;Integrated Security=True");

        }
    }
}
