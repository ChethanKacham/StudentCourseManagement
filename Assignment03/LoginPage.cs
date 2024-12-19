using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection String
            SqlConnection con = new SqlConnection(@"Data Source=CHETHANKACHAM;Initial Catalog=assignment03;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Userlogins where UserName=@UserName and Password =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // Connection open here
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully logged in");
                // After successful login, it will redirect to the next page.
                //HomePage settingsForm = new HomePage();
                //settingsForm.Show();
                HomePage hp = new HomePage();
                hp.Tag = this;
                hp.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter the correct Username and Password");
            }
        }
    }
}
