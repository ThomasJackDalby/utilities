using System.Windows.Input;

namespace Dalby.WPF
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action action;

        public RelayCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) => action();
    }

    public class RelayCommand<T> : ICommand
        where T : class
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action<T?> action;

        public RelayCommand(Action<T?> action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) => action(parameter as T);
    }
}
