using Microsoft.Data.Sqlite;


public class UserDB
{
    private readonly string dbFileName;

    public UserDB(string dbFilePath="database.db")
    {
        dbFileName = $"Data Source={dbFilePath}";
        InitializeDatabase();
    }

    public void InitializeDatabase()
    {
        using (var connection = new SqliteConnection(dbFileName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Email TEXT,
                        Password TEXT
                    );
                ";

                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertUser(User user)
    {
        using (var connection = new SqliteConnection(dbFileName))
        {
            connection.Open();

            using (var insertCommand = connection.CreateCommand())
            {
                insertCommand.CommandText = @"
                    INSERT INTO Users (Email, Password)
                    VALUES (@Email, @Password);
                ";
                
                insertCommand.Parameters.AddWithValue("@Email", user.Email);
                insertCommand.Parameters.AddWithValue("@Password", user.Password);
                insertCommand.ExecuteNonQuery();
            }
        }
    }

    public List<User> GetAllUsers()
    {
        var users = new List<User>();
        using (var connection = new SqliteConnection(dbFileName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Users;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User(
                            reader.GetString(1),
                            reader.GetString(2)
                        ));
                    }
                }
            }
        }

        return users;
    }
}
