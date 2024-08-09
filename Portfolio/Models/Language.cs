namespace Briefcase.Models
{
    public class Language
    {
        public string Name { get; internal set; }
        public int Level { get; internal set; }

        public Language(string language, int level)
        {
            Name = language;
            Level = level;
        }
    }
}
