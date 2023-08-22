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
    public partial class Form6 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form6()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject." +
                "Properties.Settings.CollegeDBConnectionString"].ConnectionString;
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE classStudentRelation SET courseId = @courseId " + "WHERE studentId = @studentId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentId", studentIdComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@courseId", courseIdComboBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Record updated.");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                selectCourseComboBox.DisplayMember = "courseTitle";
                selectCourseComboBox.ValueMember = "courseId";
                selectCourseComboBox.DataSource = courseTable;
                courseIdComboBox.DisplayMember = "courseId";
                courseIdComboBox.ValueMember = "courseId";
                courseIdComboBox.DataSource = courseTable;
            }
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                selectStudentComboBox.DisplayMember = "studentName";
                selectStudentComboBox.ValueMember = "studentId";
                selectStudentComboBox.DataSource = studentTable;
                studentIdComboBox.DisplayMember = "studentId";
                studentIdComboBox.ValueMember = "studentId";
                studentIdComboBox.DataSource = studentTable;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
