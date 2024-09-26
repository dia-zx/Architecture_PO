using Lesson11.Servises.Repositories.PersonsRepository.Model;
using Lesson11.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.Data.Sqlite;

namespace Lesson11.Servises.Repositories.ToDoReRepository
{
    public class ToDoRepository : IToDoRepository
    {
        public int Add(ToDo item)
        {
            using var connection = new SqliteConnection(Program.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO todo (PersonID, Description, Priority, Deadline, Isdone)
                                    VALUES(@PersonID, @Description, @Priority, @Deadline, @Isdone)";
            command.Parameters.AddWithValue("@PersonID", item.PersonID);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.AddWithValue("@Priority", item.Priority);
            command.Parameters.AddWithValue("@Deadline", item.Deadline.Ticks - DateTime.UnixEpoch.Ticks);
            if (item.Isdone)
                command.Parameters.AddWithValue("@Isdone", 1);
            else
                command.Parameters.AddWithValue("@Isdone", 0);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public int Delete(int id)
        {
            using var connection = new SqliteConnection(Program.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM todo WHERE ToDoId = @ToDoId";
            command.Parameters.AddWithValue("@ToDoId", id);
            command.Prepare();
            return command.ExecuteNonQuery();
        }


        public ToDo GetById(int id)
        {
            using var connection = new SqliteConnection(Program.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM todo WHERE ToDoId = @ToDoId";
            command.Parameters.AddWithValue("@ToDoId", id);
            command.Prepare();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ToDo item = new()
                {
                    ToDoId = reader.GetInt32(0),
                    PersonID = reader.GetInt32(1),
                    Description = reader.GetString(2),
                    Priority = reader.GetInt32(3),
                    Deadline = DateTime.UnixEpoch.AddTicks(reader.GetInt32(4)),
                    Isdone = reader.GetInt32(5) != 0,
                };
                return item;
            }
            return null;
        }

        public int Update(ToDo item)
        {
            using var connection = new SqliteConnection(Program.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO todo (PersonID, Description, Priority, Deadline, Isdone)
                                    VALUES(@PersonID, @Description, @Priority, @Deadline, @Isdone) WHERE ToDoId = @ToDoId";
            command.Parameters.AddWithValue("@ToDoId", item.ToDoId);
            command.Parameters.AddWithValue("@PersonID", item.PersonID);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.AddWithValue("@Priority", item.Priority);
            command.Parameters.AddWithValue("@Deadline", item.Deadline.Ticks - DateTime.UnixEpoch.Ticks);
            if (item.Isdone)
                command.Parameters.AddWithValue("@Isdone", 1);
            else
                command.Parameters.AddWithValue("@Isdone", 0);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public List<ToDo> GetAll()
        {
            using var connection = new SqliteConnection(Program.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM todo";
            var reader = command.ExecuteReader();
            List<ToDo> result = [];
            while (reader.Read())
            {
                ToDo item = new()
                {
                    ToDoId = reader.GetInt32(0),
                    PersonID = reader.GetInt32(1),
                    Description = reader.GetString(2),
                    Priority = reader.GetInt32(3),
                    Deadline = DateTime.UnixEpoch.AddTicks(reader.GetInt32(4)),
                    Isdone = reader.GetInt32(5) != 0,
                };
                result.Add(item);
            }
            return result;
        }
    }
}
