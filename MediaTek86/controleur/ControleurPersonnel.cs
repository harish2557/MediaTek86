using MediaTek86.modele.acces;
using MediaTek86.modele.metier;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MediaTek86.controleur
{
    internal class ControleurPersonnel
    {
        private BddManager bddManager;

        public ControleurPersonnel()
        {
            bddManager = new BddManager();
        }

        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels =
                new List<Personnel>();

            string requete =
                "SELECT idpersonnel, nom, prenom, idservice FROM personnel";

            MySqlDataReader reader =
                bddManager.ReqSelect(requete);

            while (reader.Read())
            {
                Personnel personnel =
                    new Personnel(
                        (int)reader["idpersonnel"],
                        (string)reader["nom"],
                        (string)reader["prenom"],
                        (int)reader["idservice"]
                    );

                lesPersonnels.Add(personnel);
            }

            reader.Close();

            bddManager.CloseConnexion();

            return lesPersonnels;
        }

        public void AddPersonnel(Personnel personnel)
        {
            string requete =
                "INSERT INTO personnel(nom, prenom, idservice) " +
                "VALUES('" +
                personnel.Nom + "','" +
                personnel.Prenom + "'," +
                personnel.IdService + ")";

            bddManager = new BddManager();

            bddManager.ReqMaj(requete);

            bddManager.CloseConnexion();
        }

        public void DeletePersonnel(int id)
        {
            string requete =
                "DELETE FROM personnel " +
                "WHERE idpersonnel = " + id;

            bddManager = new BddManager();

            bddManager.ReqMaj(requete);

            bddManager.CloseConnexion();
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            string requete =
                "UPDATE personnel SET " +
                "nom = '" + personnel.Nom + "', " +
                "prenom = '" + personnel.Prenom + "', " +
                "idservice = " + personnel.IdService +
                " WHERE idpersonnel = " + personnel.Id;

            bddManager = new BddManager();

            bddManager.ReqMaj(requete);

            bddManager.CloseConnexion();
        }
    }
}