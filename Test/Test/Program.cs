//using System.Data.SqlClient;

using System.Data.SqlClient;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(@"Server=ByashaLaptop\SQLEXPRESS, 49172;Database=Reckords;User ID=TEST2;Password=qwerty12345");

            connection.Open();

            var sqlQuery = $"SELECT TOP 10 * FROM Reckord where maptype = 1 ORDER BY Score ASC";
            using SqlCommand command = new(sqlQuery, connection);
            using SqlDataReader reader = command.ExecuteReader();

           
            while (reader.Read())
            {
                string name = (string)reader["Nickname"];
                int score = (int)reader["Score"];
                DateTime date = (DateTime)reader["ScoreDate"];
                Console.WriteLine($"Name = {name} score = {score} date = {date}");
            }
            reader.Close();
        }
    }
}