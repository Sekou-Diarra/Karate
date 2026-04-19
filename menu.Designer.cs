namespace Karate
{
    /// <summary>
    /// Partie Designer (générée par Visual Studio) du formulaire <see cref="menu"/>.
    /// <para>Contient la configuration graphique de la barre de menus principale de l'application.</para>
    /// <remarks>NE PAS MODIFIER MANUELLEMENT. Utiliser le Concepteur de formulaires Visual Studio.</remarks>
    /// </summary>
    partial class menu
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
        ///   <item><description><b>menuStrip1</b> : barre de menus principale (800×33 px)</description></item>
        ///   <item><description><b>gestionDesEntraineursToolStripMenuItem</b> : menu principal "Gestion des entraineurs"</description></item>
        ///   <item><description><b>ajoutDunEntraineurToolStripMenuItem</b> : sous-menu → ouvre <see cref="Gestion"/></description></item>
        ///   <item><description><b>modifsuppEntraineurToolStripMenuItem</b> : sous-menu → ouvre <see cref="modif_supp"/></description></item>
        /// </list>
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesEntraineursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunEntraineurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifsuppEntraineurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // MenuStrip menuStrip1 — barre de menus principale du formulaire
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEntraineursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // MenuItem gestionDesEntraineursToolStripMenuItem — menu parent "Gestion des entraineurs"
            this.gestionDesEntraineursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunEntraineurToolStripMenuItem,
            this.modifsuppEntraineurToolStripMenuItem});
            this.gestionDesEntraineursToolStripMenuItem.Name = "gestionDesEntraineursToolStripMenuItem";
            this.gestionDesEntraineursToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.gestionDesEntraineursToolStripMenuItem.Text = "Gestion des entraineurs";
            // Sous-menu ajoutDunEntraineurToolStripMenuItem — ouvre le formulaire Gestion
            this.ajoutDunEntraineurToolStripMenuItem.Name = "ajoutDunEntraineurToolStripMenuItem";
            this.ajoutDunEntraineurToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.ajoutDunEntraineurToolStripMenuItem.Text = "Ajout d'un entraineur";
            this.ajoutDunEntraineurToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunEntraineurToolStripMenuItem_Click);
            // Sous-menu modifsuppEntraineurToolStripMenuItem — ouvre le formulaire modif_supp
            this.modifsuppEntraineurToolStripMenuItem.Name = "modifsuppEntraineurToolStripMenuItem";
            this.modifsuppEntraineurToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.modifsuppEntraineurToolStripMenuItem.Text = "modif/supp entraineur";
            this.modifsuppEntraineurToolStripMenuItem.Click += new System.EventHandler(this.modifsuppEntraineurToolStripMenuItem_Click);
            // Formulaire menu — fond bleu MenuHighlight, 800x450 px
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        /// <summary>Barre de menus principale du formulaire.</summary>
        private System.Windows.Forms.MenuStrip menuStrip1;
        /// <summary>Entrée de menu principale "Gestion des entraineurs".</summary>
        private System.Windows.Forms.ToolStripMenuItem gestionDesEntraineursToolStripMenuItem;
        /// <summary>Sous-menu "Ajout d'un entraineur" — ouvre le formulaire Gestion.</summary>
        private System.Windows.Forms.ToolStripMenuItem ajoutDunEntraineurToolStripMenuItem;
        /// <summary>Sous-menu "modif/supp entraineur" — ouvre le formulaire modif_supp.</summary>
        private System.Windows.Forms.ToolStripMenuItem modifsuppEntraineurToolStripMenuItem;
    }
}
