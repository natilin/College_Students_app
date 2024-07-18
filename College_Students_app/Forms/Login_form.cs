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

namespace College_Students_app
{
    public partial class Login_form : Form
    {
        private FormHandler _handler;
        private SignUpRepository _signUpRepository;
        public Login_form(SignUpRepository signUpRepository, FormHandler handler)
        {
            InitializeComponent();
            _signUpRepository = signUpRepository;
            _handler = handler;
        }


    }
}
