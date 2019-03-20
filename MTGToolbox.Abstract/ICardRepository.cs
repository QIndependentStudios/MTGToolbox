using System.Collections.Generic;

namespace MTGToolbox.Abstract
{
    public interface ICardRepository
    {
        IEnumerable<ICard> GetCards();
        ICard GetCardById(int id);
        ICard GetCardByName(string cardName);
    }
}
