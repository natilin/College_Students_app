using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

    } List<string> GetCoursesListToRegestery(int ID)
    {
        string query = @"select DISTINCT c.Name
            from Courses c
            INNER JOIN Cycles ON c.Course_ID = Cycles.Course_ID
            INNER JOIN Cycles_Student ON Cycles.Cycle_ID = Cycles_Student.Cycle_ID
            WHERE Cycles_Student.Cycle_ID != @ID";
    }


    bool RegisteryToCycle(int studentID, int cycleID)
    {

        // משתמש בטרנזקציה כדי לוודא שלא ייתכן מצב שמתמש נרשם לקורס אבל לא התעדכן המחיר ברשימות או ההיפך
        string query = @"BEGIN TRANSACTION
	        DECLARE @success int;
	        BEGIN TRY
		
		        INSERT INTO Cycles_Student
		        VALUES (@Student_ID, @Cycle_ID);

		        DECLARE @Cycle_Price int;

		        SELECT @Cycle_Price = Price 
		        FROM Cycles
		        WHERE Cycle_ID =  @Cycle_ID

		        UPDATE Students 
		        SET Total_Price = Total_Price + @Cycle_Price
		        WHERE Student_ID = @Student_ID

		        SET @success = 1;
		        COMMIT TRANSACTION

	        END TRY

	        BEGIN CATCH
		        ROLLBACK TRANSACTION;
		        SET @success = 0;
	        END CATCH

        SELECT @success";

        SqlParameter[] parameters = {
                new SqlParameter("@Student_ID", studentID),
                new SqlParameter("@Cycle_ID", cycleID),
 
            };
    }

}
