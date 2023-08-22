
namespace CourseProject
{
    partial class Form1
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
            this.studentTracker = new System.Windows.Forms.Button();
            this.courseTracker = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.collegeTracker = new System.Windows.Forms.PictureBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.addCourse = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.collegeTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // studentTracker
            // 
            this.studentTracker.Location = new System.Drawing.Point(126, 205);
            this.studentTracker.Name = "studentTracker";
            this.studentTracker.Size = new System.Drawing.Size(191, 72);
            this.studentTracker.TabIndex = 0;
            this.studentTracker.Text = "Student Tracker";
            this.studentTracker.UseVisualStyleBackColor = true;
            this.studentTracker.Click += new System.EventHandler(this.studentTracker_Click);
            // 
            // courseTracker
            // 
            this.courseTracker.Location = new System.Drawing.Point(435, 205);
            this.courseTracker.Name = "courseTracker";
            this.courseTracker.Size = new System.Drawing.Size(191, 72);
            this.courseTracker.TabIndex = 1;
            this.courseTracker.Text = "Course Tracker";
            this.courseTracker.UseVisualStyleBackColor = true;
            this.courseTracker.Click += new System.EventHandler(this.courseTracker_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(435, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 72);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Track student courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Track course atendees";
            // 
            // collegeTracker
            // 
            this.collegeTracker.Image = global::CourseProject.Properties.Resources.college_tracker;
            this.collegeTracker.InitialImage = global::CourseProject.Properties.Resources.college_tracker;
            this.collegeTracker.Location = new System.Drawing.Point(126, -6);
            this.collegeTracker.Name = "collegeTracker";
            this.collegeTracker.Size = new System.Drawing.Size(500, 188);
            this.collegeTracker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.collegeTracker.TabIndex = 2;
            this.collegeTracker.TabStop = false;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(126, 296);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(191, 72);
            this.addStudent.TabIndex = 6;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // addCourse
            // 
            this.addCourse.Location = new System.Drawing.Point(435, 296);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(191, 72);
            this.addCourse.TabIndex = 7;
            this.addCourse.Text = "Add a course";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(126, 386);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(191, 72);
            this.enrollButton.TabIndex = 8;
            this.enrollButton.Text = "Enroll in a Course";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.addCourse);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.collegeTracker);
            this.Controls.Add(this.courseTracker);
            this.Controls.Add(this.studentTracker);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.collegeTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentTracker;
        private System.Windows.Forms.Button courseTracker;
        private System.Windows.Forms.PictureBox collegeTracker;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button enrollButton;
    }
}

