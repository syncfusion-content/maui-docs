#nullable disable
using System;
using System.Windows.Input;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public sealed class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> execute;
        public DelegateCommand(Action<T> execute) { this.execute = execute; }
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => execute((T)parameter);
        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
