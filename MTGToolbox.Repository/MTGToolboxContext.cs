using MTGToolbox.Core;
using Microsoft.EntityFrameworkCore;

namespace MTGToolbox.Repository
{
    public class MTGToolboxContext : DbContext
    {
        public MTGToolboxContext(DbContextOptions<MTGToolboxContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
    }
}
