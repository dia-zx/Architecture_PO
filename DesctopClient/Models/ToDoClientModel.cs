using ClientTodoLibraryNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesctopClient.Models;

class ToDoClientModel
{
    private ClientTodoLibrary? _client;

    private bool _IsConnected = false;
    public bool IsConnected { get => _IsConnected; }

    public void Connect(string ConnectionString)
    {
        try
        {
            _client = new(ConnectionString, new HttpClient());
        }
        catch (Exception ex)
        {
            _IsConnected = false;
            _client = null;
            MessageBox.Show(ex.Message);
            return;
        }
        _IsConnected = true;
    }

    public List<Person> GetAllPersons()
    {
        if (_client == null) return new List<Person>();
        return _client.GetAllAsync().Result.ToList();
    }

    public Person GetByIDPerson(int id)
    {
        if (_client == null) return null;
        try
        {
            return _client.GetByIdAsync(id).Result;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return null;
    }

    public int AddPerson(Person person)
    {
        if (_client == null) return 0;
        return _client.AddAsync(person).Result;
    }

    public int DeleteByIDPerson(int id)
    {
        if (_client == null) return 0;
        try
        {
            return _client.DeleteByIdAsync(id).Result;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return 0;
    }

}

