using MySql.Data.MySqlClient;
using MediaTek86.modele.acces;

namespace MediaTek86.modele.dal
{
    internal class AccessPersonnel
    {
        private static MySqlConnection connexion =
            Connexion.GetConnexion();
    }
}