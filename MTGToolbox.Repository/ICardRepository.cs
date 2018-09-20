using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTGToolbox.Core;

namespace MTGToolbox.Repository
{
    public interface ICardRepository
    {
        IEnumerable<ICard> GetAllCards();
        ICard GetCardById(int id);
        ICard GetCardByName(string cardName);

    }
}
