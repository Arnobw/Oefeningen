using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfVoorArnoTwee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private int _row { get; set; } = 0;
        public int Row
        {
            get { return _row; }
            set { _row = value; OnPropertyChanged(); }
        }
        private int _column { get; set; } = 0;
        public int Column
        {
            get { return _column; }
            set { _column = value; OnPropertyChanged(); }
        }
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = sender as Button;
            Row = Grid.GetRow(s);
            Column = Grid.GetColumn(s);
        }
        //Code van het internet, moet ge niet vanbuiten kennen, is heel standard
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}