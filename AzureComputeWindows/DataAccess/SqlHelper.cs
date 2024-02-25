using AzureComputeWindows.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AzureComputeWindows.DataAccess
{
    public class SqlHelper
    {
        private static string db_source = "mydbserverazure.database.windows.net";
        private static string db_user = "Azureuser";
        private static string db_password = "Azure@123456";
        private static string db_database = "myazuredb";

        private static string GetConnection()
        {
            // Here we are creating the SQL connection
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return _builder.ConnectionString;
        }
        public static List<Course> GetAllCourses(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var output = con.Query<Course>($"select * from Courses").ToList();
                //using stored procedure
                // var output2 = con.Query<Author>($"dbo.Authors_LastName @LastName",lastname).ToList();
                return output;
            }

        }
    }
}
