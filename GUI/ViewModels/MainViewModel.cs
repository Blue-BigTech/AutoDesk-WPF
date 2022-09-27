using GUI.Commands;
using GUI.Commands.DrawCommands;

namespace GUI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ConstructionViewModel ConstructionViewModel { get; set; }
        public GeneralProductViewModel GeneralProductViewModel { get; set; }
        public DesignViewModel DesignViewModel { get; set; }
        public HandleViewModel HandleViewModel { get; set; }
        public ViewModelBase ProductViewModel { get; set; }
        public DrawProductCommand DrawCommand { get; set; }
        public InstantiateProductCommand InstantiateProduct { get; set; }
        
        public MainViewModel()
        {
            ConstructionViewModel = new ConstructionViewModel();
            GeneralProductViewModel = new GeneralProductViewModel();
            DesignViewModel = new DesignViewModel();
            HandleViewModel = new HandleViewModel();

            DrawCommand = new DrawProductCommand(this);
            InstantiateProduct = new InstantiateProductCommand(this);
        }
    }
}