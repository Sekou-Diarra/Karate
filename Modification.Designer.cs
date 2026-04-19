namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="Modification"/>.
    /// <para>Contient la configuration graphique de tous les contrôles du formulaire de modification du numéro de jury.</para>
    /// <remarks>NE PAS MODIFIER MANUELLEMENT. Utiliser le Concepteur de formulaires Visual Studio.</remarks>
    /// </summary>
    partial class Modification
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Initialise et positionne tous les contrôles du formulaire.
        /// <list type="bullet">
        ///   <item><description><b>dataGridView4</b> : grille des jurés (NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY)</description></item>
        ///   <item><description><b>numco</b> : TextBox — affiche le NUM_COMPETITION (lecture seule en pratique)</description></item>
        ///   <item><description><b>nument</b> : TextBox — affiche le NUM_ENTRAINEUR (lecture seule en pratique)</description></item>
        ///   <item><description><b>numju</b> : TextBox — saisie du nouveau NUM_JURY</description></item>
        ///   <item><description><b>numc / nume / numj</b> : labels d'étiquetage des TextBox</description></item>
        ///   <item><description><b>Modif</b> : bouton "Modif" — applique la mise à jour</description></item>
        ///   <item><description><b>button1</b> : bouton "Fermer"</description></item>
        /// </list>
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_JURY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modif = new System.Windows.Forms.Button();
            this.numco = new System.Windows.Forms.TextBox();
            this.nument = new System.Windows.Forms.TextBox();
            this.numju = new System.Windows.Forms.TextBox();
            this.numc = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.numj = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // DataGridView dataGridView4 — liste de tous les jurés existants
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION, this.NUM_ENTRAINEUR, this.NUM_JURY});
            this.dataGridView4.Location = new System.Drawing.Point(362, 28);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(417, 251);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // Colonne NUM_COMPETITION — numéro de la compétition
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 150;
            // Colonne NUM_ENTRAINEUR — numéro de l'entraîneur affecté comme juré
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.MinimumWidth = 8;
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Width = 150;
            // Colonne NUM_JURY — numéro de jury attribué (modifiable)
            this.NUM_JURY.HeaderText = "NUM_JURY";
            this.NUM_JURY.MinimumWidth = 8;
            this.NUM_JURY.Name = "NUM_JURY";
            this.NUM_JURY.Width = 150;
            // Bouton Modif — applique la mise à jour du NUM_JURY en base
            this.Modif.Location = new System.Drawing.Point(290, 363);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(128, 48);
            this.Modif.TabIndex = 1;
            this.Modif.Text = "Modif";
            this.Modif.UseVisualStyleBackColor = true;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // TextBox numco — affichage du NUM_COMPETITION sélectionné (non utilisé en édition)
            this.numco.Location = new System.Drawing.Point(141, 28);
            this.numco.Name = "numco";
            this.numco.Size = new System.Drawing.Size(169, 26);
            this.numco.TabIndex = 2;
            // TextBox nument — affichage du NUM_ENTRAINEUR sélectionné (non utilisé en édition)
            this.nument.Location = new System.Drawing.Point(141, 91);
            this.nument.Name = "nument";
            this.nument.Size = new System.Drawing.Size(169, 26);
            this.nument.TabIndex = 3;
            // TextBox numju — saisie du nouveau numéro de jury à appliquer
            this.numju.Location = new System.Drawing.Point(141, 151);
            this.numju.Name = "numju";
            this.numju.Size = new System.Drawing.Size(169, 26);
            this.numju.TabIndex = 4;
            // Label numc — étiquette "num_c" (numéro de compétition)
            this.numc.AutoSize = true;
            this.numc.Location = new System.Drawing.Point(30, 34);
            this.numc.Name = "numc";
            this.numc.Size = new System.Drawing.Size(57, 20);
            this.numc.TabIndex = 5;
            this.numc.Text = "num_c";
            // Label nume — étiquette "num_e" (numéro d'entraîneur)
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(30, 97);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(58, 20);
            this.nume.TabIndex = 6;
            this.nume.Text = "num_e";
            // Label numj — étiquette "num_j" (numéro de jury)
            this.numj.AutoSize = true;
            this.numj.Location = new System.Drawing.Point(30, 157);
            this.numj.Name = "numj";
            this.numj.Size = new System.Drawing.Size(52, 20);
            this.numj.TabIndex = 7;
            this.numj.Text = "num_j";
            // Bouton button1 — ferme le formulaire
            this.button1.Location = new System.Drawing.Point(452, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // Formulaire Modification — fond bleu Highlight, 800x450 px
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numj);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.numc);
            this.Controls.Add(this.numju);
            this.Controls.Add(this.nument);
            this.Controls.Add(this.numco);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Modification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        /// <summary>Grille listant tous les enregistrements de la table juge.</summary>
        private System.Windows.Forms.DataGridView dataGridView4;
        /// <summary>Colonne NUM_COMPETITION — clé de la compétition.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        /// <summary>Colonne NUM_ENTRAINEUR — clé de l'entraîneur juré.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
        /// <summary>Colonne NUM_JURY — numéro de jury attribué (valeur modifiable).</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_JURY;
        /// <summary>Bouton déclenchant la mise à jour du NUM_JURY en base.</summary>
        private System.Windows.Forms.Button Modif;
        /// <summary>TextBox affichant le numéro de compétition sélectionné.</summary>
        private System.Windows.Forms.TextBox numco;
        /// <summary>TextBox affichant le numéro d'entraîneur sélectionné.</summary>
        private System.Windows.Forms.TextBox nument;
        /// <summary>TextBox de saisie du nouveau numéro de jury.</summary>
        private System.Windows.Forms.TextBox numju;
        /// <summary>Label étiquette "num_c".</summary>
        private System.Windows.Forms.Label numc;
        /// <summary>Label étiquette "num_e".</summary>
        private System.Windows.Forms.Label nume;
        /// <summary>Label étiquette "num_j".</summary>
        private System.Windows.Forms.Label numj;
        /// <summary>Bouton de fermeture du formulaire.</summary>
        private System.Windows.Forms.Button button1;
    }
}
