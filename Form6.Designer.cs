
namespace CourseProject
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCourseComboBox = new System.Windows.Forms.ComboBox();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentIdComboBox = new System.Windows.Forms.ComboBox();
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseIdComboBox);
            this.groupBox1.Controls.Add(this.studentIdComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectStudentComboBox);
            this.groupBox1.Controls.Add(this.selectCourseComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enroll Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a Course:";
            // 
            // selectCourseComboBox
            // 
            this.selectCourseComboBox.FormattingEnabled = true;
            this.selectCourseComboBox.Location = new System.Drawing.Point(317, 170);
            this.selectCourseComboBox.Name = "selectCourseComboBox";
            this.selectCourseComboBox.Size = new System.Drawing.Size(236, 21);
            this.selectCourseComboBox.TabIndex = 2;
            // 
            // selectStudentComboBox
            // 
            this.selectStudentComboBox.FormattingEnabled = true;
            this.selectStudentComboBox.Location = new System.Drawing.Point(317, 68);
            this.selectStudentComboBox.Name = "selectStudentComboBox";
            this.selectStudentComboBox.Size = new System.Drawing.Size(236, 21);
            this.selectStudentComboBox.TabIndex = 3;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(141, 316);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(168, 65);
            this.enrollButton.TabIndex = 4;
            this.enrollButton.Text = "&Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(469, 316);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(168, 65);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Cl&ose";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Course ID:";
            // 
            // studentIdComboBox
            // 
            this.studentIdComboBox.FormattingEnabled = true;
            this.studentIdComboBox.Location = new System.Drawing.Point(635, 68);
            this.studentIdComboBox.Name = "studentIdComboBox";
            this.studentIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.studentIdComboBox.TabIndex = 6;
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(635, 170);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.courseIdComboBox.TabIndex = 7;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectStudentComboBox;
        private System.Windows.Forms.ComboBox selectCourseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.ComboBox studentIdComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}