namespace Briefcase.Models
{
    public class Force
    {
        public string Name { get; internal set; }

        public Force(string name)
        {
            Name = name;
        }
    }
}
