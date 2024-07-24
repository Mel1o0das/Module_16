using System.Data;
using System.Windows.Input;
using System.Windows.Media;
using WPF.Commands;
using WPF.Services;

namespace WPF.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private readonly ConnectionState _sqlState;
        private readonly ConnectionState _accessState;
        private readonly NavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainWindowViewModel(NavigationStore navigationStore, ConnectionState sqlState, ConnectionState accessState)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _sqlState = sqlState;
            _accessState = accessState;
            CloseApp = new CloseButtonCommand();
        }

        public Brush ColorSqlDbConnect
        {
            get
            {
                if (_sqlState == ConnectionState.Open)
                {
                    return Brushes.Green;
                }
                return Brushes.Red;
            }
        }

        public Brush ColorAccessDbConnect
        {
            get
            {
                if (_accessState == ConnectionState.Open)
                {
                    return Brushes.Green;
                }
                return Brushes.Red;
            }
        }
        public ICommand CloseApp { get; }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
