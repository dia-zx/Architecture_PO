using ClientTodoLibraryNamespace;
using DesctopClient.Commands;
using DesctopClient.Models;
using DesctopClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesctopClient.ViewModels;

class MainVindowViewModel : ViewModel
{
    private ToDoClientModel _model = new ToDoClientModel();

    public ICommand CloseApplicationCommand { get => new CloseApplicationCommand(); }

    private string _ConnectionString = "http://localhost:5097";
    public string ConnectionString { get => _ConnectionString; set => Set(ref _ConnectionString, value); }

    public ICommand Connect
    {
        get => new DirectCommand((p) => _model.Connect(_ConnectionString), (p) => _ConnectionString.Length > 0);
    }

    public ICommand GetAllPersons
    {
        get => new DirectCommand((p) => { Persons = new ObservableCollection<Person>(_model.GetAllPersons()); }, (p) => _model.IsConnected);
    }

    public ICommand GetPersonById
    {
        get => new DirectCommand((p) =>
        {
            Person person = _model.GetByIDPerson(_PersonID_GetByID);
            if (person == null) return;
            Persons.Clear(); Persons.Add(person);
        }, (p) => _model.IsConnected);
    }

    public ICommand AddPerson
    {
        get => new DirectCommand((p) =>
        {
            if (_model.AddPerson(new Person { Name = _AddPersonString }) == 0) return;
            GetAllPersons.Execute(null);

        }, (p) => _model.IsConnected);
    }

    public ICommand DeletePersonById
    {
        get => new DirectCommand((p) =>
        {
            if( _model.DeleteByIDPerson(_PersonID_DeleteByID) == 0) return;
            GetAllPersons.Execute(null);
        }, (p) => _model.IsConnected);
    }

    private string _AddPersonString;
    public string AddPersonString { get => _AddPersonString; set => Set(ref _AddPersonString, value); }

    private ObservableCollection<Person> _Persons = new ObservableCollection<Person>();
    public ObservableCollection<Person> Persons { get => _Persons; set => Set(ref _Persons, value); }

    private int _PersonID_GetByID = 0;
    public int PersonID_GetByID { get => _PersonID_GetByID; set => Set(ref _PersonID_GetByID, value); }

    private int _PersonID_DeleteByID = 0;
    public int PersonID_DeleteByID { get => _PersonID_DeleteByID; set => Set(ref _PersonID_DeleteByID, value); }
}

