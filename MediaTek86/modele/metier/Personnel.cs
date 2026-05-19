using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele.metier
{
    internal class Personnel
    {
        private int id;
        private string nom;
        private string prenom;
        private int idservice;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int IdService { get => idservice; set => idservice = value; }

        public Personnel(int id, string nom, string prenom, int idservice)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.idservice = idservice;
        }
    }
}