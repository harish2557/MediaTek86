using MySql.Data.MySqlClient;

namespace MediaTek86.modele.acces
{
    internal class BddManager
    {
        private MySqlConnection connexion;

        public BddManager()
        {
            connexion = Connexion.GetConnexion();

            connexion.Open();
        }

        public MySqlDataReader ReqSelect(string requete)
        {
            if (connexion.State !=
                System.Data.ConnectionState.Open)
            {
                connexion.Open();
            }

            MySqlCommand commande =
                new MySqlCommand(
                    requete,
                    connexion
                );

            return commande.ExecuteReader();
        }

        public void ReqMaj(string requete)
        {
            if (connexion.State !=
                System.Data.ConnectionState.Open)
            {
                connexion.Open();
            }

            MySqlCommand commande =
                new MySqlCommand(
                    requete,
                    connexion
                );

            commande.ExecuteNonQuery();
        }

        public void CloseConnexion()
        {
            if (connexion != null)
            {
                connexion.Close();
            }
        }
    }
}