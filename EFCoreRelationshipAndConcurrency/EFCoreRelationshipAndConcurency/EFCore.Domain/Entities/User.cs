namespace EFCore.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public int PersonId { get; set; }
    public Person? Person { get; set; }

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    public ICollection<UserProject> Projects { get; set; } = new List<UserProject>();

}
