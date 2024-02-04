using System.Text;

namespace Logger
{
    //thoughts on this implementation of Employee/Student?
    public record Employee : BaseEntity
    {
        private FullName fullName = new("", null, "");
        protected override string GetName()
        {
            StringBuilder result = new();
            result.Append(fullName.FirstName);
            if(fullName.MiddleName is not null)
            {
                result.Append(" " + fullName.MiddleName);
            }
            result.Append(" " + fullName.LastName);
            return result.ToString();
        }

        protected override void SetName(string name)
        {
            string[] names = name.Split();
            if (names.Length == 2)
            {
                fullName = new(names[0], names[1]);
            }
            else if (names.Length == 3)
            {
                fullName = new(names[0], names[1], names[2]);
            }
            else
            {
                throw new ArgumentException("invalid name");
            }
        }
    }
}
