namespace Logger;

public record Student : BaseEntity
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

