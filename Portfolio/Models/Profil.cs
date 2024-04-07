namespace Portfolio.Models
{
    public class Profil
    {
        public List<string> Forces { get; set; }
        public string Email { get; set; }

        public Profil()
        {
            Forces = GetForces();
            Email = "alexander_william93@hotmail.com";
        }

        private List<string> GetForces()
        {
            List<string> forces = new List<string>()
            {
                "Autonomy",
                "Teamwork",
                "Patience",
                "Versatility",
                "Tenancity",
                "Rigor",
                "Adapatation",
            };

            return forces;
        }
    }
}
