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
    public partial class Modification : Form
    {
        public Modification()
        {
            InitializeComponent();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
            
            numju.Text = row.Cells["NUM_JURY"].Value.ToString();
        }

        private void Modification_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "SELECT NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY FROM juge ";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader3 = cmd.ExecuteReader();
            dataGridView4.Rows.Clear();
            while (reader3.Read())
            {
                dataGridView4.Rows.Add(reader3["NUM_COMPETITION"], reader3["NUM_ENTRAINEUR"], reader3["NUM_JURY"]);
            }
            conn.Close();
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = BDD.ConnectBD();
            conn.Open();
            string requete = "UPDATE juge SET NUM_JURY = @numj WHERE NUM_COMPETITION=@id and NUM_ENTRAINEUR=@ide";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.Parameters.AddWithValue("@numj", numju.Text);
            cmd.Parameters.AddWithValue("@id", dataGridView4.CurrentRow.Cells["NUM_COMPETITION"].Value);
            cmd.Parameters.AddWithValue("@ide", dataGridView4.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Modif éffectuée!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
