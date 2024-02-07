namespace Logger;

public abstract record class BaseEntity : IEntity
{
    public abstract string Name { get; set; }
    public Guid Id { get; init; }
}
