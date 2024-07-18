namespace College_Students_app.Forms
{
    partial class LoginForm
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
            button_Enter = new Button();
            label_TZ = new Label();
            label2 = new Label();
            textBox_TZ = new TextBox();
            textBox_pass = new TextBox();
            linkLabel_sign_up = new LinkLabel();
            SuspendLayout();
            // 
            // button_Enter
            // 
            button_Enter.Location = new Point(256, 274);
            button_Enter.Name = "button_Enter";
            button_Enter.Size = new Size(112, 34);
            button_Enter.TabIndex = 0;
            button_Enter.Text = "כניסה";
            button_Enter.UseVisualStyleBackColor = true;
            button_Enter.Click += button1_Click;
            // 
            // label_TZ
            // 
            label_TZ.AutoSize = true;
            label_TZ.Location = new Point(256, 29);
            label_TZ.Name = "label_TZ";
            label_TZ.Size = new Size(104, 25);
            label_TZ.TabIndex = 1;
            label_TZ.Text = "תעודת זהות";
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(linkLabel_sign_up);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_TZ);
            Controls.Add(label2);
            Controls.Add(label_TZ);
            Controls.Add(button_Enter);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Login_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Enter;
        private Label label_TZ;
        private Label label2;
        private TextBox textBox_TZ;
        private TextBox textBox_pass;
        private LinkLabel linkLabel_sign_up;
    }

       
}