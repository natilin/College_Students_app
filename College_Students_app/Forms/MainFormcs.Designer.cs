namespace College_Students_app.Forms
{
    partial class MainFormcs
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
            SuspendLayout();
            // 
            // Hello_lable
            // 
            Hello_lable.AutoSize = true;
            Hello_lable.Location = new Point(394, 50);
            Hello_lable.Name = "Hello_lable";
            Hello_lable.Size = new Size(59, 25);
            Hello_lable.TabIndex = 0;
            Hello_lable.Text = "label1";
            // 
            // MainFormcs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Hello_lable);
            Name = "MainFormcs";
            Text = "MainFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Hello_lable;
    }
}