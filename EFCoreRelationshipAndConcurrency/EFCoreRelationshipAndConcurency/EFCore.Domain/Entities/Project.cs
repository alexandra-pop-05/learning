namespace EFCore.Domain.Entities;
public class Project
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public byte[] RowVersion { get; set; }

    public ICollection<UserProject> Users { get; set; } = new List<UserProject>();

}
