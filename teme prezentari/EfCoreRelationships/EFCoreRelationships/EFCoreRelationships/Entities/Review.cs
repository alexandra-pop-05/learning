namespace EFCoreRelationships.Entities;

public class Review
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public int AddedBy { get; set; }
    public User User { get; set; }
}
