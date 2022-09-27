using System.Windows;
using System.Windows.Controls;
using GUI.Views;
using GUI.Stores;

namespace GUI.Views
{
    public partial class ManualDrawingView : UserControl
    {
        private NavigationStore Nav { get; set; }
        public ManualDrawingView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }

        private void Home_OnClicked(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }

        private void SL_Prod_BottomDims_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Triggered");
        }
    }
}