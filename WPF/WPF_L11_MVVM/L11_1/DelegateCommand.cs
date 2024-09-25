using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_L11_1
{
    internal class DelegateCommand : ICommand // RelayCommand
    {
        private Action<object> _execute;

        public DelegateCommand (Action<object> executeAction)
        {
            _execute = executeAction;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
