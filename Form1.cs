using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace clinicalLab
{
    public partial class Form1 : Form
    {
        private string connection = "Data Source=Hager;Initial Catalog=clinicallab;Integrated Security=True;Encrypt=False";
        public Form1()
        {  
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //List<string> dataToSend = new List<string>();

           
            //try
          // {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();    
                string query;
                query = @"SELECT *
                                         FROM patient
                                            where id_paient = @id_paient  ";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@fname", textBox1 .Text);
                command.Parameters.AddWithValue("@lname", textBox2.Text);
                command.Parameters.AddWithValue("@id_paient", textBox3.Text);
                command .ExecuteNonQuery();
               SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show(" data sent successfully");
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        dataToSend.Add(reader.GetString(0));
            //        dataToSend.Add(reader.GetString(3));
            //        dataToSend.Add(reader.GetString(4));
            //        dataToSend.Add(reader.GetString(3));
            //        dataToSend.Add(reader.GetString(4));
            //        dataToSend.Add(reader.GetString(5));



            //    }
            //}
           // MessageBox.Show("successful login");
                patientForm p = new patientForm();
                p.Show();
               // conn.Close();
            //}
           //catch (Exception ex) { MessageBox.Show(ex.Message); }
           // finally { if (conn != null) { conn.Close(); } } 





            
          }

        private void button2_Click(object sender, EventArgs e)
        {
            staffForm s = new staffForm();
            s.Show();
            //try
            //{
            //    SqlConnection conn = new SqlConnection(connection);
            //    conn.Open();
            //    string query;
            //    query = @"SELECT *
            //                             FROM staff
            //                                where id_staff = @id_staff ";
            //    SqlCommand command = new SqlCommand(query, conn);
               

            //    command.ExecuteNonQuery();
            //    SqlDataReader reader = command.ExecuteReader();

            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            //for (int i = 0; i < reader.FieldCount; i++)

            //            //{
            //            //    List<string> dataToSend = new List<string>();
            //            //    dataToSend.Add(reader.GetString(i));

            //            //}
            //            //staffForm s = new staffForm(dataToSend);
            //            //s.Show();
                        
            //        }
            //    }
            //    MessageBox.Show(" data sent successfully");
            //    //MessageBox.Show("successful login");
            //    //staffForm s = new staffForm(dataToSend);
            //    //s.Show();
            //    // conn.Close();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
