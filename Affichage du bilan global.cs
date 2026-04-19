using MySql.Data.MySqlClient;
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
    public partial class Affichage_du_bilan_global : Form
    {
        public Affichage_du_bilan_global()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void choix_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select inscription.NUM_COMPETITION, competition.DATE_COMPETITION, inscription.NOTE_GLOBALE from membre inner join inscription on inscription.NUM_LICENCE=membre.NUM_LICENCE inner join competition on inscription.NUM_COMPETITION = competition.NUM_COMPETITION where membre.NUM_LICENCE=@licence";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            cmd.Parameters.AddWithValue("@licence", dataGridView1.CurrentRow.Cells["NUM_LICENCE"].Value);
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                dataGridView2.Rows.Add(reader["NUM_COMPETITION"], reader["DATE_COMPETITION"], reader["NOTE_GLOBALE"]);
            }

            conn.Close();
        }

        private void Affichage_du_bilan_global_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select * from membre";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["NUM_LICENCE"], reader["NUM_CLUB"], reader["NOM_MEMBRE"], reader["PRENOM_MEMBRE"]);
            }



            conn.Close();
        }
    }
}
