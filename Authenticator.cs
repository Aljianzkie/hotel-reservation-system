using BCrypt.Net;
using hotel_reservation_system;
using System.Data;

namespace PhilippineFoodFestival
{
    public class Authenticator
    {
        public bool AdminLogin(string username, string password)
        {
            DatabaseManager db = new DatabaseManager();

            // Only search by username
            string sql = "SELECT Password FROM users WHERE Username = @username";

            var parameters = new Dictionary<string, object>
            {
                { "@username", username }
            };

            DataTable result = db.ExecuteQueryWithParams(sql, parameters);

            // If Username does not exist return false
            if (result.Rows.Count == 0)
            {
                return false;
            }

            // Get the hashed password from database
            string storedHash = result.Rows[0]["Password"].ToString();

            // Compare entered password with stored BCrypt hash
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}