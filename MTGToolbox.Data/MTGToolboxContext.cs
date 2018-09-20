using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MTGToolbox.Data
{
    class MTGToolboxContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = MTGToolbox; Trusted_Connection = True; "); // TODO: Put this into the .config
        }
    }
}