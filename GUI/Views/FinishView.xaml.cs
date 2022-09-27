using System.Windows;
using System.Windows.Controls;
using GUI.Stores;

namespace GUI.Views
{
    public partial class FinishView : UserControl
    {
        public NavigationStore Nav { get; set; }
        public FinishView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }

        private void Back_HandleView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.HandleView);
        }

        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }
    }
}