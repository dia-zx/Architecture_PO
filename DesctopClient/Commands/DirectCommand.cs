using DesctopClient.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopClient.Commands;

class DirectCommand : Command
{
    private Func<object?, bool> _canExecute;
    private Action<object?> _execute;
    public DirectCommand(Action<object?> execute, Func<object?, bool> canExecute)
    {
        _canExecute = canExecute; _execute = execute;
    }
    public override bool CanExecute(object? parameter)
    {
        return _canExecute(parameter);
    }

    public override void Execute(object? parameter)
    {
        _execute(parameter);
    }
}

