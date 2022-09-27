using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using GUI.ViewModels;
using GUI.Helpers;
using GUI.Stores;

namespace GUI.Views
{
    public partial class GeneralProductView : UserControl
    {
        private NavigationStore Nav { get; set; }
        public GeneralProductView(NavigationStore navigationStore)
        {
            Nav = navigationStore;
            Nav.GeneralProductView = this;
            InitializeComponent();
            DataContext = Nav.MainWindow.DataContext;
            
            PrepareGUI();
        }
        private void PrepareGUI()
        {
            LeftSlantSettings.Visibility = Visibility.Collapsed;
            RightSlantSettings.Visibility = Visibility.Collapsed;

            if (GuiDisplayValidation.IsLeftSlant)
            {
                LeftSlantCheckbox.Visibility = Visibility.Visible;
                LeftSlantAmount.Text = GuiDisplayValidation.LeftSlantAmount.ToString(CultureInfo.InvariantCulture);

                if (GuiDisplayValidation.IsSlantLeftTop)
                {
                    LeftSlantTop.IsChecked = true;
                    LeftSlantBottom.Visibility = Visibility.Collapsed;
                }
                else
                {
                    LeftSlantBottom.IsChecked = true;
                    LeftSlantTop.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                LeftSlantCheckbox.Visibility = Visibility.Collapsed;
            }
            if (GuiDisplayValidation.IsRightSlant)
            {
                RightSlantCheckbox.Visibility = Visibility.Visible;
                RightSlantAmount.Text = GuiDisplayValidation.RightSlantAmount.ToString(CultureInfo.InvariantCulture);
                
                if (GuiDisplayValidation.IsSlantRightTop)
                {
                    RightSlantTop.IsChecked = true;
                    RightSlantBottom.Visibility = Visibility.Collapsed;
                }
                else
                {
                    RightSlantBottom.IsChecked = true;
                    RightSlantTop.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                RightSlantCheckbox.Visibility = Visibility.Collapsed;
            }
        }
        private void DoubleDoor_OnChecked(object sender, RoutedEventArgs e)
        {
            Turning.Visibility = Visibility.Collapsed;
        }
        private void DoubleDoor_OnUnChecked(object sender, RoutedEventArgs e)
        {
            Turning.Visibility = Visibility.Visible;
        }
        private void LSL_Checked(object sender, RoutedEventArgs e)
        {
            LSLSettings.Visibility = Visibility.Visible;
        }
        private void LSL_UnChecked(object sender, RoutedEventArgs e)
        {
            LSLSettings.Visibility = Visibility.Collapsed;
        }
        private void RSL_Checked(object sender, RoutedEventArgs e)
        {
            RSLSettings.Visibility = Visibility.Visible;
        }
        private void RSL_UnChecked(object sender, RoutedEventArgs e)
        {
            RSLSettings.Visibility = Visibility.Collapsed;
        }
        private void LeftSlantCheckbox_OnChecked(object sender, RoutedEventArgs e)
        {
            LeftSlantSettings.Visibility = Visibility.Visible;
        }
        private void LeftSlantCheckbox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            LeftSlantSettings.Visibility = Visibility.Collapsed;
        }
        private void RightSlantCheckbox_OnChecked(object sender, RoutedEventArgs e)
        {
            RightSlantSettings.Visibility = Visibility.Visible;
        }
        private void RightSlantCheckbox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            RightSlantSettings.Visibility = Visibility.Collapsed;
        }

        private void Back_ConstructionView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.ConstructView);
        }

        private void Back_HomeView(object sender, RoutedEventArgs e)
        {
            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(new HomeView(Nav.MainWindow));
        }

        private void Next_SpecificProductView(object sender, RoutedEventArgs e)
        {
            UserControl specificProductView = Activator.CreateInstance(Type.GetType($"GUI.Views.ProductViews.{CurrentGuiInfo.CurrentProduct}DoorView"), Nav) as UserControl;

            Nav.MainWindow.ContentDisplay.Children.Clear();
            Nav.MainWindow.ContentDisplay.Children.Add(Nav.SpecificProductView ?? specificProductView);
        }
    }
}