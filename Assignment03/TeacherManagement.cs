using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Assignment03
{
    public partial class TeacherManagement : Form
    {
        public TeacherManagement()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        private void TeacherManagement_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=CHETHANKACHAM;Initial Catalog=assignment03;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        //Insert the data

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into teacher values('{txtid.Text.ToString()}','{txtname.Text}','{txtaddress.Text}','{txtsalary.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void cleardata()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtsalary.Clear();
        }

        // Update the data

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update teacher set name='" + txtname.Text + "',Address='" + txtaddress.Text + "',salary='" + txtsalary.Text.ToString() + "' where id='" + txtid.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        // Read the data

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        // Delete the data

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = $"delete teacher where id='{txtid.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        // Find the data

        private void btnfind_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher where id='" + txtsearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtname.Text = dt.ToString();
            txtaddress.Text = dt.ToString();
            txtsalary.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        // Exit the application

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Tag = this;
            hm.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentManagement sm = new StudentManagement();
            sm.Tag = this;
            sm.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoursesPage cp = new CoursesPage();
            cp.Tag = this;
            cp.Show(this);
            Hide();
        }
    }
}