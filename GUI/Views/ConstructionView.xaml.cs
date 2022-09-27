using System.Linq;
using System.Reflection;
using System.Windows;
using GUI.Views;
using GUI.Stores;

namespace GUI.Views
{
    public partial class ConstructionView
    {
        private NavigationStore Nav { get; set; }
        public ConstructionView(NavigationStore navigationStore, bool standAloneOpening)
        {
            Nav = navigationStore;
            Nav.ConstructView = this;
            
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;

            if (standAloneOpening)
            {
                DrawOpening.Visibility = Visibility.Visible;
                GeneralProductSelection.Visibility = Visibility.Collapsed;
            }
            else
            {
                DrawOpening.Visibility = Visibility.Collapsed;
                GeneralProductSelection.Visibility = Visibility.Visible;
            }
        }

        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }

        private void Next_GeneralProductView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.GeneralProductView ?? new GeneralProductView(Nav));
        }
    }
}