namespace Logger;

public record Book : BaseEntity
{
    protected override string GetName()
    {
        throw new NotImplementedException();
    }

    protected override void SetName(string name)
    {
        throw new NotImplementedException();
    }
}

