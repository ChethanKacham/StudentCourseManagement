﻿using System;
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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=CHETHANKACHAM;Initial Catalog=assignment03;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        //Insert the data

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into student values('{txtid.Text.ToString()}','{txtname.Text}','{txtaddress.Text}','{txtcredits.Text.ToString()}')";
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
            txtcredits.Clear();
        }

        // Update the data

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student set name='" + txtname.Text + "',Address='" + txtaddress.Text + "',credits='" + txtcredits.Text.ToString() + "' where id='" + txtid.Text.ToString() + "' ";
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
            cmd.CommandText = "select * from student";
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
            string query = $"delete student where id='{txtid.Text.ToString()}'";
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
            cmd.CommandText = "select * from student where id='" + txtsearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtname.Text = dt.ToString();
            txtaddress.Text = dt.ToString();
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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesPage cp = new CoursesPage();
            cp.Tag = this;
            cp.Show(this);
            Hide();
        }
    }
}