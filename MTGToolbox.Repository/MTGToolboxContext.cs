using Microsoft.EntityFrameworkCore;
using MTGToolbox.Core;
using System.Collections.Generic;

namespace MTGToolbox.Repository
{
    public class MTGToolboxContext : DbContext
    {
        public MTGToolboxContext(DbContextOptions<MTGToolboxContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deck>()
                .HasMany(d => (IEnumerable<Card>)d.Cards);
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
    }
}
