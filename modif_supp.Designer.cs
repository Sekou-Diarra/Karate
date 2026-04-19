namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="modif_supp"/>.
    /// <para>Contient la configuration graphique de tous les contrôles du formulaire de modification/suppression d'entraîneur.</para>
    /// <remarks>NE PAS MODIFIER MANUELLEMENT. Utiliser le Concepteur de formulaires Visual Studio.</remarks>
    /// </summary>
    partial class modif_supp
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
        ///   <item><description><b>dataGridView1</b> : liste des numéros d'entraîneurs (211×150 px)</description></item>
        ///   <item><description><b>dataGridView2</b> : affiche le club de l'entraîneur sélectionné (240×150 px)</description></item>
        ///   <item><description><b>textBox1</b> : saisie/affichage du nom</description></item>
        ///   <item><description><b>textBox2</b> : saisie/affichage du prénom</description></item>
        ///   <item><description><b>textBox3</b> : saisie/affichage du nouveau numéro de club</description></item>
        ///   <item><description><b>label1</b> : titre "liste des entraineurs"</description></item>
        ///   <item><description><b>label2</b> : étiquette "Nom"</description></item>
        ///   <item><description><b>label3</b> : étiquette "Prenom"</description></item>
        ///   <item><description><b>label4</b> : étiquette "Num"</description></item>
        ///   <item><description><b>button1</b> : bouton "Choisir"</description></item>
        ///   <item><description><b>button2</b> : bouton "Modif"</description></item>
        ///   <item><description><b>supp</b> : bouton "Supp"</description></item>
        ///   <item><description><b>button3</b> : bouton "Fermer"</description></item>
        /// </list>
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.supp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // dataGridView1 — liste des identifiants d'entraîneurs
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.NUM_ENTRAINEUR });
            this.dataGridView1.Location = new System.Drawing.Point(164, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(211, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // Colonne NUM_ENTRAINEUR — identifiant de l'entraîneur
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.MinimumWidth = 8;
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Width = 150;
            // Label label1 — titre de la liste des entraîneurs
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "liste des entraineurs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // TextBox textBox1 — affichage/modification du nom de l'entraîneur
            this.textBox1.Location = new System.Drawing.Point(164, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // TextBox textBox2 — affichage/modification du prénom de l'entraîneur
            this.textBox2.Location = new System.Drawing.Point(164, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            // Bouton button1 — "Choisir" : charge les infos de l'entraîneur sélectionné
            this.button1.Location = new System.Drawing.Point(466, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "choisir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // dataGridView2 — affiche le club actuel de l'entraîneur sélectionné
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.NUM_CLUB });
            this.dataGridView2.Location = new System.Drawing.Point(164, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // Colonne NUM_CLUB — numéro du club de l'entraîneur
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // Bouton button2 — "Modif" : applique la mise à jour de l'entraîneur
            this.button2.Location = new System.Drawing.Point(466, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "modif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // Bouton supp — "Supp" : supprime l'entraîneur sélectionné
            this.supp.Location = new System.Drawing.Point(466, 421);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(89, 32);
            this.supp.TabIndex = 7;
            this.supp.Text = "supp";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.button3_Click);
            // Label label2 — étiquette "Nom"
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // Label label3 — étiquette "Prenom"
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenom";
            // Bouton button3 — "Fermer" : ferme le formulaire
            this.button3.Location = new System.Drawing.Point(466, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "fermer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // TextBox textBox3 — saisie/affichage du nouveau numéro de club
            this.textBox3.Location = new System.Drawing.Point(164, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 11;
            // Label label4 — étiquette "Num" (numéro de club)
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num";
            // Formulaire modif_supp — fond bleu MenuHighlight, 800x523 px
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "modif_supp";
            this.Text = "modif_supp";
            this.Load += new System.EventHandler(this.modif_supp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        /// <summary>Grille listant les numéros d'entraîneurs pour sélection.</summary>
        private System.Windows.Forms.DataGridView dataGridView1;
        /// <summary>Colonne NUM_ENTRAINEUR — identifiant de l'entraîneur.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
        /// <summary>Label titre "liste des entraineurs".</summary>
        private System.Windows.Forms.Label label1;
        /// <summary>TextBox affichage/modification du nom de l'entraîneur.</summary>
        private System.Windows.Forms.TextBox textBox1;
        /// <summary>TextBox affichage/modification du prénom de l'entraîneur.</summary>
        private System.Windows.Forms.TextBox textBox2;
        /// <summary>Bouton "Choisir" — charge les informations de l'entraîneur sélectionné.</summary>
        private System.Windows.Forms.Button button1;
        /// <summary>Grille affichant le club actuel de l'entraîneur sélectionné.</summary>
        private System.Windows.Forms.DataGridView dataGridView2;
        /// <summary>Bouton "Modif" — valide la mise à jour de l'entraîneur.</summary>
        private System.Windows.Forms.Button button2;
        /// <summary>Bouton "Supp" — supprime l'entraîneur sélectionné.</summary>
        private System.Windows.Forms.Button supp;
        /// <summary>Colonne NUM_CLUB de la grille des clubs.</summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        /// <summary>Label étiquette "Nom".</summary>
        private System.Windows.Forms.Label label2;
        /// <summary>Label étiquette "Prenom".</summary>
        private System.Windows.Forms.Label label3;
        /// <summary>Bouton "Fermer" — ferme le formulaire.</summary>
        private System.Windows.Forms.Button button3;
        /// <summary>TextBox saisie/affichage du nouveau numéro de club.</summary>
        private System.Windows.Forms.TextBox textBox3;
        /// <summary>Label étiquette "Num" (numéro de club).</summary>
        private System.Windows.Forms.Label label4;
    }
}
