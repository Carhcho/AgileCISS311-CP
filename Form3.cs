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
    public partial class Form3 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject.Properties.Settings.CollegeDBConnectionString"].ConnectionString;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseComboBox.DisplayMember = "courseTitle";
                courseComboBox.ValueMember = "courseId";
                courseComboBox.DataSource = courseTable;
                courseIdComboBox.DisplayMember = "courseId";
                courseIdComboBox.ValueMember = "courseId";
                courseIdComboBox.DataSource = courseTable;
            }
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT student.studentId, studentName, course.courseTitle" +
                " FROM student JOIN classStudentRelation ON student.studentId = classStudentRelation.studentId" +
                " JOIN course ON classStudentRelation.courseId = course.courseId WHERE course.courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                courseListBox.DisplayMember = "studentName";
                courseListBox.ValueMember = "studentId";
                courseListBox.DataSource = studentTable;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT student.studentId, studentName, course.courseTitle" +
                " FROM student JOIN classStudentRelation ON student.studentId = classStudentRelation.studentId" +
                " JOIN course ON classStudentRelation.courseId = course.courseId WHERE course.courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                courseListBox.DisplayMember = "studentName";
                courseListBox.ValueMember = "studentId";
                courseListBox.DataSource = studentTable;
            }
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
