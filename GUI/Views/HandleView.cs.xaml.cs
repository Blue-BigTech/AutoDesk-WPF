using System.Windows;
using GUI.Stores;

namespace GUI.Views
{
    public partial class HandleView
    {
        private NavigationStore Nav { get; set; }
        
        public HandleView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            Nav.HandleView = this;

            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }
        private void ChangeHandleSettings_OnChecked(object sender, RoutedEventArgs e)
        {
            HandleSettings.Visibility = Visibility.Visible;
            HandleImage.Visibility = Visibility.Collapsed;
        }
        private void ChangeHandleSettings_OnUnchecked(object sender, RoutedEventArgs e)
        {
            HandleSettings.Visibility = Visibility.Collapsed;
            HandleImage.Visibility = Visibility.Visible;
        }
        private void Back_designView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.DesignView);
        }
        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }
        private void Next_FinishView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.FinishView ?? new FinishView(Nav));
        }
    }
}