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
    public partial class Form2 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject." +
                "Properties.Settings.CollegeDBConnectionString"].ConnectionString;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                studentComboBox.DisplayMember = "studentName";
                studentComboBox.ValueMember = "studentId";
                studentComboBox.DataSource = studentTable;
                studentIdComboBox.DisplayMember = "studentId";
                studentIdComboBox.ValueMember = "studentId";
                studentIdComboBox.DataSource = studentTable;
            }
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT course.courseId, courseTitle, student.studentName " +
                "FROM course JOIN classStudentRelation ON course.courseId = classStudentRelation.courseId " +
                "JOIN student on classStudentRelation.studentId = student.studentId " +
                "where student.studentId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue.ToString());
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseListBox.DisplayMember = "courseTitle";
                courseListBox.ValueMember = "courseId";
                courseListBox.DataSource = courseTable;
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

        private void studentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT course.courseId, courseTitle, student.studentName FROM course JOIN classStudentRelation ON course.courseId = classStudentRelation.courseId JOIN student on classStudentRelation.studentId = student.studentId where student.studentId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue.ToString());
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseListBox.DisplayMember = "courseTitle";
                courseListBox.ValueMember = "courseId";
                courseListBox.DataSource = courseTable;
            }
        }
    }
}
