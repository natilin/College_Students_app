using College_Students_app.DAL;
using College_Students_app.DAL.Repositories;
using College_Students_app.Forms;
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
        public bool IsNavigating = false;
        public SignUpRepository SignUpRepository;
        public DBContext DBContext;
        public FormHandler(DBContext dBContext)
        {
            DBContext dbCox = dBContext;

            SignUpRepository = new SignUpRepository(dbCox);
            logingform = new LoginForm(SignUpRepository, this);
            logingform.Show();

        }
        public void ShowForm(string formName, int? ID = null)
        {
            CloseAllForms();

            Form form = formName switch
            {
                "LoginForm" => new LoginForm(SignUpRepository, this),
                "MainForm" => new MainForm(this),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName)),
            };
            form.Show();

        }
        private void CloseAllForms()
        {
            IsNavigating = true;
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            IsNavigating = false;
        }
    }
}
