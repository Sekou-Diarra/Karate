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
    /// Formulaire principal de l'application — Affectation des entraîneurs comme jury.
    /// <para>
    /// C'est la première fenêtre affichée au lancement de l'application (voir <see cref="Program"/>).
    /// Elle permet d'affecter des entraîneurs en tant que jurés pour des compétitions données,
    /// et de gérer ces affectations (ajout, modification, suppression).
    /// </para>
    /// <para>
    /// Le formulaire est composé de deux DataGridViews :
    /// </para>
    /// <list type="bullet">
    ///   <item>
    ///     <description>
    ///       <b>DataGridView 2 (haut)</b> : liste des compétitions
    ///       (NUM_COMPETITION, NUM_CLUB, DATE_COMPETITION).
    ///     </description>
    ///   </item>
    ///   <item>
    ///     <description>
    ///       <b>DataGridView 3 (bas)</b> : liste des entraîneurs du club
    ///       associé à la compétition sélectionnée.
    ///     </description>
    ///   </item>
    /// </list>
    /// <para>Workflow typique :</para>
    /// <list type="number">
    ///   <item><description>Sélectionner une compétition dans le DataGridView 2.</description></item>
    ///   <item><description>Cliquer sur « Choisir » pour charger les entraîneurs du club organisateur.</description></item>
    ///   <item><description>Sélectionner un entraîneur dans le DataGridView 3.</description></item>
    ///   <item><description>Cliquer sur « Ajouter » pour l'affecter comme juré.</description></item>
    /// </list>
    /// </summary>
    public partial class Affectation : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="Affectation"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public Affectation()
        {
            InitializeComponent();
        }

        /// <summary>Gestionnaire du clic sur une cellule du DataGridView entraîneurs (non utilisé).</summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="Affectation"/>.
        /// <para>
        /// Au chargement, récupère toutes les compétitions depuis la base de données
        /// et les affiche dans le DataGridView 2 (en haut du formulaire).
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT * FROM competition
        /// </code>
        /// Colonnes affichées : NUM_COMPETITION, NUM_CLUB, DATE_COMPETITION.
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Affectation_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Chargement de toutes les compétitions pour alimenter la liste du haut
            string requete = "select * from competition";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView2.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader.Read())
            {
                // Affichage : numéro de compétition, club organisateur, date
                dataGridView2.Rows.Add(reader["NUM_COMPETITION"], reader["NUM_CLUB"], reader["DATE_COMPETITION"]);
            }

            reader.Close();
            conn.Close();
        }

        /// <summary>Gestionnaire du clic sur une cellule du DataGridView compétitions (non utilisé).</summary>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// Gestionnaire du bouton « Ajouter » — Affectation d'un entraîneur comme juré.
        /// <para>
        /// Affecte l'entraîneur sélectionné dans le DataGridView 3 comme juré
        /// pour la compétition sélectionnée dans le DataGridView 2.
        /// </para>
        /// <para>
        /// Le numéro de jury (NUM_JURY) est calculé automatiquement comme
        /// le maximum existant + 1 pour la compétition concernée.
        /// Si aucun jury n'existe encore, NUM_JURY vaut 0.
        /// </para>
        /// <para>
        /// Requêtes SQL exécutées :
        /// <code>
        /// -- 1. Calcul du prochain numéro de jury disponible
        /// SELECT MAX(NUM_JURY) FROM juge WHERE num_competition = @numop
        ///
        /// -- 2. Insertion de l'affectation
        /// INSERT INTO juge (NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY)
        /// VALUES (@numC, @ent, @numJ)
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Ajouter » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Aj_Click(object sender, EventArgs e)
        {
            int Maximum = 0; // Valeur par défaut si aucun jury n'existe pour cette compétition

            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Étape 1 : Calcul du prochain NUM_JURY disponible pour la compétition sélectionnée
            String req = "select MAX(NUM_JURY) from juge where num_competition=@numop";
            MySqlCommand cm = new MySqlCommand(req, conn);
            cm.Parameters.AddWithValue("@numop", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);

            // ExecuteScalar retourne une seule valeur (le MAX), ou DBNull si la table est vide
            object result = cm.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                Maximum = Convert.ToInt32(result) + 1; // Incrémentation du numéro de jury
            }

            // Étape 2 : Insertion de l'affectation entraîneur-compétition dans la table juge
            string requete = "insert into juge (NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY) values (@numC, @ent, @numJ);\r\n ";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Numéro de la compétition sélectionnée dans le DataGridView du haut
            cmd.Parameters.AddWithValue("@numC", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);
            // Numéro de l'entraîneur sélectionné dans le DataGridView du bas
            cmd.Parameters.AddWithValue("@ent", dataGridView3.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            // Numéro de jury auto-incrémenté
            cmd.Parameters.AddWithValue("@numJ", Maximum);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Informations ajoutées...");
            conn.Close();
        }

        /// <summary>Gestionnaire du clic sur le label (non utilisé).</summary>
        private void label1_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Gestionnaire du bouton « Modifier » — Ouverture du formulaire de modification de jury.
        /// <para>
        /// Ouvre le formulaire <see cref="Modification"/> en mode non-modal pour permettre
        /// la modification du numéro de jury d'un entraîneur affecté à une compétition.
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Modifier » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void modif_Click(object sender, EventArgs e)
        {
            Modification titi = new Modification();
            titi.Show();
        }

        /// <summary>
        /// Gestionnaire du bouton « Supprimer » — Suppression d'une affectation de juré.
        /// <para>
        /// Supprime de la table <c>juge</c> l'entrée correspondant à l'entraîneur
        /// sélectionné dans le DataGridView 3 pour la compétition sélectionnée dans le DataGridView 2.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// DELETE FROM juge
        /// WHERE NUM_ENTRAINEUR = @ent AND NUM_COMPETITION = @numC
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Supprimer » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void supp_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            string requete = "DELETE FROM juge WHERE NUM_ENTRAINEUR = @ent and NUM_COMPETITION = @numC";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Numéro de la compétition sélectionnée
            cmd.Parameters.AddWithValue("@numC", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);
            // Numéro de l'entraîneur sélectionné
            cmd.Parameters.AddWithValue("@ent", dataGridView3.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("éléments supprimer");
            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Choisir » — Filtrage des entraîneurs par club de la compétition.
        /// <para>
        /// Récupère le numéro de club de la compétition sélectionnée (colonne NUMERO = NUM_CLUB),
        /// puis charge dans le DataGridView 3 uniquement les entraîneurs appartenant à ce club.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT * FROM entraineur WHERE NUM_CLUB = @numcomp
        /// </code>
        /// </para>
        /// <remarks>
        /// La colonne "NUMERO" dans le DataGridView 2 correspond à la colonne NUM_CLUB
        /// de la compétition (alias défini dans le Designer).
        /// </remarks>
        /// </summary>
        /// <param name="sender">Le bouton « Choisir » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void choisir_Click(object sender, EventArgs e)
        {
            // Récupération du NUM_CLUB depuis la colonne "NUMERO" du DataGridView compétitions
            string numCompetition = dataGridView2.CurrentRow.Cells["NUMERO"].Value.ToString();

            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Filtrage des entraîneurs appartenant au club organisateur de la compétition
            string requete = "select * from entraineur where NUM_CLUB=@numcomp";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.Parameters.AddWithValue("@numcomp", numCompetition);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView3.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader.Read())
            {
                // Affichage : numéro d'entraîneur, club, nom, prénom
                dataGridView3.Rows.Add(reader["NUM_ENTRAINEUR"], reader["NUM_CLUB"], reader["NOM_ENTRAINEUR"], reader["PRENOM_ENTRAINEUR"]);
            }

            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Fermer » — Fermeture du formulaire.
        /// </summary>
        /// <param name="sender">Le bouton « Fermer » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
