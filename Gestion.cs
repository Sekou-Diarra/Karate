using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate
{
    /// <summary>
    /// Formulaire de gestion des entraîneurs — Ajout d'un nouvel entraîneur.
    /// <para>
    /// Permet à l'utilisateur de saisir les informations d'un entraîneur (identifiant,
    /// nom, prénom) et de le rattacher à un club existant sélectionné dans une liste.
    /// L'entraîneur est ensuite inséré dans la table <c>entraineur</c> de la base de données.
    /// </para>
    /// <para>
    /// Accessible depuis le formulaire <see cref="menu"/> via le sous-menu
    /// « Ajout d'un entraîneur ».
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Au chargement : affiche la liste de tous les clubs disponibles.</description></item>
    ///   <item><description>Bouton « Ajouter » : insère le nouvel entraîneur en base.</description></item>
    ///   <item><description>Bouton « Fermer » : ferme le formulaire.</description></item>
    /// </list>
    /// </summary>
    public partial class Gestion : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="Gestion"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public Gestion()
        {
            InitializeComponent();
        }

        // ───────────────────────────────────────────────────────────────────────
        // Gestionnaires d'événements des labels (non utilisés fonctionnellement)
        // ───────────────────────────────────────────────────────────────────────

        /// <summary>Gestionnaire du clic sur le label « Nom » (non utilisé).</summary>
        private void label1_Click(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du changement de texte du TextBox club (non utilisé).</summary>
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du clic sur le label titre (non utilisé).</summary>
        private void label5_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Gestionnaire du clic sur le bouton « Ajouter ».
        /// <para>
        /// Récupère les valeurs saisies (numéro, nom, prénom) et le club sélectionné
        /// dans le DataGridView, puis insère un nouvel entraîneur dans la base de données.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// INSERT INTO entraineur (NUM_ENTRAINEUR, NUM_CLUB, NOM_ENTRAINEUR, PRENOM_ENTRAINEUR)
        /// VALUES (@num, @club, @nom, @prenom)
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Ajouter » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Requête d'insertion d'un nouvel entraîneur
            string requete = "insert into entraineur (NUM_ENTRAINEUR, NUM_CLUB, NOM_ENTRAINEUR, PRENOM_ENTRAINEUR) values (@num, @club, @nom, @prenom);\r\n ";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Paramètre : numéro d'entraîneur saisi manuellement
            cmd.Parameters.AddWithValue("@num", numero.Text);
            // Paramètre : numéro de club récupéré depuis la ligne sélectionnée dans le DataGridView
            cmd.Parameters.AddWithValue("@club", dataGridView1.CurrentRow.Cells["NUM_CLUB"].Value);
            // Paramètre : nom de l'entraîneur
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            // Paramètre : prénom de l'entraîneur
            cmd.Parameters.AddWithValue("@prenom", prenom.Text);

            cmd.ExecuteNonQuery(); // Exécution de la requête INSERT
            MessageBox.Show("Informations ajoutées...");
            conn.Close();
        }

        /// <summary>Gestionnaire du clic sur le label ID (non utilisé).</summary>
        private void label4_Click(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du changement du TextBox numéro (non utilisé).</summary>
        private void textBox4_TextChanged(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du changement du TextBox nom (non utilisé).</summary>
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du clic sur le label prénom (non utilisé).</summary>
        private void label2_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Gestionnaire du clic sur le bouton « Fermer ».
        /// Ferme le formulaire courant.
        /// </summary>
        /// <param name="sender">Le bouton « Fermer » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Gestionnaire du clic sur le label club (non utilisé).</summary>
        private void label3_Click(object sender, EventArgs e) { }

        /// <summary>Gestionnaire du clic sur une cellule du DataGridView des clubs (non utilisé).</summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>Gestionnaire du changement du TextBox prénom (non utilisé).</summary>
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="Gestion"/>.
        /// <para>
        /// Au chargement, récupère la liste de tous les clubs depuis la base de données
        /// et les affiche dans le DataGridView pour permettre la sélection du club de rattachement.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT NUM_CLUB, NOM_CLUB, ADR_VILLE_CLUB, CODE_POST_CLUB FROM club
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Récupération de tous les clubs pour alimenter la liste de sélection
            string requete = "select NUM_CLUB, NOM_CLUB, ADR_VILLE_CLUB, CODE_POST_CLUB from club";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear(); // Réinitialisation du DataGridView avant remplissage

            while (reader.Read())
            {
                // Ajout d'une ligne par club : numéro, nom, ville, code postal
                dataGridView1.Rows.Add(reader["NUM_CLUB"], reader["NOM_CLUB"], reader["ADR_VILLE_CLUB"], reader["CODE_POST_CLUB"]);
            }

            conn.Close();
        }
    }
}
