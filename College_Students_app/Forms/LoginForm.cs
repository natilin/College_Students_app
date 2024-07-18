using College_Students_app.DAL;
using College_Students_app.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Students_app.Forms
{
    public partial class LoginForm : Form
    {
        private FormHandler _handler;
        private SignUpRepository _signUpRepository;
        public LoginForm(SignUpRepository signUpRepository, FormHandler handler)
        {
            InitializeComponent();
            _signUpRepository = signUpRepository;
            _handler = handler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string natID = textBox_TZ.Text.Trim();
            string pass = textBox_pass.Text.Trim();
            int? ID = _signUpRepository.AuthenticateUser(natID, pass);
            if (ID != null)
            {
                _handler.ShowForm("MainForm", (int)ID);
            }
            else
            {
                textBox_TZ.Clear();
                textBox_pass.Clear();
                string message = "Username or password is incorrect";
                MessageBox.Show(message);
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

        private void linkLabel_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _handler.ShowForm("SignUpForm");
        }
    }
}
