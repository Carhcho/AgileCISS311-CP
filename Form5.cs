using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseProject
{
    public partial class Form5 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form5()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject." +
                "Properties.Settings.CollegeDBConnectionString"].ConnectionString;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO course (courseTitle, courseId) VALUES (@courseTitle, @courseId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseTitle", courseTitleTextBox.Text);
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Course Added.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
