namespace SocialSphereApp.API.Entities;

public abstract class BaseEntity
{
    protected BaseEntity() {
        CreatedAt = DateTime.Now;
        IsDeleted = false;
        Id = Guid.NewGuid();
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; private set; }

    public void SetAsDeleted()
    {
        IsDeleted = true;
    }

}
