namespace College_Students_app.Forms
{
    partial class MainForm
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
            Hello_lable = new Label();
            listView_Courses_list = new ListView();
            SuspendLayout();
            // 
            // Hello_lable
            // 
            Hello_lable.AutoSize = true;
            Hello_lable.Location = new Point(307, 46);
            Hello_lable.Name = "Hello_lable";
            Hello_lable.Size = new Size(173, 25);
            Hello_lable.TabIndex = 0;
            Hello_lable.Text = "רשימת הקורסים שלי";
            // 
            // listView_Courses_list
            // 
            listView_Courses_list.GridLines = true;
            listView_Courses_list.Location = new Point(237, 127);
            listView_Courses_list.Name = "listView_Courses_list";
            listView_Courses_list.Size = new Size(326, 268);
            listView_Courses_list.TabIndex = 1;
            listView_Courses_list.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(listView_Courses_list);
            Controls.Add(Hello_lable);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך ראשי";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Hello_lable;
        private ListView listView_Courses_list;
    }
}