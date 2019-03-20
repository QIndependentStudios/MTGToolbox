using MTGToolbox.Abstract;

namespace MTGToolbox.Core
{
    public class Card : ICard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFile { get; set; }
    }
}
