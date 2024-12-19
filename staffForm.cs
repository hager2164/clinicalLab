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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinicalLab
{
    public partial class staffForm : Form
    {
        private string connection = "Data Source=Hager;Initial Catalog=clinicallab;Integrated Security=True;Encrypt=False";
        public staffForm()//List<string> data)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // List<string> dataToSend = new List<string>();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = @"SELECT *
                                         FROM staff 
                                          DECLARE @id_staff int 
                                          WHERE id_staff = @id_staff ";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // reader.Read();
                    //  textBox1.Text = reader["id_staff"].ToString();
                  textBox2.Text = reader["fname"].ToString();
                  textBox3.Text = reader["lname"].ToString();
                  textBox4.Text = reader["qualifications "].ToString();
                  textBox5.Text = reader["Bdate"].ToString();
                  textBox6.Text = reader["startdate"].ToString();
                  textBox7.Text = reader["phone"].ToString();
                //    textBox8.Text = reader["salary"].ToString();

                 }
            }
            else MessageBox.Show("not found ");
                
            conn.Close();
        }
    }
}
