namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="Affectation"/>.
    /// <para>
    /// Ce fichier est auto-généré par le Concepteur Windows Forms de Visual Studio.
    /// Il contient la déclaration et l'initialisation graphique de tous les contrôles
    /// du formulaire d'affectation des entraîneurs comme jury.
    /// </para>
    /// <remarks>
    /// NE PAS MODIFIER CE FICHIER MANUELLEMENT. Toute modification doit être effectuée
    /// via le Concepteur de formulaires Visual Studio, sous peine d'être écrasée
    /// lors d'une régénération ou de provoquer des erreurs de compilation.
    /// </remarks>
    /// </summary>
    partial class Affectation
    {
        /// <summary>
        /// Variable de composant requise par le Concepteur Windows Forms.
        /// Gère le cycle de vie des composants ajoutés via le designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources managées et non managées utilisées par le formulaire.
        /// Appelé automatiquement à la fermeture/destruction du formulaire.
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> pour libérer les ressources managées ; <c>false</c> sinon.
        /// </param>
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
        /// Méthode d'initialisation des composants, requise par le Concepteur Windows Forms.
        /// <para>
        /// Configure et positionne tous les contrôles du formulaire :
        /// </para>
        /// <list type="bullet">
        ///   <item><description><b>dataGridView2</b> : grille des compétitions (en haut, 515×150 px)</description></item>
        ///   <item><description><b>dataGridView3</b> : grille des entraîneurs/jurés (en bas, 515×177 px)</description></item>
        ///   <item><description><b>Aj</b> : bouton « Ajouter » un juré</description></item>
        ///   <item><description><b>modif</b> : bouton « Modifier » ouvre le formulaire Modification</description></item>
        ///   <item><description><b>supp</b> : bouton « Supprimer » un juré</description></item>
        ///   <item><description><b>choisir</b> : bouton « Choisir » filtre les entraîneurs par club</description></item>
        ///   <item><description><b>button1</b> : bouton « Fermer »</description></item>
        /// </list>
        /// <remarks>Ne pas modifier le contenu de cette méthode avec l'éditeur de code.</remarks>
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aj = new System.Windows.Forms.Button();
            this.modif = new System.Windows.Forms.Button();
            this.supp = new System.Windows.Forms.Button();
            this.choisir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // dataGridView3 — Grille des entraîneurs disponibles (bas du formulaire)
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_ENTRAINEUR,
            this.NUM_CLUB,
            this.NOM_ENTRAINEUR,
            this.PRENOM_ENTRAINEUR});
            this.dataGridView3.Location = new System.Drawing.Point(12, 180);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(515, 177);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // Colonne NUM_ENTRAINEUR — Identifiant de l'entraîneur
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINER";
            this.NUM_ENTRAINEUR.MinimumWidth = 8;
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Width = 150;
            // Colonne NUM_CLUB — Club d'appartenance de l'entraîneur
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // Colonne NOM_ENTRAINEUR — Nom de famille de l'entraîneur
            this.NOM_ENTRAINEUR.HeaderText = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.MinimumWidth = 8;
            this.NOM_ENTRAINEUR.Name = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.Width = 150;
            // Colonne PRENOM_ENTRAINEUR — Prénom de l'entraîneur
            this.PRENOM_ENTRAINEUR.HeaderText = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.MinimumWidth = 8;
            this.PRENOM_ENTRAINEUR.Name = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.Width = 150;
            // dataGridView2 — Grille des compétitions (haut du formulaire)
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUMERO,
            this.DATE_COMPETITION});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(515, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // Colonne NUM_COMPETITION — Identifiant unique de la compétition
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 150;
            // Colonne NUMERO (alias NUM_CLUB) — Club organisateur de la compétition
            // NOTE : nommée "NUMERO" en interne mais affiche "NUM_CLUB" dans l'en-tête
            this.NUMERO.HeaderText = "NUM_CLUB";
            this.NUMERO.MinimumWidth = 8;
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Width = 150;
            // Colonne DATE_COMPETITION — Date à laquelle se déroule la compétition
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.MinimumWidth = 8;
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.Width = 150;
            // Bouton Aj — Ajouter l'entraîneur sélectionné comme juré
            this.Aj.Location = new System.Drawing.Point(12, 425);
            this.Aj.Name = "Aj";
            this.Aj.Size = new System.Drawing.Size(92, 35);
            this.Aj.TabIndex = 2;
            this.Aj.Text = "Ajouter";
            this.Aj.UseVisualStyleBackColor = true;
            this.Aj.Click += new System.EventHandler(this.Aj_Click);
            // Bouton modif — Ouvrir le formulaire Modification pour modifier un juré
            this.modif.Location = new System.Drawing.Point(186, 425);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(96, 35);
            this.modif.TabIndex = 5;
            this.modif.Text = "modifier";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // Bouton supp — Supprimer l'affectation de jury sélectionnée
            this.supp.Location = new System.Drawing.Point(324, 425);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(109, 35);
            this.supp.TabIndex = 6;
            this.supp.Text = "supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // Bouton choisir — Filtrer les entraîneurs du club de la compétition sélectionnée
            this.choisir.Location = new System.Drawing.Point(486, 425);
            this.choisir.Name = "choisir";
            this.choisir.Size = new System.Drawing.Size(97, 35);
            this.choisir.TabIndex = 7;
            this.choisir.Text = "choisir ";
            this.choisir.UseVisualStyleBackColor = true;
            this.choisir.Click += new System.EventHandler(this.choisir_Click);
            // Bouton button1 — Fermer le formulaire
            this.button1.Location = new System.Drawing.Point(638, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // Formulaire Affectation — Fenêtre principale de l'application
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choisir);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.Aj);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Affectation";
            this.Text = "Affectation des entraineurs comme jury";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Déclarations des contrôles du formulaire ──────────────────────────

        /// <summary>Grille affichant les entraîneurs disponibles pour le club sélectionné.</summary>
        private System.Windows.Forms.DataGridView dataGridView3;

        /// <summary>Grille affichant toutes les compétitions disponibles.</summary>
        private System.Windows.Forms.DataGridView dataGridView2;

        /// <summary>Bouton pour ajouter l'entraîneur sélectionné en tant que juré.</summary>
        private System.Windows.Forms.Button Aj;

        /// <summary>Colonne NUM_COMPETITION de la grille des compétitions.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;

        /// <summary>Colonne NUMERO (NUM_CLUB) de la grille des compétitions — club organisateur.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;

        /// <summary>Colonne DATE_COMPETITION de la grille des compétitions.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;

        /// <summary>Bouton pour ouvrir le formulaire de modification d'un jury.</summary>
        private System.Windows.Forms.Button modif;

        /// <summary>Bouton pour supprimer l'affectation de jury sélectionnée.</summary>
        private System.Windows.Forms.Button supp;

        /// <summary>Bouton pour filtrer les entraîneurs selon le club de la compétition choisie.</summary>
        private System.Windows.Forms.Button choisir;

        /// <summary>Colonne NUM_ENTRAINEUR de la grille des entraîneurs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;

        /// <summary>Colonne NUM_CLUB de la grille des entraîneurs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;

        /// <summary>Colonne NOM_ENTRAINEUR de la grille des entraîneurs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ENTRAINEUR;

        /// <summary>Colonne PRENOM_ENTRAINEUR de la grille des entraîneurs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_ENTRAINEUR;

        /// <summary>Bouton pour fermer le formulaire.</summary>
        private System.Windows.Forms.Button button1;
    }
}
