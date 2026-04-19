using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "insert into entraineur (NUM_ENTRAINEUR, NUM_CLUB, NOM_ENTRAINEUR, PRENOM_ENTRAINEUR) values (@num, @club, @nom, @prenom);\r\n ";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            cmd.Parameters.AddWithValue("@num", numero.Text);//insérer des paramètres 
            cmd.Parameters.AddWithValue("@club", dataGridView1.CurrentRow.Cells["NUM_CLUB"].Value);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@prenom", prenom.Text);
            cmd.ExecuteNonQuery();//exécuter la requete
            MessageBox.Show("Informations ajoutées...");
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "select NUM_CLUB, NOM_CLUB, ADR_VILLE_CLUB, CODE_POST_CLUB from club";//écrire la requete
            MySqlCommand cmd = new MySqlCommand(requete, conn);//préparer la requete
            MySqlDataReader reader = cmd.ExecuteReader();//exécuter la requete
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["NUM_CLUB"], reader["NOM_CLUB"], reader["ADR_VILLE_CLUB"], reader["CODE_POST_CLUB"]);
            }

            conn.Close();
        }
    }
}

        

  
