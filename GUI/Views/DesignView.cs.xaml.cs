using System.Windows;
using GUI.Views;
using GUI.Stores;

namespace GUI.Views
{
    public partial class DesignView
    {
        private NavigationStore Nav { get; set; }
        public DesignView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            Nav.DesignView = this;

            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }

        private void Back_SpecificProductView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.SpecificProductView);
        }
        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }
        private void Next_HandleView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.HandleView ?? new HandleView(Nav));
        }
    }
}