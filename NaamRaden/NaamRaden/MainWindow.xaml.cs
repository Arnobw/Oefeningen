using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NaamRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        MainViewModel vm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            KittyGriddy.DataContext = vm;
            //vm.CurrentName = NameField.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.CurrentName = NameField.Text;
            //CurrentName.Text = vm.CurrentName;
            MessageBox.Show($"bedankt voor het geld {vm.CurrentName} :3", "yippeeee", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
