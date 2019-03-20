namespace MTGToolbox.Abstract
{
    public interface ICard
    {
        int Id { get; set; }
        string Name { get; set; }
        string ImageFile { get; set; }
    }
}
