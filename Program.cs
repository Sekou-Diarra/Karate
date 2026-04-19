using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate
{
    /// <summary>
    /// Classe de démarrage de l'application Karaté.
    /// <para>
    /// Contient le point d'entrée principal (<c>Main</c>) qui initialise
    /// l'environnement Windows Forms et lance la fenêtre principale.
    /// </para>
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// <para>
        /// Configure le rendu visuel Windows Forms, puis ouvre le formulaire
        /// <see cref="Affectation"/> comme fenêtre principale de l'application.
        /// L'application reste active tant que cette fenêtre est ouverte.
        /// </para>
        /// </summary>
        /// <remarks>
        /// L'attribut <c>[STAThread]</c> est requis par Windows Forms pour garantir
        /// que l'application tourne dans un thread à appartement unique (Single-Threaded Apartment),
        /// nécessaire pour les interactions COM et les contrôles UI.
        /// </remarks>
        [STAThread]
        static void Main()
        {
            // Active les styles visuels Windows (thème moderne au lieu du look classique)
            Application.EnableVisualStyles();

            // Assure la compatibilité du rendu de texte avec GDI+ (meilleure fidélité visuelle)
            Application.SetCompatibleTextRenderingDefault(false);

            // Lance l'application avec le formulaire Affectation comme fenêtre principale.
            // L'application se termine lorsque cette fenêtre est fermée.
            Application.Run(new Affectation());
        }
    }
}
