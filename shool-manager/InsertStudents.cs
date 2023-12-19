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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RetrieveStudents retrieveStudents = new RetrieveStudents();
            retrieveStudents.Show();


        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=bd_academie";
            string query = "INSERT INTO etudiant(code_etud,nom_etud, penom_etud, tel_etud, mail_etud, annee_etud) VALUES('" + this.Code.Text + "','" + this.last_name.Text + "','" + this.first_name.Text + "','" + this.telephone.Text + "','" + this.email.Text + "','" + this.year.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            last_name.ResetText();
            first_name.ResetText();
            telephone.ResetText();
            email.ResetText();
            year.ResetText();
            conn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=bd_academie";
            string query = "UPDATE etudiant SET nom_etud='" + this.last_name.Text + "',penom_etud='" + this.first_name.Text + "',tel_etud='" + this.telephone.Text + "',mail_etud='" + this.email.Text + "',annee_etud='" + this.year.Text + "' WHERE code_etud='" + this.Code.Text  +"'";
            /*+this.EMPID.Text + "'"*/
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }
    }
}
