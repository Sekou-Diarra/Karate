namespace Karate
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesEntraineursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunEntraineurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifsuppEntraineurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEntraineursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesEntraineursToolStripMenuItem
            // 
            this.gestionDesEntraineursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunEntraineurToolStripMenuItem,
            this.modifsuppEntraineurToolStripMenuItem});
            this.gestionDesEntraineursToolStripMenuItem.Name = "gestionDesEntraineursToolStripMenuItem";
            this.gestionDesEntraineursToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.gestionDesEntraineursToolStripMenuItem.Text = "Gestion des entraineurs";
            // 
            // ajoutDunEntraineurToolStripMenuItem
            // 
            this.ajoutDunEntraineurToolStripMenuItem.Name = "ajoutDunEntraineurToolStripMenuItem";
            this.ajoutDunEntraineurToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.ajoutDunEntraineurToolStripMenuItem.Text = "Ajout d\'un entraineur";
            this.ajoutDunEntraineurToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunEntraineurToolStripMenuItem_Click);
            // 
            // modifsuppEntraineurToolStripMenuItem
            // 
            this.modifsuppEntraineurToolStripMenuItem.Name = "modifsuppEntraineurToolStripMenuItem";
            this.modifsuppEntraineurToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.modifsuppEntraineurToolStripMenuItem.Text = "modif/supp entraineur";
            this.modifsuppEntraineurToolStripMenuItem.Click += new System.EventHandler(this.modifsuppEntraineurToolStripMenuItem_Click);
            // 
            // menu
            // 
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEntraineursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunEntraineurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifsuppEntraineurToolStripMenuItem;
    }
}