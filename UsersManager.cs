using BCrypt.Net;

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

            // Hash the password before storing
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);

            string sql = "INSERT INTO users (Username, Password) VALUES (@username, @password)";

            var parameters = new Dictionary<string, object>
            {
                { "@username", user.Username },
                { "@password", passwordHash }
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

        // Verify password during login
        public bool VerifyPassword(string storedHash, string providedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(providedPassword, storedHash);
        }
    }
}