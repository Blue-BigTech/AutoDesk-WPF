using System.Web.UI.Design.WebControls;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using DoorPROGUI.Helpers;

namespace DoorPROGUI.Views
{
    public partial class PivotDoorSettings
    {
        public PivotDoorSettings()
        {
            PrepareGUIOptions();
        }

        private void PrepareGUIOptions()
        {
            LSLSettings.Visibility = Visibility.Collapsed;
            RSLSettings.Visibility = Visibility.Collapsed;

            LeftSlantSettings.Visibility = Visibility.Collapsed;
            RightSlantSettings.Visibility = Visibility.Collapsed;

            if (DataStorage.isLeftSlant)
            {
                LeftSlantCheckbox.Visibility = Visibility.Collapsed;
            }
            if (DataStorage.isRightSlant)
            {
                RightSlantCheckbox.Visibility = Visibility.Collapsed;
            }
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            // MainWindow.MainContent.Children.Clear();
            // MainWindow.MainContent.Children.Add(Psv);
        }

        private void GoHome(object sender, MouseButtonEventArgs e)
        {
            // MainWindow.MainContent.Children.Clear();
            // MainWindow.MainContent.Children.Add(new WelcomeMessageView());
        }

        private void SinglePivot_OnChecked(object sender, RoutedEventArgs e)
        {
            PivotPointSettings.Visibility = Visibility.Visible;
            TurningSettings.Visibility = Visibility.Visible;
        }

        private void DoublePivot_OnChecked(object sender, RoutedEventArgs e)
        {
            PivotPointSettings.Visibility = Visibility.Collapsed;
            TurningSettings.Visibility = Visibility.Collapsed;
        }

        private void LeftSidelight_OnChecked(object sender, RoutedEventArgs e)
        {
            LSLSettings.Visibility = Visibility.Visible;
        }

        private void RightSidelight_OnChecked(object sender, RoutedEventArgs e)
        {
            RSLSettings.Visibility = Visibility.Visible;
        }

        private void LeftSidelight_OnUnchecked(object sender, RoutedEventArgs e)
        {
            LSLSettings.Visibility = Visibility.Collapsed;
        }

        private void RightSidelight_OnUnchecked(object sender, RoutedEventArgs e)
        {
            RSLSettings.Visibility = Visibility.Collapsed;        
        }

        private void LeftSlant_OnChecked(object sender, RoutedEventArgs e)
        {
            LeftSlantSettings.Visibility = Visibility.Visible;
        }

        private void RightSlant_OnChecked(object sender, RoutedEventArgs e)
        {
            RightSlantSettings.Visibility = Visibility.Visible;
        }

        private void LeftSlant_OnUnchecked(object sender, RoutedEventArgs e)
        {
            LeftSlantSettings.Visibility = Visibility.Collapsed;
        }

        private void RightSlant_OnUnchecked(object sender, RoutedEventArgs e)
        {
            RightSlantSettings.Visibility = Visibility.Collapsed;
        }

        private void DesignSelectionButton_OnClick(object sender, RoutedEventArgs e)
        {
            // MainWindow.MainContent.Children.Clear();
            // MainWindow.MainContent.Children.Add(new DesignView(this));
        }
    }
}