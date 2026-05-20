using MediaTek86.modele.acces;
using MediaTek86.modele.metier;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MediaTek86.controleur
{
    internal class ControleurAbsence
    {
        private BddManager bddManager;

        public ControleurAbsence()
        {
            bddManager =
                new BddManager();
        }

        public List<Absence> GetLesAbsences(
            int idPersonnel)
        {
            List<Absence> lesAbsences =
                new List<Absence>();

            string requete =
                "SELECT idpersonnel, " +
                "datedebut, datefin, " +
                "idmotif " +
                "FROM absence " +
                "WHERE idpersonnel = " +
                idPersonnel;

            MySqlDataReader reader =
                bddManager.ReqSelect(
                    requete
                );

            while (reader.Read())
            {
                Absence absence =
                    new Absence(
                        (int)reader["idpersonnel"],

                        (System.DateTime)
                            reader["datedebut"],

                        (System.DateTime)
                            reader["datefin"],

                        (int)reader["idmotif"]
                    );

                lesAbsences.Add(
                    absence
                );
            }

            reader.Close();

            bddManager.CloseConnexion();

            return lesAbsences;
        }

        public void AddAbsence(
            Absence absence)
        {
            string requete =
                "INSERT INTO absence(" +
                "idpersonnel, datedebut, " +
                "datefin, idmotif) " +
                "VALUES(" +
                absence.IdPersonnel +
                ", '" +
                absence.DateDebut
                    .ToString("yyyy-MM-dd") +
                "', '" +
                absence.DateFin
                    .ToString("yyyy-MM-dd") +
                "', " +
                absence.IdMotif +
                ")";

            bddManager =
                new BddManager();

            bddManager.ReqMaj(
                requete
            );

            bddManager.CloseConnexion();
        }

        public void DeleteAbsence(
            int idPersonnel,
            string dateDebut)
        {
            string requete =
                "DELETE FROM absence " +
                "WHERE idpersonnel = " +
                idPersonnel +
                " AND datedebut = '" +
                dateDebut + "'";

            bddManager =
                new BddManager();

            bddManager.ReqMaj(
                requete
            );

            bddManager.CloseConnexion();
        }

        public void UpdateAbsence(
            int idPersonnel,
            string ancienneDate,
            Absence absence)
        {
            string requete =
                "UPDATE absence SET " +
                "datedebut = '" +
                absence.DateDebut
                    .ToString("yyyy-MM-dd") +
                "', datefin = '" +
                absence.DateFin
                    .ToString("yyyy-MM-dd") +
                "', idmotif = " +
                absence.IdMotif +
                " WHERE idpersonnel = " +
                idPersonnel +
                " AND datedebut = '" +
                ancienneDate + "'";

            bddManager =
                new BddManager();

            bddManager.ReqMaj(
                requete
            );

            bddManager.CloseConnexion();
        }
    }
}