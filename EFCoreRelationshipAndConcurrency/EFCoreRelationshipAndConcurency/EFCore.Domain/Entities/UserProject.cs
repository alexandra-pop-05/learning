namespace EFCore.Domain.Entities;
public class UserProject
{
    public int UserProjectId { get; set; }
    
    public int ProjectId { get; set; }
    public Project Project { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

}
