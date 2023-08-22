
namespace CourseProject
{
    partial class Form3
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
            this.closeButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.courseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(480, 379);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 48);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(239, 379);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(101, 48);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Text = "&Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.courseIdComboBox);
            this.courseGroupBox.Controls.Add(this.label3);
            this.courseGroupBox.Controls.Add(this.label2);
            this.courseGroupBox.Controls.Add(this.courseListBox);
            this.courseGroupBox.Controls.Add(this.label1);
            this.courseGroupBox.Controls.Add(this.courseComboBox);
            this.courseGroupBox.Location = new System.Drawing.Point(30, 24);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(741, 337);
            this.courseGroupBox.TabIndex = 3;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Course Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "This course has the following atendees:";
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
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course List:";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(234, 34);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(204, 21);
            this.courseComboBox.TabIndex = 2;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course ID:";
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(550, 34);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseIdComboBox.TabIndex = 6;
            this.courseIdComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.courseGroupBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.courseGroupBox.ResumeLayout(false);
            this.courseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.GroupBox courseGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.Label label3;
    }
}