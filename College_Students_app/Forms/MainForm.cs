using College_Students_app.DAL.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace College_Students_app.Forms
{
    public partial class MainForm : Form
    {
        private FormHandler _handler;
        private CoursesRepositories _coursesRepositories;
        private int _userID;
        public MainForm(int user_id, CoursesRepositories coursesRepositories, FormHandler handler)
        {
            InitializeComponent();
            _handler = handler;
            _coursesRepositories = coursesRepositories;
            _userID = user_id;
            LoadMyCourses(_userID);
        }
        private void LoadMyCourses(int userID)
        {
            List<string> userCourses = _coursesRepositories.GetUserCourses(userID);

            listView_Courses_list.Items.AddRange(userCourses.Select(course => new ListViewItem(new string[] { course })).ToArray());
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_handler.IsNavigating)
            {
                Application.Exit();
            }
        }
    }
}
