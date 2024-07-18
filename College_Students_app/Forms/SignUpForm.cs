using College_Students_app.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Students_app.Forms
{
    public partial class SignUpForm : Form
    {
        private FormHandler _handler;
        private SignUpRepository _signUpRepository;
        public SignUpForm(SignUpRepository signUpRepository ,FormHandler handler)
        {
            InitializeComponent();
            _handler = handler;
            _signUpRepository = signUpRepository;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string natID = textBox_NatID.Text.Trim();
            string fName = textBox_fName.Text.Trim();
            string lName = textBox_lName.Text.Trim();
            string pass = textBox_pass.Text.Trim();
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim().Length == 0)
                {
                    MessageBox.Show("יש למלא את כל השדות");
                    return;
                }
            }
            bool success = _signUpRepository.SignUp(natID, fName, lName, pass);

            if (success)
            {
                MessageBox.Show("משתמש נרשם בהצלחה!");
                _handler.ShowForm("LoginForm");
            }
            else {
                MessageBox.Show("משתמש כבר קיים במערכת!");
                CleanTexts();
            }

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_handler.IsNavigating)
            {
                Application.Exit();
            }
        }
        private void CleanTexts()
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.Text = tb.Text = "";
            }
        }
    }
}   
