using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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