namespace Assignment03
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCourses = new Button();
            btnTeacherManagement = new Button();
            btnStudentManagement = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(632, 225);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(94, 29);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnTeacherManagement
            // 
            btnTeacherManagement.Location = new Point(315, 225);
            btnTeacherManagement.Name = "btnTeacherManagement";
            btnTeacherManagement.Size = new Size(195, 29);
            btnTeacherManagement.TabIndex = 1;
            btnTeacherManagement.Text = "Teacher Management";
            btnTeacherManagement.UseVisualStyleBackColor = true;
            btnTeacherManagement.Click += btnTeacherManagement_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.Location = new Point(23, 225);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(184, 29);
            btnStudentManagement.TabIndex = 2;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = true;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(743, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Home Page";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(766, 81);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "                                        \n                                                                          Management Information System";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(btnStudentManagement);
            Controls.Add(btnTeacherManagement);
            Controls.Add(btnCourses);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCourses;
        private Button btnTeacherManagement;
        private Button btnStudentManagement;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}