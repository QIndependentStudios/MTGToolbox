using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTGToolbox.Core;

namespace MTGToolbox.Repository
{
    public class CardRepository : ICardRepository
    {
        private List<ICard> _cards;

        public CardRepository()
        {
            if (_cards == null)
            {
                InitializeCards();
            }
        }

        private void InitializeCards()
        {
            _cards = new List<ICard>
                    {
                        new Card { Id = 1, Name = "Ancestral Recall" },
                        new Card { Id = 2, Name = "Black Lotus" }
                    };
        }

        public IEnumerable<ICard> GetAllCards()
        {
            return _cards;
        }

        public ICard GetCardByName(string name)
        {
            return _cards.FirstOrDefault(c => c.Name == name);
        }

        public ICard GetCardById(int id)
        {
            return _cards.FirstOrDefault(c => c.Id == id);
        }
    }
}
