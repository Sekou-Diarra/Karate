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
    public partial class Affectation : Form
    {
        public Affectation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select * from competition";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                dataGridView2.Rows.Add(reader["NUM_COMPETITION"], reader["NUM_CLUB"], reader["DATE_COMPETITION"]);
            }

            reader.Close();




            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aj_Click(object sender, EventArgs e)
        {
            int Maximum = 0;
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            String req = "select MAX(NUM_JURY) from juge where num_competition=@numop";
            MySqlCommand cm = new MySqlCommand(req, conn);
            cm.Parameters.AddWithValue("@numop", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);
            //exécuter la requete
            object result = cm.ExecuteScalar();// Utilisation d'ExecuteScalar pour récupérer une seule valeur
            

            if (result != DBNull.Value && result != null)
            {
                Maximum = Convert.ToInt32(result) + 1; // Incrémenter de 1
            }

            string requete = "insert into juge (NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY) values (@numC, @ent, @numJ);\r\n ";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            cmd.Parameters.AddWithValue("@numC", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);//insérer des paramètres 
            cmd.Parameters.AddWithValue("@ent", dataGridView3.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.Parameters.AddWithValue("@numJ", Maximum);
            cmd.ExecuteNonQuery();//exécuter la requete
            MessageBox.Show("Informations ajoutées...");
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modif_Click(object sender, EventArgs e)
        {
            Modification titi = new Modification();
            titi.Show();
        }

        private void supp_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "DELETE FROM juge WHERE NUM_ENTRAINEUR = @ent and NUM_COMPETITION = @numC";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.Parameters.AddWithValue("@numC", dataGridView2.CurrentRow.Cells["NUM_COMPETITION"].Value);
            cmd.Parameters.AddWithValue("@ent", dataGridView3.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("éléments supprimer");
            conn.Close();
        }

        private void choisir_Click(object sender, EventArgs e)
        {
            string numCompetition = dataGridView2.CurrentRow.Cells["NUMERO"].Value.ToString();
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select * from entraineur where NUM_CLUB=@numcomp";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            cmd.Parameters.AddWithValue("@numcomp", numCompetition);
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView3.Rows.Clear();
            while (reader.Read())
            {
                dataGridView3.Rows.Add(reader["NUM_ENTRAINEUR"], reader["NUM_CLUB"], reader["NOM_ENTRAINEUR"], reader["PRENOM_ENTRAINEUR"]);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
