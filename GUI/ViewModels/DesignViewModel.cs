using System.Collections.Generic;
using GUI.Helpers;

namespace GUI.ViewModels
{
    public class DesignViewModel : ViewModelBase
    {
        private string _selectedDesign;
        public List<string> Designs { get; }
        public string SelectedDesign
        {
            get => _selectedDesign;
            set
            {
                _selectedDesign = value;
                OnPropertyChanged(nameof(SelectedDesign));
            }
        }
        
        public DesignViewModel()
        {
            Designs = GeneralHelp.ReturnListOfClassNames(typeof(BusinessLogic.Classes.Design));
            SelectedDesign = Designs[0];
        }
    }
}