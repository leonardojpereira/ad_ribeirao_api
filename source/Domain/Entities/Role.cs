namespace Project.Domain.Entities;

public class Role
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
    public string Name { get; set; } = string.Empty;
    public virtual IEnumerable<User>? Users { get; set; }

    public Role(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

}
