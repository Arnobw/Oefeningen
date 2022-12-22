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

namespace wpfapke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a Grid and add it to a component of your page
Grid mainGrid = new Grid();
root.Children.Add(mainGrid); 

for (int i = 0; i < 64; i++)
{
    // I am creating a Grid with a TextBlock inside, 
    // it will have the same apperance as a Rectangle, 
    // but this way you can have a Text inside
    Grid g = new Grid();
    TextBlock tb = new TextBlock();

    tb.Text = i.ToString();
    g.Children.Add(tb);

    // Here you set the Grid properties, such as border and alignment
    // You can add other properties and events you need

    g.HorizontalAlignment = HorizontalAlignment.Center;
    g.VerticalAlignment = VerticalAlignment.Center;

    // Add the newly created Grid to the outer Grid
    mainGrid.RowDefinitions.Add(new RowDefinition());
    mainGrid.Children.Add(g);

    // Set the row of the Grid. 
    Grid.SetRow(g, i);
}
        }
    }
}
