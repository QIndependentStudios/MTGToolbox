using Microsoft.EntityFrameworkCore;
using MTGToolbox.Abstract;

namespace MTGToolbox.Repository
{
    internal class UnitOfWork
    {
        private MTGToolboxContext context;
        private ICardRepository cardRepository;
        private IDeckRepository deckRepository;

        public UnitOfWork(DbContextOptions<MTGToolboxContext> options)
        {
            context = new MTGToolboxContext(options);
        }

        public ICardRepository CardRepository
        {
            get
            {
                if (cardRepository == null)
                {
                    cardRepository = new CardRepository(context);
                }
                return cardRepository;
            }
        }

        public IDeckRepository DeckRepository
        {
            get
            {
                if (deckRepository == null)
                {
                    deckRepository = new DeckRepository(context);
                }
                return deckRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
