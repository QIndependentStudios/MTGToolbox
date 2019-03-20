using System.Collections.Generic;

namespace MTGToolbox.Abstract
{
    public interface IDeckRepository
    {
        IEnumerable<IDeck> GetDecks();
        IDeck GetDeckById(int id);
        IDeck GetDeckByName(string deckName);
    }
}
