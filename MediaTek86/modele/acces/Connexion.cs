using MySql.Data.MySqlClient;

namespace MediaTek86.modele.acces
{
    internal class Connexion
    {
        private static string chaineConnexion =
            "server=localhost;database=mediatek86;uid=root;pwd=";

        public static MySqlConnection GetConnexion()
        {
            MySqlConnection connexion =
                new MySqlConnection(chaineConnexion);

            return connexion;
        }
    }
}