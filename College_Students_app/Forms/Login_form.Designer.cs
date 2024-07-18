namespace College_Students_app
{
    partial class Login_form
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_TZ = new TextBox();
            textBox_pass = new TextBox();
            linkLabel_sign_up = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(256, 279);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "כניסה";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "סיסמא";
            // 
            // textBox_TZ
            // 
            textBox_TZ.Location = new Point(236, 85);
            textBox_TZ.Name = "textBox_TZ";
            textBox_TZ.Size = new Size(150, 31);
            textBox_TZ.TabIndex = 3;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(236, 206);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(150, 31);
            textBox_pass.TabIndex = 4;
            textBox_pass.UseSystemPasswordChar = true;
            // 
            // linkLabel_sign_up
            // 
            linkLabel_sign_up.AutoSize = true;
            linkLabel_sign_up.Location = new Point(287, 357);
            linkLabel_sign_up.Name = "linkLabel_sign_up";
            linkLabel_sign_up.Size = new Size(58, 25);
            linkLabel_sign_up.TabIndex = 5;
            linkLabel_sign_up.TabStop = true;
            linkLabel_sign_up.Text = "רישום";
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(linkLabel_sign_up);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_TZ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Login_form";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Login_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox_TZ;
        private TextBox textBox_pass;
        private LinkLabel linkLabel_sign_up;
    }
}