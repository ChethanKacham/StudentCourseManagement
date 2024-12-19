namespace Assignment03
{
    partial class TeacherManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            txtaddress = new TextBox();
            txtsalary = new TextBox();
            txtsearch = new TextBox();
            btninsert = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btnshow = new Button();
            btnfind = new Button();
            btnexit = new Button();
            dataGridView1 = new DataGridView();
            btnHomePage = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 141);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Salary";
            // 
            // txtid
            // 
            txtid.Location = new Point(112, 31);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.Location = new Point(112, 68);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(112, 100);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(125, 27);
            txtaddress.TabIndex = 6;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(112, 134);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(125, 27);
            txtsalary.TabIndex = 7;
            txtsalary.TextChanged += txtsalary_TextChanged;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(344, 31);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(445, 27);
            txtsearch.TabIndex = 8;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(23, 192);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(94, 29);
            btninsert.TabIndex = 9;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(123, 192);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 10;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(227, 192);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 11;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(23, 238);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(94, 29);
            btnshow.TabIndex = 12;
            btnshow.Text = "Show All";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnfind
            // 
            btnfind.Location = new Point(795, 28);
            btnfind.Name = "btnfind";
            btnfind.Size = new Size(94, 29);
            btnfind.TabIndex = 13;
            btnfind.Text = "Find";
            btnfind.UseVisualStyleBackColor = true;
            btnfind.Click += btnfind_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(227, 238);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 14;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 323);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(27, 273);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(271, 29);
            btnHomePage.TabIndex = 16;
            btnHomePage.Text = "Home Page";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 310);
            button1.Name = "button1";
            button1.Size = new Size(271, 29);
            button1.TabIndex = 17;
            button1.Text = "Student Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 345);
            button2.Name = "button2";
            button2.Size = new Size(271, 29);
            button2.TabIndex = 18;
            button2.Text = "Courses Page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TeacherManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 451);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnHomePage);
            Controls.Add(btnexit);
            Controls.Add(btnfind);
            Controls.Add(btnshow);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(txtsearch);
            Controls.Add(txtsalary);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "TeacherManagement";
            Text = "TeacherManagement";
            Load += TeacherManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtaddress;
        private TextBox txtsalary;
        private TextBox txtsearch;
        private Button btninsert;
        private Button btnupdate;
        private Button btndelete;
        private Button btnshow;
        private Button btnfind;
        private Button btnexit;
        private DataGridView dataGridView1;
        private Button btnHomePage;
        private Button button1;
        private Button button2;
    }
}