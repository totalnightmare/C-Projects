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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Schoolmanagementsystem
{

    public partial class Student : Form
    {
        string connectionString = "server=localhost;database=schooldb;user=root;password=";
        public Student()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /* private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
         {
             dateTimePicker1.CustomFormat = "dd/MM/yyyy";
         }
         private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Back)
             {
                 dateTimePicker1.CustomFormat = "";
             }
         }*/

        private void button1_Click(object sender, EventArgs e)//btnSaveclick
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("insert into studentab values(@StudentId,@StudentName,@Dob,@Gender,@Phone,@Email)", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Gender", textBox3.Text);
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Email", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button3_Click(object sender, EventArgs e)//btnAddClick
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from studentab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void button2_Click(object sender, EventArgs e)//btnUpdateclick
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("update studentab set StudentName = @StudentName,Dob = @Dob,Gender = @Gender,Phone = @Phone,Email = @Email where StudentId = @StudentId", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Gender", textBox3.Text);
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Email", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM studentab WHERE StudentId = @StudentId";
                    using (MySqlCommand cnn = new MySqlCommand(query, con))
                    {
                        // Add parameter
                        cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));

                        // Execute the query
                        int rowsAffected = cnn.ExecuteNonQuery();
                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified StudentId", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid StudentId. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from studentab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Student_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from studentab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }
    }
}
