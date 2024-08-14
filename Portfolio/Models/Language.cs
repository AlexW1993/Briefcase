namespace Briefcase.Models
{
    public class Language
    {
        public string Name { get; internal set; }
        public int SpeakingLevel { get; internal set; }
        public int WritingLevel { get; internal set; }
        public int ReadingLevel { get; internal set; }
        public int ListeningLevel { get; internal set; }


        public Language(string language, int speaking, int writng, int reading,int listening)
        {
            Name = language;
            SpeakingLevel = speaking;
            WritingLevel = writng;
            ReadingLevel = reading;
            ListeningLevel = listening;
            
        }
    }
}
