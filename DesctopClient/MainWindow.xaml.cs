using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClientTodoLibraryNamespace;

namespace DesctopClient;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ClientTodoLibrary _client;

    public MainWindow()
    {
        InitializeComponent();
    }

    //private void Button_Click(object sender, RoutedEventArgs e)
    //{
    //    _client = new("http://localhost:5097", new System.Net.Http.HttpClient());
    //    ICollection<Person> result = _client.GetAllAsync().Result;


    //}
}
