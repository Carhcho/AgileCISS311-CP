
namespace CourseProject
{
    partial class Form2
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
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIdComboBox = new System.Windows.Forms.ComboBox();
            this.studentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.studentIdComboBox);
            this.studentGroupBox.Controls.Add(this.label3);
            this.studentGroupBox.Controls.Add(this.label2);
            this.studentGroupBox.Controls.Add(this.courseListBox);
            this.studentGroupBox.Controls.Add(this.label1);
            this.studentGroupBox.Controls.Add(this.studentComboBox);
            this.studentGroupBox.Location = new System.Drawing.Point(31, 12);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(741, 337);
            this.studentGroupBox.TabIndex = 0;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "This student is registered to the following courses:";
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.Location = new System.Drawing.Point(138, 98);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(533, 225);
            this.courseListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student List:";
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(234, 34);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(149, 21);
            this.studentComboBox.TabIndex = 2;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(253, 367);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(101, 48);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "&Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(481, 367);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 48);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "StudentID List:";
            // 
            // studentIdComboBox
            // 
            this.studentIdComboBox.FormattingEnabled = true;
            this.studentIdComboBox.Location = new System.Drawing.Point(550, 37);
            this.studentIdComboBox.Name = "studentIdComboBox";
            this.studentIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentIdComboBox.TabIndex = 6;
            this.studentIdComboBox.SelectedIndexChanged += new System.EventHandler(this.studentIdComboBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.studentGroupBox);
            this.Name = "Form2";
            this.Text = "ll";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox studentIdComboBox;
        private System.Windows.Forms.Label label3;
    }
}