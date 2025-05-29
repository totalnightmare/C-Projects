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

namespace Schoolmanagementsystem
{
    public partial class Dashboard : Form
    {
        string connectionString = "server=localhost;database=schooldb;user=root;password=";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display();
            Display1();
            Display2();
            Display3();
            Display4();
            Display5();
        }
        private void Display()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from studentab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count > 0)
            {
                lblcount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount.Text = "0";
            }
            con.Close();
        }
        private void Display1()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from subjectab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcount1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount1.Text = "0";
            }
            con.Close();
        }
        private void Display2()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from teachertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcount2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount2.Text = "0";
            }
            con.Close();
        }
        private void Display3()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from entab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcount3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount3.Text = "0";
            }
            con.Close();
        }
        private void Display4()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from attentab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcount4.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount4.Text = "0";
            }
            con.Close();
        }
        private void Display5()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from sectiontab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblcount5.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcount5.Text = "0";
            }
            con.Close();
        }
    }
}
