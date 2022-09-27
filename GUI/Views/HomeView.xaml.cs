using System.Windows;
using GUI.Stores;

namespace GUI.Views
{
    public partial class HomeView
    {
        private NavigationStore Nav { get; set; }
        public HomeView(MainWindow mainWindow)
        {
            Nav = new NavigationStore
            {
                MainWindow = mainWindow,
                HomeView = this
            };
            
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }
        public HomeView()
        {
            // Default constructor, sam zarad warning messiga v MainWindow.xaml
        }

        private void Construction_OnClicked(object sender, RoutedEventArgs e)
        {
            const bool StandAloneConstructionOpening = true;
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new ConstructionView(Nav, StandAloneConstructionOpening));
        }

        private void Automatic_OnClicked(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new ProductSelectionView(Nav));
        }

        private void Manual_OnClicked(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new ManualDrawingView(Nav));
        }
    }
}