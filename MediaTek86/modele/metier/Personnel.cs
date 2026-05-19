using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele.metier
{
    internal class Personnel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int IdService { get; set; }

        public Personnel(
            int id,
            string nom,
            string prenom,
            int idservice)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.IdService = idservice;
        }
    }
}