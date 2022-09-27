using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BusinessLogic.Classes;
using BusinessLogic.Settings;
using GUI.Commands;
using GUI.Views;
using GUI.ViewModels;
using GUI.Views.ProductViews;
using GUI.Helpers;
using GUI.Stores;

namespace GUI.Views
{
    public partial class ProductSelectionView
    {
        private NavigationStore Nav { get; set; }
        public ProductSelectionView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            Nav.ProductSelectionView = this;
            
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
        }
        
        private void Next_OnClicked(object sender, RoutedEventArgs e)
        {
            CurrentGuiInfo.CurrentProduct = ((RadioButton) sender).Tag as string;
            
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new ConstructionView(Nav, false));
        }

        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }
    }
}