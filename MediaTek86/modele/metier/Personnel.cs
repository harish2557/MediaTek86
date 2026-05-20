namespace MediaTek86.modele.metier
{
    public class Personnel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int IdService { get; set; }

        public Personnel(
            int id,
            string nom,
            string prenom,
            int idService
        )
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            IdService = idService;
        }
    }
}