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

namespace Griddy
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int posX { get; set; }
        public int posY { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            posX++;
            posY++;
        }
    }
}
