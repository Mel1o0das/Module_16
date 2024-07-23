using ClassLibrary.ConnectDB;
using System.Windows;
using WPF.Services;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private SqlConnect sqlConnect = new();
        private AccessConnect accessConnect = new();
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            //_navigationStore.CurrentViewModel = new AuthorizationVM(_bank, _navigationStore);
            sqlConnect.ConnectToSqlDB();
            accessConnect.ConnectToAccessDB();

            MainWindow = new MainWindow()
            {
                
                //DataContext = new MainWindowVM(_navigationStore, _bank)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
