using System;
using System.Windows.Forms;
using GUI.Helpers;
using GUI.ViewModels;

namespace GUI.Commands
{
    public class InstantiateProductCommand : CommandBase
    {
        private MainViewModel Mvm { get; set; }
        
        public InstantiateProductCommand(MainViewModel mvm)
        {
            Mvm = mvm;
        }

        public override void Execute(object parameter)
        {
            try
            {
                Mvm.ProductViewModel = Activator.CreateInstance(Type.GetType($"GUI.ViewModels.ProductViewModels.{CurrentGuiInfo.CurrentProduct}DoorViewModel")) as ViewModelBase;
            }            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}