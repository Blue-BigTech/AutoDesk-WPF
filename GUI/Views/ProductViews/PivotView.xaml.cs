using System.Globalization;
using System.Windows;
using GUI.Helpers;
using GUI.Stores;

namespace GUI.Views.ProductViews
{
    public partial class PivotDoorView
    {
        private NavigationStore Nav { get; set; }
        public PivotDoorView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            Nav.SpecificProductView = this;
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }

        private void Back_GeneralProductView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.GeneralProductView);
        }

        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }
        private void Next_DesignView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.DesignView ?? new DesignView(Nav));
        }
    }
}