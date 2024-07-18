namespace College_Students_app.Forms
{
    partial class SignUpForm
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
            label1 = new Label();
            textBox_fName = new TextBox();
            label_Name = new Label();
            label3 = new Label();
            label_passwors = new Label();
            textBox_lName = new TextBox();
            textBox_pass = new TextBox();
            button_SignUp = new Button();
            label2 = new Label();
            textBox_NatID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 46);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "הרשמה למערכת";
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(330, 162);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(150, 31);
            textBox_fName.TabIndex = 1;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(191, 168);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(81, 25);
            label_Name.TabIndex = 2;
            label_Name.Text = "שם פרטי";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 228);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "שם משפחה";
            // 
            // label_passwors
            // 
            label_passwors.AutoSize = true;
            label_passwors.Location = new Point(191, 289);
            label_passwors.Name = "label_passwors";
            label_passwors.Size = new Size(64, 25);
            label_passwors.TabIndex = 4;
            label_passwors.Text = "סיסמא";
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(330, 222);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(150, 31);
            textBox_lName.TabIndex = 5;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(330, 283);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(150, 31);
            textBox_pass.TabIndex = 6;
            // 
            // button_SignUp
            // 
            button_SignUp.Location = new Point(355, 354);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(112, 34);
            button_SignUp.TabIndex = 7;
            button_SignUp.Text = " הירשם";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 107);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 8;
            label2.Text = "תעודת זהות";
            // 
            // textBox_NatID
            // 
            textBox_NatID.Location = new Point(330, 107);
            textBox_NatID.Name = "textBox_NatID";
            textBox_NatID.Size = new Size(150, 31);
            textBox_NatID.TabIndex = 9;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_NatID);
            Controls.Add(label2);
            Controls.Add(button_SignUp);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_lName);
            Controls.Add(label_passwors);
            Controls.Add(label3);
            Controls.Add(label_Name);
            Controls.Add(textBox_fName);
            Controls.Add(label1);
            Name = "SignUpForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "טופס הרשמה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_fName;
        private Label label_Name;
        private Label label3;
        private Label label_passwors;
        private TextBox textBox_lName;
        private TextBox textBox_pass;
        private Button button_SignUp;
        private Label label2;
        private TextBox textBox_NatID;
    }
}