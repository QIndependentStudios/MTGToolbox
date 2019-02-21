using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTGToolbox.Core;

namespace MTGToolbox.Repository
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetCards();
        Card GetCardById(int id);
        Card GetCardByName(string cardName);

    }
}
