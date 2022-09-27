using System.Windows;
using BusinessLogic.Classes;
using BusinessLogic.Classes.Datas;
using BusinessLogic.Settings;
using GUI.ViewModels;

namespace GUI.Commands.DrawCommands
{
    public class DrawProductCommand : CommandBase
    {
        private MainViewModel Mvm { get; set; }
        
        public DrawProductCommand(MainViewModel mvm)
        {
            Mvm = mvm;
        }
        public override void Execute(object parameter)
        {
            // AutoCAD.CreateLoading();
            
            CurrentDrawInfo.ResetCurrentDrawInfo();
            
            Data data = Mvm.ProductViewModel.ParseData();
            HingeData hingeData = (HingeData) data;

            System.Windows.Forms.MessageBox.Show("Is Closing strip: " + hingeData.IsClosingStripOnlyTop.ToString());
            
            // Get the factory method and draw the product
            MessageBox.Show("Product is drawn.");
            // AutoCAD.CloseLoading();
        }
    }
}