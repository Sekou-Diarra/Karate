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
    public partial class modif_supp : Form
    {
        public modif_supp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "DELETE FROM entraineur WHERE NUM_ENTRAINEUR = @numEntraineur";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
    
            cmd.Parameters.AddWithValue("@numEntraineur", dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("éléments supprimer");
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            textBox3.Text = row.Cells["NUM_CLUB"].Value.ToString();
        }

        private void modif_supp_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select NUM_ENTRAINEUR from entraineur";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["NUM_ENTRAINEUR"]);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            // Vérifiez si une ligne est sélectionnée dans le DataGridView1
            if (dataGridView1.CurrentRow != null)
            {
                // Récupérez le NUM_ENTRAINEUR sélectionné
                string numEntraineur = dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value.ToString();

                // Requête pour récupérer les informations de l'entraîneur sélectionné (nom et prénom)
                string req = "SELECT NOM_ENTRAINEUR, PRENOM_ENTRAINEUR, NUM_CLUB FROM entraineur WHERE NUM_ENTRAINEUR = @numEntraineur";
                MySqlCommand cm = new MySqlCommand(req, conn);
                cm.Parameters.AddWithValue("@numEntraineur", numEntraineur);

                // Exécuter la requête et récupérer les données
                MySqlDataReader reader1 = cm.ExecuteReader();
                if (reader1.Read())
                {
                    // Remplir les TextBox avec le nom et prénom de l'entraîneur
                    textBox1.Text = reader1["NOM_ENTRAINEUR"].ToString();
                    textBox2.Text = reader1["PRENOM_ENTRAINEUR"].ToString();
                    dataGridView2.Rows.Add(reader1["NUM_CLUB"]);
                }
                
                reader1.Close();
                /*
                string requete = "select NUM_CLUB from club ";//écrire la requete
                MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
                MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader["NUM_CLUB"]);
                }

                conn.Close();
                */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "UPDATE entraineur SET NUM_CLUB=@en, NOM_ENTRAINEUR=@ne, PRENOM_ENTRAINEUR=@pne WHERE NUM_ENTRAINEUR = @nme";
            MySqlCommand cm = new MySqlCommand(requete, conn);
            cm.Parameters.AddWithValue("@en", textBox3.Text);
            cm.Parameters.AddWithValue("@ne", textBox1.Text);
            cm.Parameters.AddWithValue("@pne", textBox2.Text);
            cm.Parameters.AddWithValue("@nme", dataGridView1.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cm.ExecuteNonQuery();
            MessageBox.Show("Infos modifiées");
            conn.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
