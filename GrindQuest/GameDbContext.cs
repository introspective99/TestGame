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
        //instructs EF to create the PlayerChars table. 
        public DbSet<PlayerChar> PlayerChars { get; set; }
        //instructs EF to create the ItemsMaster table.
        public DbSet<Item> ItemsMasterTable { get; set; }
        //instructions for configuring the connection to the SQL server correctly.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=.\Asura;Initial Catalog=GrindQuestDb;Integrated Security=True");
        }
    }
}
