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
    /// Formulaire de navigation principale de l'application Karaté.
    /// <para>
    /// Affiche une barre de menus permettant d'accéder aux différentes fonctionnalités
    /// de gestion des entraîneurs. Ce formulaire sert de point central de navigation.
    /// </para>
    /// <list type="bullet">
    ///   <item>
    ///     <description>
    ///       Menu « Gestion des entraîneurs » → « Ajout d'un entraîneur » :
    ///       ouvre le formulaire <see cref="Gestion"/> pour saisir un nouvel entraîneur.
    ///     </description>
    ///   </item>
    ///   <item>
    ///     <description>
    ///       Menu « Gestion des entraîneurs » → « Modif/Supp entraîneur » :
    ///       ouvre le formulaire <see cref="modif_supp"/> pour modifier ou supprimer un entraîneur.
    ///     </description>
    ///   </item>
    /// </list>
    /// </summary>
    public partial class menu : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire <see cref="menu"/>.
        /// Appelle <c>InitializeComponent()</c> pour construire les contrôles générés
        /// par le concepteur Windows Forms.
        /// </summary>
        public menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire du clic sur l'élément de menu « Ajout d'un entraîneur ».
        /// <para>
        /// Ouvre une nouvelle instance du formulaire <see cref="Gestion"/> en mode non-modal
        /// (<c>Show()</c>), permettant à l'utilisateur d'ajouter un nouvel entraîneur
        /// tout en laissant le menu accessible.
        /// </para>
        /// </summary>
        /// <param name="sender">L'élément de menu à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void ajoutDunEntraineurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciation et affichage du formulaire d'ajout d'entraîneur
            Gestion gestion_form = new Gestion();
            gestion_form.Show();
        }

        /// <summary>
        /// Gestionnaire de l'événement de chargement du formulaire <see cref="menu"/>.
        /// <para>
        /// Actuellement vide — aucune initialisation n'est nécessaire au chargement.
        /// </para>
        /// </summary>
        /// <param name="sender">Le formulaire à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void menu_Load(object sender, EventArgs e)
        {
            // Aucune initialisation requise au chargement de ce formulaire
        }

        /// <summary>
        /// Gestionnaire du clic sur l'élément de menu « Modif/Supp entraîneur ».
        /// <para>
        /// Ouvre une nouvelle instance du formulaire <see cref="modif_supp"/> en mode non-modal,
        /// permettant à l'utilisateur de modifier ou de supprimer un entraîneur existant.
        /// </para>
        /// </summary>
        /// <param name="sender">L'élément de menu à l'origine de l'événement.</param>
        /// <param name="e">Données de l'événement (non utilisées ici).</param>
        private void modifsuppEntraineurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciation et affichage du formulaire de modification/suppression d'entraîneur
            modif_supp modif_form = new modif_supp();
            modif_form.Show();
        }
    }
}
