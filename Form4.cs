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
    public partial class Form4 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form4()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject." +
                "Properties.Settings.CollegeDBConnectionString"].ConnectionString;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO student (studentName, studentId) VALUES (@studentName, @studentId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentName", studentNameTextBox.Text);
                comd.Parameters.AddWithValue("@studentId", studentIdTextBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Student Added.");
            }
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO classStudentRelation (studentId) VALUES (@studentId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentId", studentIdTextBox.Text);
                comd.ExecuteScalar();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
