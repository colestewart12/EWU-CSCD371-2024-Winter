

namespace Logger;

public abstract class BaseEntity : IEntity
{
    public Guid Id { get; init; }

    //Implemented explicitly to avoid naming contradictions
    string IEntity.Name
    {
        get
        {
            return GetName();
        }

        set
        {
            SetName(value);
        }
    }

    protected abstract string GetName();
    protected abstract void SetName(string name);
}
