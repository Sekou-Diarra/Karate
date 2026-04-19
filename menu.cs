using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void ajoutDunEntraineurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion gestion_form = new Gestion();
            gestion_form.Show();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void modifsuppEntraineurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modif_supp modif_form = new modif_supp();
            modif_form.Show();

        }
    }
}
