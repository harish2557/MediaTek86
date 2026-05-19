using MySql.Data.MySqlClient;

namespace MediaTek86.modele.acces
{
    internal class BddManager
    {
        private MySqlConnection connexion;

        public BddManager()
        {
            connexion = Connexion.GetConnexion();
        }

        public MySqlDataReader ReqSelect(string requete)
        {
            connexion.Open();

            MySqlCommand commande =
                new MySqlCommand(requete, connexion);

            MySqlDataReader reader =
                commande.ExecuteReader();

            return reader;
        }

        public void CloseConnexion()
        {
            connexion.Close();
        }
    }
}