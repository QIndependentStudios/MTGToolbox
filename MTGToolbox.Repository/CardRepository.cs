using Microsoft.EntityFrameworkCore;
using MTGToolbox.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MTGToolbox.Repository
{
    public class CardRepository : ICardRepository
    {
        private MTGToolboxContext context;

        public CardRepository(MTGToolboxContext context)
        {
            this.context = context;
        }

        public IEnumerable<ICard> GetCards()
        {
            return context.Cards.ToList();
        }

        public ICard GetCardById(int id)
        {
            return context.Cards.Find(id);
        }

        public ICard GetCardByName(string name)
        {
            return context.Cards.SingleOrDefault(c => EF.Functions.Like(c.Name, name));
        }
    }
}
