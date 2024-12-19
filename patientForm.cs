using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinicalLab
{
    public partial class patientForm : Form
    {
        private string connection = "Data Source=Hager;Initial Catalog=clinicallab;Integrated Security=True;Encrypt=False";
        public void LoadPatientData(List<string> patientDetails)
        {
          //  listBox1.Items.Clear(); // Clear existing items
            //foreach (var detail in patientDetails)
            //{
            //    listBox1.Items.Add(detail); // Add each detail to the ListBox
            //}
        }
        public patientForm()//List<string> data)
        {
            InitializeComponent();
         //   SqlConnection conn = new SqlConnection(connection);
         // conn.Open();
         // LoadPatientData(data);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = @"SELECT *
                                         FROM patient 
                                            ";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();
                textBox5.Text = reader[4].ToString();
                textBox6.Text = reader[5].ToString();


            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = @"SELECT *
                                         FROM patient 


                                            ";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@age", textBox7.Text);
            command.Parameters.AddWithValue("@phone", textBox8.Text);
            command.Parameters.AddWithValue("@Test_Type", textBox9.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Data has been added ");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = @"SELECT fname
                                         FROM patient 
                                            ";
            label1.Text= query;

        }
    }
}
