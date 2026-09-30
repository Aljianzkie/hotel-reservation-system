using BCrypt.Net;
using MySql.Data.MySqlClient;
using System.Data;

namespace hotel_reservation_system
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Users(int id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }
    }

    public class UsersManager
    {
        public void SignUpUser(Users user)
        {
            DatabaseManager db = new DatabaseManager();

            string sql = "INSERT INTO users (Username, Password, Created_At, Updated_At) VALUES (@username, @password, @created_at, @updated_at)";

            var parameters = new Dictionary<string, object>
            {
                { "@username", user.Username },
                { "@password", user.Password },
                { "@created_at", DateTime.Now },
                { "@updated_at", DateTime.Now }
            };

            int rowsAffected = db.ExecuteNonQuery(sql, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Register Successful");
            }
            else
            {
                MessageBox.Show("Register Failed");
            }
        }

        public DataTable GetUsers()
        {
            DatabaseManager db = new DatabaseManager();

            string sql = "SELECT * FROM users";

            return db.ExecuteQuery(sql);
        }

        public DataTable SearchUser(string searchKey)
        {
            DatabaseManager db = new DatabaseManager();

            string sql = "SELECT * FROM users WHERE Username LIKE @username ORDER BY Id ASC";

            var parameters = new Dictionary<string, object>
            {
                {"@username", "%" + searchKey + "%"}
            };

            return db.ExecuteQueryWithParams(sql, parameters);
        }

        public bool UpdateUser(int Id, Users user)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();

                string sql = @"UPDATE users SET Username = @username, Password = @password WHERE Id = @id";

                var parameters = new Dictionary<string, object>
                {
                     {"@id", Id},
                     {"@username", user.Username},
                     {"@password", user.Password}
                };

                int rowsAffected = db.ExecuteNonQuery(sql, parameters);

                if (rowsAffected <= 0)
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database Error: " + ex.Message);
            }

            return true;
        }

        public bool DeleteUser(int Id)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = "DELETE FROM users WHERE Id = @id";
                var parameters = new Dictionary<string, object>
                {
                    {"@id", Id}
                };
                int rowsAffected = db.ExecuteNonQuery(sql, parameters);
                if (rowsAffected <= 0)
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Database Error: " + ex.Message);
            }
            return true;
        }
    }
}