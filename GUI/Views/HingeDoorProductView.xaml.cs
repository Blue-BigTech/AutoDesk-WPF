// using System.Windows;
// using System.Windows.Controls;
// using DoorPROGUI.Helpers;
//
// namespace DoorPROGUI.Views
// {
//     public partial class HingeDoorProductView : DoorSettingsView
//     {
//         public ProductSelectionView Psv { get; }
//
//         public HingeDoorProductView(ProductSelectionView productSelectionView) : base(productSelectionView)
//         {
//             Psv = productSelectionView;
//             MainWindow = Psv.Cv.Mv;
//             InitializeComponent();
//         }
//
//         private void BackButton_OnClick(object sender, RoutedEventArgs e)
//         {
//             MainWindow.MainContent.Children.Clear();
//             MainWindow.MainContent.Children.Add(Psv);
//         }
//     }
// }