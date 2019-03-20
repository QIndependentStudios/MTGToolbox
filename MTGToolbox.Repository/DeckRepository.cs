using Microsoft.EntityFrameworkCore;
using MTGToolbox.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MTGToolbox.Repository
{
    public class DeckRepository : IDeckRepository
    {
        private MTGToolboxContext context;

        public DeckRepository(MTGToolboxContext context)
        {
            this.context = context;
        }

        public IEnumerable<IDeck> GetDecks()
        {
            return context.Decks.ToList();
        }

        public IDeck GetDeckById(int id)
        {
            return context.Decks.Find(id);
        }

        public IDeck GetDeckByName(string name)
        {
            return context.Decks.SingleOrDefault(c => EF.Functions.Like(c.Name, name));
        }
    }
}
