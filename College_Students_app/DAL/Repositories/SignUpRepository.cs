using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Students_app.DAL.Repositories
{
    public class SignUpRepository
    {
        private readonly DBContext _dbContext;
        public SignUpRepository(DBContext dBContext)
        {
            DBContext _dbContext = dBContext;
        }
        public bool SignUp(string natID, string firstName, string lastName, string password)
        {
            string query = @"INSERT INTO Students (NatID,First_Name, Last_Name,Total_Price,  Password)
                             VALUES (@NatID, @FirstName, @LastName,0,  @Pass)";

            SqlParameter[] parameters = {
                new SqlParameter("@NatID", natID),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Pass", password),
            };
            int rowAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowAffected > 0;
        }
        public bool AuthenticateUser(string natID, string password)
        {
            string query = @"SELECT Student_ID FROM Students WHERE NatID = @NatID AND Password = @Pass ";
            SqlParameter[] parameters = {
                new SqlParameter("@NatID", natID),
                new SqlParameter("@Pass", password),
            };
            string result = (string)_dbContext.ExecuteScalar(query, parameters);
            return result != null;
        }
    }
}
