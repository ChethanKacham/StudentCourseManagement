using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesPage cp = new CoursesPage();
            cp.Tag = this;
            cp.Show(this);
            Hide();
        }
    }
}
