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
        public DbSet<PlayerChar> PlayerChars { get; set; }
        public DbSet<Item> ItemsMasterTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=.\Asura;Initial Catalog=GrindQuestDb;Integrated Security=True");
        }
    }
}
