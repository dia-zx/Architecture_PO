
using Lesson10.Services;
using Lesson10.Servises.Repositories.PersonsRepository;
using Lesson10.Servises.Repositories.ToDoReRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.Sqlite;

namespace Lesson11;

public class Program
{
    public static string ConnectionString = "Data Source=data.db";

    public static void Main(string[] args)
    {
        //CreateDB(ConnectionString);
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddScoped<IToDoRepository, ToDoRepository>();
        builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();
        builder.Services.AddSingleton<IInMemoryToDoCollection, InMemoryToDoCollection>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }

    public static void CreateDB(string connectionString)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "DROP TABLE IF EXISTS persons";
        command.ExecuteNonQuery();

        command.CommandText = "DROP TABLE IF EXISTS todo";
        command.ExecuteNonQuery();

        command.CommandText = @"CREATE TABLE persons
                                (PersonId INTEGER PRIMARY KEY,
                                Name TEXT
                                )";
        command.ExecuteNonQuery();

        command.CommandText = @"CREATE TABLE todo
                                (TodoId INTEGER PRIMARY KEY,
                                PersonID INTEGER,
                                Description TEXT,
                                Priority INTEGER,
                                Deadline INTEGER,
                                Isdone INTEGER
                                )";
        command.ExecuteNonQuery();
    }
}

