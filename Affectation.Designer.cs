namespace Karate
{
    partial class Affectation
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
            // 
            // dataGridView3
            // 
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
            // 
            // NUM_ENTRAINEUR
            // 
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINER";
            this.NUM_ENTRAINEUR.MinimumWidth = 8;
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Width = 150;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 8;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 150;
            // 
            // NOM_ENTRAINEUR
            // 
            this.NOM_ENTRAINEUR.HeaderText = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.MinimumWidth = 8;
            this.NOM_ENTRAINEUR.Name = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.Width = 150;
            // 
            // PRENOM_ENTRAINEUR
            // 
            this.PRENOM_ENTRAINEUR.HeaderText = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.MinimumWidth = 8;
            this.PRENOM_ENTRAINEUR.Name = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.Width = 150;
            // 
            // dataGridView2
            // 
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
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 150;
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NUM_CLUB";
            this.NUMERO.MinimumWidth = 8;
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Width = 150;
            // 
            // DATE_COMPETITION
            // 
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.MinimumWidth = 8;
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.Width = 150;
            // 
            // Aj
            // 
            this.Aj.Location = new System.Drawing.Point(12, 425);
            this.Aj.Name = "Aj";
            this.Aj.Size = new System.Drawing.Size(92, 35);
            this.Aj.TabIndex = 2;
            this.Aj.Text = "Ajouter";
            this.Aj.UseVisualStyleBackColor = true;
            this.Aj.Click += new System.EventHandler(this.Aj_Click);
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(186, 425);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(96, 35);
            this.modif.TabIndex = 5;
            this.modif.Text = "modifier";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(324, 425);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(109, 35);
            this.supp.TabIndex = 6;
            this.supp.Text = "supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // choisir
            // 
            this.choisir.Location = new System.Drawing.Point(486, 425);
            this.choisir.Name = "choisir";
            this.choisir.Size = new System.Drawing.Size(97, 35);
            this.choisir.TabIndex = 7;
            this.choisir.Text = "choisir ";
            this.choisir.UseVisualStyleBackColor = true;
            this.choisir.Click += new System.EventHandler(this.choisir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Affectation
            // 
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

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Aj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button choisir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_ENTRAINEUR;
        private System.Windows.Forms.Button button1;
    }
}