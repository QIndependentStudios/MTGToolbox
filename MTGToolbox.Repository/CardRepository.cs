using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTGToolbox.Core;

namespace MTGToolbox.Repository
{
    public class CardRepository : ICardRepository, IDisposable
    {
        private MTGToolboxContext context;
        private bool disposed = false;

        public CardRepository(MTGToolboxContext context)
        {
            this.context = context;
        }

        public IEnumerable<Card> GetCards()
        {
            return context.Cards.ToList();
        }

        public Card GetCardByName(string name)
        {
            return context.Cards.Find(name);
        }

        public Card GetCardById(int id)
        {
            return context.Cards.Find(id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
