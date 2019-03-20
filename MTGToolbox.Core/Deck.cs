using MTGToolbox.Abstract;
using System.Collections.Generic;

namespace MTGToolbox.Core
{
    public class Deck : IDeck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<ICard> Cards { get; set; }
    }
}
