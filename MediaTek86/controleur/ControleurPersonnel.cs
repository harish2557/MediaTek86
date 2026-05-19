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
                "SELECT idpersonnel, nom, prenom, idservice  FROM personnel";

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
    }
}