namespace Sales.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField, T Value, [CallerMemberName] string propropertyName=null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, Value))
            {
                return;
            }
            backingField = Value;
            this.OnPropertyChanged(propropertyName);
        }
    }
}
