// using System.Windows;
// using System.Windows.Input;
//
// namespace DoorPROGUI.Views
// {
//     public partial class HandleView
//     {
//         private DesignView DesignView { get; }
//         public MainWindow MainWindow { get; }
//         
//         public HandleView(DesignView designView)
//         {
//             MainWindow = designView.MainWindow;
//             DesignView = designView;
//             InitializeComponent();
//         }
//
//         private void GoHome(object sender, MouseButtonEventArgs e)
//         {
//             MainWindow.MainContent.Children.Clear();
//             MainWindow.MainContent.Children.Add(new HomeView());
//         }
//
//         private void Back_OnClicked(object sender, RoutedEventArgs routedEventArgs)
//         {
//             MainWindow.MainContent.Children.Clear();
//             MainWindow.MainContent.Children.Add(DesignView);
//         }
//
//         private void Overview_OnClicked(object sender, RoutedEventArgs e)
//         {
//             MainWindow.MainContent.Children.Clear();
//             MainWindow.MainContent.Children.Add(new FinishView(this));
//         }
//     }
// }