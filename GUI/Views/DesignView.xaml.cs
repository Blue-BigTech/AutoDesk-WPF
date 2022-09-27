using System.Windows;
using System.Windows.Input;

namespace DoorPROGUI.Views
{
    public partial class DesignView
    {
        // private DoorSettingsBase DoorSettings { get; set; }
        public MainWindow MainWindow { get; }
        public DesignView()
        {
            // MainWindow = doorSettings.MainWindow;
            // DoorSettings = doorSettings;
            
            InitializeComponent();
        }

        private void GoHome(object sender, MouseButtonEventArgs e)
        {
            MainWindow.MainContent.Children.Clear();
            MainWindow.MainContent.Children.Add(new HomeView());
        }

        private void Back_OnClicked(object sender, RoutedEventArgs e)
        {
            MainWindow.MainContent.Children.Clear();
            // MainWindow.MainContent.Children.Add();
        }

        private void HandlesButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainContent.Children.Clear();
            MainWindow.MainContent.Children.Add(new HandleView(this));
        }
    }
}