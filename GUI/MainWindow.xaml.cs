using System.Windows;
using System.Windows.Input;
using GUI.ViewModels;
using GUI.Views;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            ContentDisplay.Children.Add(new HomeView(this));
        }

        //WINDOW COMMANDS
        private void ExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeWindow_Clicked(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DragWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}