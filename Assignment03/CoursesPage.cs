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
using System.Xml.Linq;

namespace Assignment03
{
    public partial class CoursesPage : Form
    {
        public CoursesPage()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;

        private void CoursesPage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=CHETHANKACHAM;Initial Catalog=assignment03;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        //Insert the data

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into course values('{txtid.Text.ToString()}','{txtname.Text}','{txtcredits.Text.ToString()}')";
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
            txtcredits.Clear();
        }

        // Update the data

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update course set name='" + txtname.Text + "',credits='" + txtcredits.Text.ToString() + "' where id='" + txtid.Text.ToString() + "' ";
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
            cmd.CommandText = "select * from Course";
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
            string query = $"delete course where id='{txtid.Text.ToString()}'";
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
            cmd.CommandText = "select * from course where id='" + txtsearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtname.Text = dt.ToString();
            txtcredits.Text = dt.ToString();
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

        private void txtcredits_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Tag = this;
            hm.Show(this);
            Hide();
        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
        {
            TeacherManagement tm = new TeacherManagement();
            tm.Tag = this;
            tm.Show(this);
            Hide();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagement sm = new StudentManagement();
            sm.Tag = this;
            sm.Show(this);
            Hide();
        }
    }
}

