using System;
using System.Windows.Input;

namespace WPF_Professional_Modern_Flat_UI.Core;

public class RelayCommand : ICommand
{
    private readonly Func<object, bool> _canExecute;
    private readonly Action<object> _execute;

    public bool CanExecute(object? parameter)
    {
        return _canExecute ==null || _canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _canExecute(parameter);
    }

    public event EventHandler? CanExecuteChanged;

    public RelayCommand(Func<object, bool> canExecute, Action<object> execute)
    {
        _canExecute = canExecute;
        _execute = execute;
    }
}