namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="Affichage_du_bilan_global"/>.
    /// <para>
    /// Contient la déclaration et la configuration graphique de tous les contrôles
    /// du formulaire de consultation du bilan global des membres.
    /// </para>
    /// <remarks>
    /// NE PAS MODIFIER CE FICHIER MANUELLEMENT. Utiliser le Concepteur de formulaires Visual Studio.
    /// </remarks>
    /// </summary>
    partial class Affichage_du_bilan_global
    {
        /// <summary>Variable de composant requise par le Concepteur Windows Forms.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources managées et non managées utilisées par le formulaire.
        /// </summary>
        /// <param name="disposing"><c>true</c> pour libérer les ressources managées.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Initialise et positionne tous les contrôles du formulaire.
        /// <list type="bullet">
        ///   <item><description><b>dataGridView1</b> : grille des membres (469×191 px, en haut)</description></item>
        ///   <item><description><b>dataGridView2</b> : grille des résultats du membre sélectionné (469×210 px, en bas)</description></item>
        ///   <item><description><b>choix</b> : bouton « Choisir » — charge les résultats du membre</description></item>
        ///   <item><description><b>button2</b> : bouton « Fermer »</description></item>
        /// </list>
        /// <remarks>Ne pas modifier avec l'éditeur de code.</remarks>
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choix = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // dataGridView1 — Liste de tous les membres
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LICENCE, this.NUM_CLUB, this.NOM_MEMBRE, this.PRENOM_MEMBRE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(469, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // Colonne NUM_LICENCE — Numéro de licence unique du membre
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 8;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 150;
            // Colonne NUM_CLUB — Club d'appartenance du membre
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // Colonne NOM_MEMBRE — Nom de famille du membre
            this.NOM_MEMBRE.HeaderText = "NOM_MEMBRE";
            this.NOM_MEMBRE.MinimumWidth = 8;
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.Width = 150;
            // Colonne PRENOM_MEMBRE — Prénom du membre
            this.PRENOM_MEMBRE.HeaderText = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.MinimumWidth = 8;
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Width = 150;
            // dataGridView2 — Résultats (compétitions + notes) du membre sélectionné
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION, this.DATE_COMPETITION, this.NOTE_GLOBALE});
            this.dataGridView2.Location = new System.Drawing.Point(12, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(469, 210);
            this.dataGridView2.TabIndex = 1;
            // Colonne NUM_COMPETITION — Identifiant de la compétition
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 150;
            // Colonne DATE_COMPETITION — Date de la compétition
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.MinimumWidth = 8;
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.Width = 150;
            // Colonne NOTE_GLOBALE — Note globale obtenue par le membre à cette compétition
            this.NOTE_GLOBALE.HeaderText = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.MinimumWidth = 8;
            this.NOTE_GLOBALE.Name = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.Width = 150;
            // Bouton choix — Charger les résultats du membre sélectionné dans dataGridView2
            this.choix.Location = new System.Drawing.Point(648, 141);
            this.choix.Name = "choix";
            this.choix.Size = new System.Drawing.Size(92, 37);
            this.choix.TabIndex = 2;
            this.choix.Text = "choisir";
            this.choix.UseVisualStyleBackColor = true;
            this.choix.Click += new System.EventHandler(this.choix_Click);
            // Bouton button2 — Fermer le formulaire
            this.button2.Location = new System.Drawing.Point(648, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // Formulaire Affichage_du_bilan_global — 800x450 px
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.choix);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Affichage_du_bilan_global";
            this.Text = "Affichage_du_bilan_global";
            this.Load += new System.EventHandler(this.Affichage_du_bilan_global_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        /// <summary>Grille listant tous les membres de la base.</summary>
        private System.Windows.Forms.DataGridView dataGridView1;
        /// <summary>Colonne NUM_LICENCE — numéro de licence du membre.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        /// <summary>Colonne NUM_CLUB — club du membre.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        /// <summary>Colonne NOM_MEMBRE — nom du membre.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        /// <summary>Colonne PRENOM_MEMBRE — prénom du membre.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        /// <summary>Grille affichant les résultats (compétitions et notes) du membre sélectionné.</summary>
        private System.Windows.Forms.DataGridView dataGridView2;
        /// <summary>Colonne NUM_COMPETITION — numéro de la compétition.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        /// <summary>Colonne DATE_COMPETITION — date de la compétition.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        /// <summary>Colonne NOTE_GLOBALE — note obtenue par le membre.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        /// <summary>Bouton déclenchant le chargement des résultats du membre sélectionné.</summary>
        private System.Windows.Forms.Button choix;
        /// <summary>Bouton de fermeture du formulaire.</summary>
        private System.Windows.Forms.Button button2;
    }
}
