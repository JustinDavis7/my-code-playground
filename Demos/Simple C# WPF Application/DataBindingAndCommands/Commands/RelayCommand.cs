using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBindingAndCommands.Commands
{
    public class RelayCommand : ICommand //This implements the interface ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Execute { get; set; } // Method that returns void, it performs an action with the object.
        private Predicate<object> _CanExecute { get; set; } // Method that returns a boolean, and takes in an object as an argument.

        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            _Execute = executeMethod;
            _CanExecute = canExecuteMethod;
        }

        // When a command is evoked, it will run these in order.
        public bool CanExecute(object? parameter)
        {
            return _CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
