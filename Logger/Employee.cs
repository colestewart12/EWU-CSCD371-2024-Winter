namespace Logger
{
    public record Employee : BaseEntity
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
}
