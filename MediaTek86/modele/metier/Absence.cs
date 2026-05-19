using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele.metier
{
    internal class Absence
    {
        private int idpersonnel;
        private DateTime datedebut;
        private DateTime datefin;
        private int idmotif;

        public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }
        public DateTime Datefin { get => datefin; set => datefin = value; }
        public int Idmotif { get => idmotif; set => idmotif = value; }
    }
}
