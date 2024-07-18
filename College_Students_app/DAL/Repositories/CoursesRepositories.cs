using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Students_app.DAL.Repositories
{
    internal class CoursesRepositories
    {
        private readonly DBContext _dbContext;
        public CoursesRepositories(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
