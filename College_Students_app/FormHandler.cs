using College_Students_app.DAL;
using College_Students_app.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Students_app
{
    public class FormHandler
    {
        Form logingform;
        private bool _isNavigating = false;
        public SignUpRepository SignUpRepository;
        public DBContext DBContext;
        public FormHandler(DBContext dBContext)
        {
            DBContext dbCox = dBContext;

            SignUpRepository = new SignUpRepository(dbCox);
            logingform = new Login_form(SignUpRepository ,this);
            logingform.Show();

        }
    }
}
