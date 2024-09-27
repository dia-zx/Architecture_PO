using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesctopClient.ViewModels.Base;

internal abstract class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string PropertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }

    /// <summary>
    /// Установка свойства
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="field">поле свойства</param>
    /// <param name="value">устанавливаемое значение</param>
    /// <param name="PropertyName">Имя свойства (присваивается автоматически)</param>
    /// <returns>true - свойство установлено</returns>
    protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
    {
        if (Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(PropertyName);
        return true;
    }

    protected void PropertyUpdate(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
}

