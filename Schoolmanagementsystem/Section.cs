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
    public partial class Section : Form
    {
        string connectionString = "server=localhost;database=schooldb;user=root;password=";
        public Section()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("insert into sectiontab values(@SectionId,@StudentName,@Section)", con);
            cnn.Parameters.AddWithValue("@SectionId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Section", textBox3.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from sectiontab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("update sectiontab set StudentName=@StudentName,Section=@Section where SectionId=@SectionId", con);
            cnn.Parameters.AddWithValue("@SectionId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Section", textBox3.Text);


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
                    string query = "DELETE FROM sectiontab WHERE SectionId = @SectionId";
                    using (MySqlCommand cnn = new MySqlCommand(query, con))
                    {
                        // Add parameter
                        cnn.Parameters.AddWithValue("@SectionId", int.Parse(textBox1.Text));

                        // Execute the query
                        int rowsAffected = cnn.ExecuteNonQuery();
                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified SectionId", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid SectionId. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from sectiontab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Section_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cnn = new MySqlCommand("select * from sectiontab", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
