using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace shool_manager
{
    public partial class RetrieveStudents : Form
    {
        public RetrieveStudents()
        {
            InitializeComponent();
        }

        private void RetrieveStudents_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void List_button_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=bd_academie";
            string query = "SELECT * FROM etudiant";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
