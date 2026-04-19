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
    /// Formulaire de modification et de suppression d'un entraîneur existant.
    /// <para>
    /// Permet à l'utilisateur de sélectionner un entraîneur dans la liste,
    /// de charger ses informations (nom, prénom, club), de les modifier,
    /// puis de valider la mise à jour ou de supprimer l'entraîneur de la base.
    /// </para>
    /// <para>
    /// Accessible depuis le formulaire <see cref="menu"/> via le sous-menu
    /// « Modif/Supp entraîneur ».
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Au chargement : affiche la liste des numéros d'entraîneurs.</description></item>
    ///   <item><description>Bouton « Choisir » : charge le nom, prénom et club de l'entraîneur sélectionné.</description></item>
    ///   <item><description>Bouton « Modif » : met à jour les informations en base.</description></item>
    ///   <item><description>Bouton « Supp » : supprime l'entraîneur sélectionné.</description></item>
    ///   <item><description>Bouton « Fermer » : ferme le formulaire.</description></item>
    /// </list>
    /// </summary>
    public partial class modif_supp : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="modif_supp"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public modif_supp()
        {
            InitializeComponent();
        }

        /// <summary>Gestionnaire du clic sur une cellule du DataGridView entraîneurs (non utilisé).</summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>Gestionnaire du clic sur le label titre (non utilisé).</summary>
        private void label1_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Gestionnaire du bouton « Supp » — Suppression d'un entraîneur.
        /// <para>
        /// Supprime de la table <c>entraineur</c> l'entraîneur dont le numéro
        /// correspond à la ligne actuellement sélectionnée dans le DataGridView.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// DELETE FROM entraineur WHERE NUM_ENTRAINEUR = @numEntraineur
        /// </code>
        /// </para>
        /// <remarks>
        /// Cette suppression peut échouer si l'entraîneur est encore référencé
        /// dans la table <c>juge</c> (contrainte de clé étrangère).
        /// </remarks>
        /// </summary>
        /// <param name="sender">Le bouton « Supp » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            string requete = "DELETE FROM entraineur WHERE NUM_ENTRAINEUR = @numEntraineur";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Récupération du NUM_ENTRAINEUR depuis la ligne sélectionnée dans le DataGridView
            cmd.Parameters.AddWithValue("@numEntraineur", dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("éléments supprimer");
            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du clic sur une cellule du DataGridView des clubs.
        /// <para>
        /// Lorsque l'utilisateur clique sur une ligne du DataGridView 2 (clubs),
        /// le numéro de club correspondant est automatiquement renseigné dans le TextBox <c>textBox3</c>.
        /// </para>
        /// </summary>
        /// <param name="sender">Le DataGridView à l'origine de l'événement.</param>
        /// <param name="e">Contient l'index de la ligne et de la colonne cliquées.</param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            // Pré-remplissage du champ "Num" avec le numéro de club sélectionné
            textBox3.Text = row.Cells["NUM_CLUB"].Value.ToString();
        }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="modif_supp"/>.
        /// <para>
        /// Au chargement, récupère la liste de tous les numéros d'entraîneurs depuis
        /// la base de données et les affiche dans le DataGridView 1 pour la sélection.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT NUM_ENTRAINEUR FROM entraineur
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void modif_supp_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Chargement de la liste des entraîneurs (numéros uniquement)
            string requete = "select NUM_ENTRAINEUR from entraineur";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["NUM_ENTRAINEUR"]);
            }

            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Choisir » — Chargement des informations d'un entraîneur.
        /// <para>
        /// À partir du numéro d'entraîneur sélectionné dans le DataGridView 1,
        /// exécute une requête pour récupérer son nom, prénom et numéro de club,
        /// puis pré-remplit les champs de saisie correspondants.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT NOM_ENTRAINEUR, PRENOM_ENTRAINEUR, NUM_CLUB
        /// FROM entraineur
        /// WHERE NUM_ENTRAINEUR = @numEntraineur
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Choisir » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Vérification qu'une ligne est bien sélectionnée dans la liste des entraîneurs
            if (dataGridView1.CurrentRow != null)
            {
                // Récupération du numéro d'entraîneur sélectionné
                string numEntraineur = dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value.ToString();

                // Requête pour récupérer le nom, prénom et club de l'entraîneur sélectionné
                string req = "SELECT NOM_ENTRAINEUR, PRENOM_ENTRAINEUR, NUM_CLUB FROM entraineur WHERE NUM_ENTRAINEUR = @numEntraineur";
                MySqlCommand cm = new MySqlCommand(req, conn);
                cm.Parameters.AddWithValue("@numEntraineur", numEntraineur);

                MySqlDataReader reader1 = cm.ExecuteReader();
                if (reader1.Read())
                {
                    // Pré-remplissage des champs de saisie avec les données de l'entraîneur
                    textBox1.Text = reader1["NOM_ENTRAINEUR"].ToString();
                    textBox2.Text = reader1["PRENOM_ENTRAINEUR"].ToString();
                    dataGridView2.Rows.Add(reader1["NUM_CLUB"]); // Affichage du club actuel
                }

                reader1.Close();
            }
        }

        /// <summary>
        /// Gestionnaire du bouton « Modif » — Mise à jour d'un entraîneur.
        /// <para>
        /// Met à jour les informations (nom, prénom, numéro de club) de l'entraîneur
        /// sélectionné dans le DataGridView 1, avec les valeurs saisies dans les TextBox.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// UPDATE entraineur
        /// SET NUM_CLUB = @en, NOM_ENTRAINEUR = @ne, PRENOM_ENTRAINEUR = @pne
        /// WHERE NUM_ENTRAINEUR = @nme
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Modif » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            string requete = "UPDATE entraineur SET NUM_CLUB=@en, NOM_ENTRAINEUR=@ne, PRENOM_ENTRAINEUR=@pne WHERE NUM_ENTRAINEUR = @nme";
            MySqlCommand cm = new MySqlCommand(requete, conn);

            // Nouveau numéro de club (saisi ou sélectionné via dataGridView2)
            cm.Parameters.AddWithValue("@en", textBox3.Text);
            // Nouveau nom de l'entraîneur
            cm.Parameters.AddWithValue("@ne", textBox1.Text);
            // Nouveau prénom de l'entraîneur
            cm.Parameters.AddWithValue("@pne", textBox2.Text);
            // Identifiant de l'entraîneur à mettre à jour (sélectionné dans dataGridView1)
            cm.Parameters.AddWithValue("@nme", dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);

            cm.ExecuteNonQuery();
            MessageBox.Show("Infos modifiées");
            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Fermer » — Fermeture du formulaire.
        /// </summary>
        /// <param name="sender">Le bouton « Fermer » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
