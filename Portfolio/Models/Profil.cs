namespace Briefcase.Models
{
    public class Profil
    {
        public List<Force> Forces { get; set; }
        public string Email { get; set; }

        public List<Language> Languages { get; set; }

        public Profil()
        {
            Forces = GetForces();
            Email = "alexander_william93@hotmail.com";
            Languages = GetLanguages();
        }

        private List<Force> GetForces()
        {

            List<Force> forces = new List<Force>()
            {
                new Force("Autonomy"),
                new Force("Teamwork"),
                new Force("Patience"),
                new Force("Versatility"),
                new Force("Tenancity"),
                new Force("Rigor"),
                new Force("Adapatation"),
            };

            return forces;
        }

        private List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>()
            {
                new Language("Spanish", 10,9,10,10),
                new Language("English", 4,6,6,5),
                new Language("French", 8,8,8,8),
            };

            return languages;
        }
    }
}
