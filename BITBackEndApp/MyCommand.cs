using System;
using NLog;
using System.Windows.Input;

namespace BITBackEndApp
{

    public class MyCommand : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private Action _whatToExcecute;
        public event EventHandler CanExecuteChanged;
        private bool _canExecute;
        public MyCommand(Action what, bool canExecute)
        {
            _whatToExcecute = what;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }
        public void Execute(object parameter)
        {
            _whatToExcecute.Invoke(); //Invoke is a method
            //that just gives a call to the method and runs it
        }
    }
}
