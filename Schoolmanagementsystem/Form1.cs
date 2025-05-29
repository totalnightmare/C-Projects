namespace Schoolmanagementsystem
{
    using System.Data;
    using MySql.Data.MySqlClient;
    public partial class Login : Form
    {
        string connectionString = "server=localhost;database=schooldb;user=root;password=";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            MySqlCommand cnn = new MySqlCommand("Select username,password from logintab where username='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main mn = new Main();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
