using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NaamRaden
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string currentName;
        public string CurrentName
        {

            get { return currentName; }
            set
            {
                currentName = value;
                NotifyPropertyChanged(nameof(currentName));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }
}