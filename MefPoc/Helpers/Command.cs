using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MefPoc
{
    public class Command : ICommand
    {
        public Command(Action<object> executeThis)
            : this(executeThis,(o) => { return true; })
        {
        }

        public Command(Action<object> executeThis, Func<object,bool> canExecuteThis)
        {
            _execute = executeThis;
            _canExecute = canExecuteThis;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        // Private members
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
 
    }
}
