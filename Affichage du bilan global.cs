using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate
{
    /// <summary>
    /// Formulaire d'affichage du bilan global d'un membre.
    /// <para>
    /// Permet de consulter l'historique de participation et les notes globales
    /// d'un membre pour toutes les compétitions auxquelles il s'est inscrit.
    /// </para>
    /// <para>
    /// Le formulaire est composé de deux DataGridViews :
    /// </para>
    /// <list type="bullet">
    ///   <item>
    ///     <description>
    ///       <b>DataGridView 1 (haut)</b> : liste de tous les membres
    ///       (NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE).
    ///     </description>
    ///   </item>
    ///   <item>
    ///     <description>
    ///       <b>DataGridView 2 (bas)</b> : résultats du membre sélectionné
    ///       (NUM_COMPETITION, DATE_COMPETITION, NOTE_GLOBALE).
    ///     </description>
    ///   </item>
    /// </list>
    /// <para>Workflow typique :</para>
    /// <list type="number">
    ///   <item><description>Sélectionner un membre dans le DataGridView 1.</description></item>
    ///   <item><description>Cliquer sur « Choisir » pour charger ses résultats dans le DataGridView 2.</description></item>
    /// </list>
    /// </summary>
    public partial class Affichage_du_bilan_global : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="Affichage_du_bilan_global"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public Affichage_du_bilan_global()
        {
            InitializeComponent();
        }

        /// <summary>Gestionnaire du clic sur une cellule du DataGridView membres (non utilisé).</summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// Gestionnaire du bouton « Fermer » — Fermeture du formulaire.
        /// </summary>
        /// <param name="sender">Le bouton « Fermer » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Choisir » — Chargement du bilan d'un membre.
        /// <para>
        /// À partir du numéro de licence du membre sélectionné dans le DataGridView 1,
        /// exécute une requête de jointure pour récupérer toutes ses participations
        /// et notes globales, puis affiche les résultats dans le DataGridView 2.
        /// </para>
        /// <para>
        /// Requête SQL exécutée (jointure triple) :
        /// <code>
        /// SELECT inscription.NUM_COMPETITION,
        ///        competition.DATE_COMPETITION,
        ///        inscription.NOTE_GLOBALE
        /// FROM membre
        /// INNER JOIN inscription ON inscription.NUM_LICENCE = membre.NUM_LICENCE
        /// INNER JOIN competition ON inscription.NUM_COMPETITION = competition.NUM_COMPETITION
        /// WHERE membre.NUM_LICENCE = @licence
        /// </code>
        /// </para>
        /// <para>
        /// Cette requête joint trois tables :
        /// <list type="bullet">
        ///   <item><description><c>membre</c> → source du filtre par licence</description></item>
        ///   <item><description><c>inscription</c> → table de liaison membre-compétition avec la note</description></item>
        ///   <item><description><c>competition</c> → pour récupérer la date de la compétition</description></item>
        /// </list>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Choisir » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void choix_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Jointure membre → inscription → competition pour récupérer le bilan complet du membre
            string requete = "select inscription.NUM_COMPETITION, competition.DATE_COMPETITION, inscription.NOTE_GLOBALE " +
                             "from membre " +
                             "inner join inscription on inscription.NUM_LICENCE=membre.NUM_LICENCE " +
                             "inner join competition on inscription.NUM_COMPETITION = competition.NUM_COMPETITION " +
                             "where membre.NUM_LICENCE=@licence";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Filtrage sur le numéro de licence du membre sélectionné dans le DataGridView 1
            cmd.Parameters.AddWithValue("@licence", dataGridView1.CurrentRow.Cells["NUM_LICENCE"].Value);

            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView2.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader.Read())
            {
                // Affichage : numéro de compétition, date de la compétition, note globale obtenue
                dataGridView2.Rows.Add(reader["NUM_COMPETITION"], reader["DATE_COMPETITION"], reader["NOTE_GLOBALE"]);
            }

            conn.Close();
        }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="Affichage_du_bilan_global"/>.
        /// <para>
        /// Au chargement, récupère la liste de tous les membres depuis la base de données
        /// et les affiche dans le DataGridView 1 pour permettre la sélection.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT * FROM membre
        /// </code>
        /// Colonnes affichées : NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE.
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Affichage_du_bilan_global_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Chargement de tous les membres pour alimenter la liste de sélection
            string requete = "select * from membre";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader.Read())
            {
                // Affichage : numéro de licence, club, nom, prénom
                dataGridView1.Rows.Add(reader["NUM_LICENCE"], reader["NUM_CLUB"], reader["NOM_MEMBRE"], reader["PRENOM_MEMBRE"]);
            }

            conn.Close();
        }
    }
}
