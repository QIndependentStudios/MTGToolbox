using System.Collections.Generic;

namespace MTGToolbox.Abstract
{
    public interface IDeck
    {
        int Id { get; set; }
        string Name { get; set; }
        IEnumerable<ICard> Cards { get; set; }
    }
}
