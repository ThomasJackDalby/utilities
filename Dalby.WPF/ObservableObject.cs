using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dalby.WPF
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (PropertyChanged is not null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
