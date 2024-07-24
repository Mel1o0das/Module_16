using System.Windows;

namespace WPF.Commands
{
    class CloseButtonCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
