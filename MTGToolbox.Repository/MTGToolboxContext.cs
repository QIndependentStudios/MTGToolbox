using MTGToolbox.Core;
using System.Data.Entity;

namespace MTGToolbox.Repository
{
    public class MTGToolboxContext : DbContext
    {
        public MTGToolboxContext() : base("MTGToolboxContext")
        {
        }

        public DbSet<ICard> Cards { get; set; }
    }
}
