using System;
using System.Collections.Generic;
using System.Text;

namespace MTGToolbox.Repository
{
    class UnitOfWork : IDisposable
    {
        private MTGToolboxContext context = new MTGToolboxContext();
        private ICardRepository cardRepository;
        private bool disposed = false;

        public ICardRepository CardRepository
        {
            get
            {
                if (this.cardRepository == null)
                {
                    this.cardRepository = new CardRepository(context);
                }
                return cardRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
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
