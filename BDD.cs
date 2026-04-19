using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate
{
    /// <summary>
    /// Classe utilitaire centralisant la connexion à la base de données MySQL.
    /// <para>
    /// Toutes les autres classes du projet utilisent cette classe pour obtenir
    /// une instance de connexion prête à l'emploi.
    /// </para>
    /// <remarks>
    /// ATTENTION : La chaîne de connexion utilise un compte root sans mot de passe.
    /// En production, il est impératif de sécuriser l'accès (mot de passe fort,
    /// utilisateur dédié avec droits minimaux, variables d'environnement).
    /// </remarks>
    /// </summary>
    internal class BDD
    {
        /// <summary>
        /// Crée et retourne une connexion MySQL configurée pour la base de données "karate".
        /// <para>
        /// La connexion est retournée fermée. L'appelant est responsable de l'ouvrir
        /// via <c>conn.Open()</c> et de la fermer via <c>conn.Close()</c> après utilisation.
        /// </para>
        /// </summary>
        /// <returns>
        /// Une instance de <see cref="MySqlConnection"/> configurée mais non ouverte,
        /// pointant sur la base de données <c>karate</c> du serveur <c>localhost</c>.
        /// </returns>
        /// <example>
        /// Exemple d'utilisation typique :
        /// <code>
        /// MySqlConnection conn = BDD.ConnectBD();
        /// conn.Open();
        /// // ... exécution de requêtes ...
        /// conn.Close();
        /// </code>
        /// </example>
        public static MySqlConnection ConnectBD()
        {
            // Chaîne de connexion vers la base MySQL locale
            // SERVER   : adresse du serveur MySQL (localhost = machine courante)
            // DATABASE : nom de la base de données ciblée
            // UID      : nom d'utilisateur MySQL
            // PASSWORD : mot de passe (vide en développement local)
            string connectionString = "SERVER=localhost; DATABASE=karate; UID=root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
