namespace Karate
{
    partial class Affichage_du_bilan_global
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LICENCE,
            this.NUM_CLUB,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(469, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 8;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 150;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // 
            // NOM_MEMBRE
            // 
            this.NOM_MEMBRE.HeaderText = "NOM_MEMBRE";
            this.NOM_MEMBRE.MinimumWidth = 8;
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.Width = 150;
            // 
            // PRENOM_MEMBRE
            // 
            this.PRENOM_MEMBRE.HeaderText = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.MinimumWidth = 8;
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.DATE_COMPETITION,
            this.NOTE_GLOBALE});
            this.dataGridView2.Location = new System.Drawing.Point(12, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(469, 210);
            this.dataGridView2.TabIndex = 1;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 150;
            // 
            // DATE_COMPETITION
            // 
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.MinimumWidth = 8;
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.Width = 150;
            // 
            // NOTE_GLOBALE
            // 
            this.NOTE_GLOBALE.HeaderText = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.MinimumWidth = 8;
            this.NOTE_GLOBALE.Name = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.Width = 150;
            // 
            // choix
            // 
            this.choix.Location = new System.Drawing.Point(648, 141);
            this.choix.Name = "choix";
            this.choix.Size = new System.Drawing.Size(92, 37);
            this.choix.TabIndex = 2;
            this.choix.Text = "choisir";
            this.choix.UseVisualStyleBackColor = true;
            this.choix.Click += new System.EventHandler(this.choix_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Affichage_du_bilan_global
            // 
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        private System.Windows.Forms.Button choix;
        private System.Windows.Forms.Button button2;
    }
}