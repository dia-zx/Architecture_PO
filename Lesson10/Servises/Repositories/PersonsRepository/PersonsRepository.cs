using Lesson10.Servises.Repositories.PersonsRepository.Model;
using Lesson10.Servises.Repositories.ToDoReRepository.Model;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lesson10.Servises.Repositories.PersonsRepository;

public class PersonsRepository : IRepository<Person, int>
{
    public int Add(Person item)
    {
        using var connection = new SqliteConnection(Program.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO persons (Name) VALUES(@Name)";
        command.Parameters.AddWithValue("@Name", item.Name);

        command.Prepare();
        return command.ExecuteNonQuery();
    }

    public int Delete(int id)
    {
        using var connection = new SqliteConnection(Program.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM persons WHERE PersonId = @PersonId";
        command.Parameters.AddWithValue("@PersonId", id);
        command.Prepare();
        return command.ExecuteNonQuery();
    }

    public List<Person> GetAll()
    {
        using var connection = new SqliteConnection(Program.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM persons";
        var reader = command.ExecuteReader();
        List<Person> result = [];
        while (reader.Read())
        {
            Person person = new()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
            result.Add(person);
        }
        return result;
    }

    public Person GetById(int id)
    {
        using var connection = new SqliteConnection(Program.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM persons WHERE PersonId = @PersonId";
        command.Parameters.AddWithValue("@PersonId", id);
        command.Prepare();
        var reader = command.ExecuteReader();

        if (reader.Read())
        {
            Person item = new()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(2),
            };
            return item;
        }
        return null;
    }

    public int Update(Person item)
    {
        using var connection = new SqliteConnection(Program.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO persons (Name) VALUES(@Name) WHERE PersonID = @PersonID";
        command.Parameters.AddWithValue("@PersonID", item.Id);
        command.Prepare();
        return command.ExecuteNonQuery();
    }
}

