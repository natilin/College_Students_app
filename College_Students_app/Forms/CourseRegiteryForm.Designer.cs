namespace College_Students_app
{
    partial class CourseRegiteryForm
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
            lable_1 = new Label();
            label1 = new Label();
            listBox_courses = new ListBox();
            SuspendLayout();
            // 
            // lable_1
            // 
            lable_1.AutoSize = true;
            lable_1.Location = new Point(338, 36);
            lable_1.Name = "lable_1";
            lable_1.Size = new Size(129, 25);
            lable_1.TabIndex = 0;
            lable_1.Text = "רישום לקורסים";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 158);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 2;
            label1.Text = "קורסים זמינים";
            // 
            // listBox_courses
            // 
            listBox_courses.FormattingEnabled = true;
            listBox_courses.ItemHeight = 25;
            listBox_courses.Location = new Point(306, 214);
            listBox_courses.Name = "listBox_courses";
            listBox_courses.Size = new Size(180, 129);
            listBox_courses.TabIndex = 1;
            // 
            // CourseRegiteryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(label1);
            Controls.Add(listBox_courses);
            Controls.Add(lable_1);
            Name = "CourseRegiteryForm";
            Text = "CourseRegiteryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable_1;
        private Label label1;
        private ListBox listBox_courses;
    }
}