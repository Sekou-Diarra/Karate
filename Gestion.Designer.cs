namespace Karate
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
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
            // 
            // nomentraineur
            // 
            this.nomentraineur.AutoSize = true;
            this.nomentraineur.Location = new System.Drawing.Point(12, 134);
            this.nomentraineur.Name = "nomentraineur";
            this.nomentraineur.Size = new System.Drawing.Size(50, 20);
            this.nomentraineur.TabIndex = 0;
            this.nomentraineur.Text = "Nom :";
            this.nomentraineur.Click += new System.EventHandler(this.label1_Click);
            // 
            // prenomentraineur
            // 
            this.prenomentraineur.AutoSize = true;
            this.prenomentraineur.Location = new System.Drawing.Point(12, 189);
            this.prenomentraineur.Name = "prenomentraineur";
            this.prenomentraineur.Size = new System.Drawing.Size(72, 20);
            this.prenomentraineur.TabIndex = 1;
            this.prenomentraineur.Text = "Prenom :";
            this.prenomentraineur.Click += new System.EventHandler(this.label2_Click);
            // 
            // club
            // 
            this.club.AutoSize = true;
            this.club.Location = new System.Drawing.Point(12, 304);
            this.club.Name = "club";
            this.club.Size = new System.Drawing.Size(49, 20);
            this.club.TabIndex = 2;
            this.club.Text = "Club :";
            this.club.Click += new System.EventHandler(this.label3_Click);
            // 
            // numeroclub
            // 
            this.numeroclub.AutoSize = true;
            this.numeroclub.Location = new System.Drawing.Point(12, 75);
            this.numeroclub.Name = "numeroclub";
            this.numeroclub.Size = new System.Drawing.Size(34, 20);
            this.numeroclub.TabIndex = 3;
            this.numeroclub.Text = "ID :";
            this.numeroclub.Click += new System.EventHandler(this.label4_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(165, 427);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 32);
            this.add.TabIndex = 4;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(408, 427);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(125, 32);
            this.fermer.TabIndex = 5;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(123, 130);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(297, 26);
            this.nom.TabIndex = 6;
            this.nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(123, 183);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(297, 26);
            this.prenom.TabIndex = 7;
            this.prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(123, 69);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(297, 26);
            this.numero.TabIndex = 9;
            this.numero.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gestion des entraineurs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_CLUB,
            this.NOM_CLUB,
            this.ADR_RUE_CLUB,
            this.ADR_VILLE_CLUB});
            this.dataGridView1.Location = new System.Drawing.Point(185, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // 
            // NOM_CLUB
            // 
            this.NOM_CLUB.HeaderText = "NOM_CLUB";
            this.NOM_CLUB.MinimumWidth = 8;
            this.NOM_CLUB.Name = "NOM_CLUB";
            this.NOM_CLUB.Width = 150;
            // 
            // ADR_RUE_CLUB
            // 
            this.ADR_RUE_CLUB.HeaderText = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.MinimumWidth = 8;
            this.ADR_RUE_CLUB.Name = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.Width = 150;
            // 
            // ADR_VILLE_CLUB
            // 
            this.ADR_VILLE_CLUB.HeaderText = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.MinimumWidth = 8;
            this.ADR_VILLE_CLUB.Name = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.Width = 150;
            // 
            // Gestion
            // 
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

        private System.Windows.Forms.Label nomentraineur;
        private System.Windows.Forms.Label prenomentraineur;
        private System.Windows.Forms.Label club;
        private System.Windows.Forms.Label numeroclub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_CLUB;
    }
}

