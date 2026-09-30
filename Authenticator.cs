using System.Data;


namespace hotel_reservation_system
{
    public class Authenticator
    {
        public bool AdminLogin(string username, string password)
        {
            DatabaseManager db = new DatabaseManager();

            string sql = "SELECT * FROM users WHERE Username = @username AND Password = @password";

            var parameters = new Dictionary<string, object>
            {
                {"@username", username },
                {"@password", password }
            };

            DataTable result = db.ExecuteQueryWithParams(sql, parameters);

            return result.Rows.Count > 0;
        }
    }
}
