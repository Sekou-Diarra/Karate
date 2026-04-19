namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="Gestion"/>.
    /// <para>Contient la configuration graphique de tous les contrôles du formulaire d'ajout d'entraîneur.</para>
    /// <remarks>NE PAS MODIFIER MANUELLEMENT. Utiliser le Concepteur de formulaires Visual Studio.</remarks>
    /// </summary>
    partial class Gestion
    {
        /// <summary>Variable de composant requise par le Concepteur Windows Forms.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Libère les ressources managées et non managées du formulaire.</summary>
        /// <param name="disposing"><c>true</c> pour libérer les ressources managées.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Initialise et positionne tous les contrôles du formulaire.
        /// <list type="bullet">
        ///   <item><description><b>nomentraineur</b> : label "Nom :"</description></item>
        ///   <item><description><b>prenomentraineur</b> : label "Prenom :"</description></item>
        ///   <item><description><b>numeroclub</b> : label "ID :"</description></item>
        ///   <item><description><b>club</b> : label "Club :"</description></item>
        ///   <item><description><b>nom</b> : TextBox saisie du nom de l'entraîneur</description></item>
        ///   <item><description><b>prenom</b> : TextBox saisie du prénom</description></item>
        ///   <item><description><b>numero</b> : TextBox saisie du numéro d'entraîneur</description></item>
        ///   <item><description><b>label5</b> : titre "Gestion des entraineurs"</description></item>
        ///   <item><description><b>dataGridView1</b> : liste des clubs pour sélection (603×150 px)</description></item>
        ///   <item><description><b>add</b> : bouton "Ajouter"</description></item>
        ///   <item><description><b>fermer</b> : bouton "Fermer"</description></item>
        /// </list>
        /// </summary>
        private void InitializeComponent()
        {
            this.nomentraineur = new System.Windows.Forms.Label();
            this.prenomentraineur = new System.Windows.Forms.Label();
            this.club = new System.Windows.Forms.Label();
            this.numeroclub = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // Label nomentraineur — étiquette du champ Nom
            this.nomentraineur.AutoSize = true;
            this.nomentraineur.Location = new System.Drawing.Point(12, 134);
            this.nomentraineur.Name = "nomentraineur";
            this.nomentraineur.Size = new System.Drawing.Size(50, 20);
            this.nomentraineur.TabIndex = 0;
            this.nomentraineur.Text = "Nom :";
            this.nomentraineur.Click += new System.EventHandler(this.label1_Click);
            // Label prenomentraineur — étiquette du champ Prénom
            this.prenomentraineur.AutoSize = true;
            this.prenomentraineur.Location = new System.Drawing.Point(12, 189);
            this.prenomentraineur.Name = "prenomentraineur";
            this.prenomentraineur.Size = new System.Drawing.Size(72, 20);
            this.prenomentraineur.TabIndex = 1;
            this.prenomentraineur.Text = "Prenom :";
            this.prenomentraineur.Click += new System.EventHandler(this.label2_Click);
            // Label club — étiquette du champ Club
            this.club.AutoSize = true;
            this.club.Location = new System.Drawing.Point(12, 304);
            this.club.Name = "club";
            this.club.Size = new System.Drawing.Size(49, 20);
            this.club.TabIndex = 2;
            this.club.Text = "Club :";
            this.club.Click += new System.EventHandler(this.label3_Click);
            // Label numeroclub — étiquette du champ ID
            this.numeroclub.AutoSize = true;
            this.numeroclub.Location = new System.Drawing.Point(12, 75);
            this.numeroclub.Name = "numeroclub";
            this.numeroclub.Size = new System.Drawing.Size(34, 20);
            this.numeroclub.TabIndex = 3;
            this.numeroclub.Text = "ID :";
            this.numeroclub.Click += new System.EventHandler(this.label4_Click);
            // Bouton add — déclenche l'insertion de l'entraîneur en base
            this.add.Location = new System.Drawing.Point(165, 427);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 32);
            this.add.TabIndex = 4;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // Bouton fermer — ferme le formulaire
            this.fermer.Location = new System.Drawing.Point(408, 427);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(125, 32);
            this.fermer.TabIndex = 5;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // TextBox nom — saisie du nom de l'entraîneur
            this.nom.Location = new System.Drawing.Point(123, 130);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(297, 26);
            this.nom.TabIndex = 6;
            this.nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // TextBox prenom — saisie du prénom de l'entraîneur
            this.prenom.Location = new System.Drawing.Point(123, 183);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(297, 26);
            this.prenom.TabIndex = 7;
            this.prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // TextBox numero — saisie du numéro (identifiant) de l'entraîneur
            this.numero.Location = new System.Drawing.Point(123, 69);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(297, 26);
            this.numero.TabIndex = 9;
            this.numero.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // Label label5 — titre du formulaire
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gestion des entraineurs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // DataGridView dataGridView1 — liste des clubs disponibles pour rattachement
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_CLUB, this.NOM_CLUB, this.ADR_RUE_CLUB, this.ADR_VILLE_CLUB});
            this.dataGridView1.Location = new System.Drawing.Point(185, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // Colonne NUM_CLUB — identifiant du club
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // Colonne NOM_CLUB — nom du club
            this.NOM_CLUB.HeaderText = "NOM_CLUB";
            this.NOM_CLUB.MinimumWidth = 8;
            this.NOM_CLUB.Name = "NOM_CLUB";
            this.NOM_CLUB.Width = 150;
            // Colonne ADR_RUE_CLUB — adresse rue du club (affiche la ville via la requête SQL)
            this.ADR_RUE_CLUB.HeaderText = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.MinimumWidth = 8;
            this.ADR_RUE_CLUB.Name = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.Width = 150;
            // Colonne ADR_VILLE_CLUB — ville du club (affiche le code postal via la requête SQL)
            this.ADR_VILLE_CLUB.HeaderText = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.MinimumWidth = 8;
            this.ADR_VILLE_CLUB.Name = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.Width = 150;
            // Formulaire Gestion — fond bleu MenuHighlight, 800x471 px
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.add);
            this.Controls.Add(this.numeroclub);
            this.Controls.Add(this.club);
            this.Controls.Add(this.prenomentraineur);
            this.Controls.Add(this.nomentraineur);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        /// <summary>Label "Nom :" — étiquette du champ nom.</summary>
        private System.Windows.Forms.Label nomentraineur;
        /// <summary>Label "Prenom :" — étiquette du champ prénom.</summary>
        private System.Windows.Forms.Label prenomentraineur;
        /// <summary>Label "Club :" — étiquette de la zone de sélection du club.</summary>
        private System.Windows.Forms.Label club;
        /// <summary>Label "ID :" — étiquette du champ numéro d'entraîneur.</summary>
        private System.Windows.Forms.Label numeroclub;
        /// <summary>Bouton "Ajouter" — déclenche l'insertion en base.</summary>
        private System.Windows.Forms.Button add;
        /// <summary>Bouton "Fermer" — ferme le formulaire.</summary>
        private System.Windows.Forms.Button fermer;
        /// <summary>TextBox de saisie du nom de l'entraîneur.</summary>
        private System.Windows.Forms.TextBox nom;
        /// <summary>TextBox de saisie du prénom de l'entraîneur.</summary>
        private System.Windows.Forms.TextBox prenom;
        /// <summary>TextBox de saisie du numéro (identifiant) de l'entraîneur.</summary>
        private System.Windows.Forms.TextBox numero;
        /// <summary>Label titre "Gestion des entraineurs".</summary>
        private System.Windows.Forms.Label label5;
        /// <summary>Grille affichant la liste des clubs pour sélection du club de rattachement.</summary>
        private System.Windows.Forms.DataGridView dataGridView1;
        /// <summary>Colonne NUM_CLUB de la grille des clubs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        /// <summary>Colonne NOM_CLUB de la grille des clubs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        /// <summary>Colonne ADR_RUE_CLUB (affiche la ville via la requête SQL).</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_CLUB;
        /// <summary>Colonne ADR_VILLE_CLUB (affiche le code postal via la requête SQL).</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_CLUB;
    }
}
