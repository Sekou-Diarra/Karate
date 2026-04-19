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
    /// Formulaire de modification du numéro de jury d'un entraîneur affecté à une compétition.
    /// <para>
    /// Ce formulaire est accessible depuis le bouton « Modifier » du formulaire <see cref="Affectation"/>.
    /// Il affiche la liste de tous les jurés existants et permet de modifier
    /// le <c>NUM_JURY</c> d'un entraîneur pour une compétition donnée.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Au chargement : affiche tous les enregistrements de la table <c>juge</c>.</description></item>
    ///   <item>
    ///     <description>
    ///       Clic sur une cellule : pré-remplit le champ <c>numju</c> avec le NUM_JURY de la ligne.
    ///     </description>
    ///   </item>
    ///   <item><description>Bouton « Modif » : met à jour le NUM_JURY en base de données.</description></item>
    ///   <item><description>Bouton « Fermer » : ferme le formulaire.</description></item>
    /// </list>
    /// </summary>
    public partial class Modification : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="Modification"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public Modification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire du clic sur une cellule du DataGridView des jurés.
        /// <para>
        /// Lorsque l'utilisateur clique sur une cellule, le <c>NUM_JURY</c>
        /// de la ligne correspondante est chargé dans le TextBox <c>numju</c>
        /// pour permettre sa modification.
        /// </para>
        /// </summary>
        /// <param name="sender">Le DataGridView à l'origine de l'événement.</param>
        /// <param name="e">Contient l'index de la ligne et de la colonne cliquées.</param>
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
            // Pré-remplissage du champ de modification avec le NUM_JURY de la ligne sélectionnée
            numju.Text = row.Cells["NUM_JURY"].Value.ToString();
        }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="Modification"/>.
        /// <para>
        /// Au chargement, récupère tous les enregistrements de la table <c>juge</c>
        /// et les affiche dans le DataGridView 4.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// SELECT NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY FROM juge
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Modification_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            // Chargement de tous les jurés pour affichage et sélection
            string requete = "SELECT NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY FROM juge ";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader3 = cmd.ExecuteReader();

            dataGridView4.Rows.Clear(); // Réinitialisation avant remplissage

            while (reader3.Read())
            {
                // Affichage : compétition, entraîneur, numéro de jury
                dataGridView4.Rows.Add(reader3["NUM_COMPETITION"], reader3["NUM_ENTRAINEUR"], reader3["NUM_JURY"]);
            }

            conn.Close();
        }

        /// <summary>
        /// Gestionnaire du bouton « Modif » — Mise à jour du numéro de jury.
        /// <para>
        /// Met à jour le champ <c>NUM_JURY</c> dans la table <c>juge</c> pour
        /// l'entraîneur et la compétition sélectionnés dans le DataGridView,
        /// avec la valeur saisie dans le TextBox <c>numju</c>.
        /// </para>
        /// <para>
        /// Requête SQL exécutée :
        /// <code>
        /// UPDATE juge
        /// SET NUM_JURY = @numj
        /// WHERE NUM_COMPETITION = @id AND NUM_ENTRAINEUR = @ide
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="sender">Le bouton « Modif » à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void Modif_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();

            string requete = "UPDATE juge SET NUM_JURY = @numj WHERE NUM_COMPETITION=@id and NUM_ENTRAINEUR=@ide";
            MySqlCommand cmd = new MySqlCommand(requete, conn);

            // Nouveau numéro de jury saisi par l'utilisateur
            cmd.Parameters.AddWithValue("@numj", numju.Text);
            // Clé composite : numéro de compétition de la ligne sélectionnée
            cmd.Parameters.AddWithValue("@id", dataGridView4.CurrentRow.Cells["NUM_COMPETITION"].Value);
            // Clé composite : numéro d'entraîneur de la ligne sélectionnée
            cmd.Parameters.AddWithValue("@ide", dataGridView4.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Modif éffectuée!");
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
