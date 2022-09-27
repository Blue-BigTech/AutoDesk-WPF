using System.Collections.Generic;
using GUI.Helpers;

namespace GUI.ViewModels
{
    public class HandleViewModel : ViewModelBase
    {
        private string _selectedHandle;
        private string _selectedPositionMethod;

        private double _gripWidth;
        private double _gripThickness;
        private double _gripExtension;
        private double _handleOffsetFromAdapter;
        private double _adapterWidth;
        private double _adapterThickness;
        private double _adapterHeight;
        private double _handleWallThickness;
        private bool _isBetweenProfiles;
        private bool _isBetweenProfilesCentered;
        private bool _isFromProfile;
        private bool _isFromFloor;

        public double GripWidth
        {
            get => _gripWidth;
            set
            {
                _gripWidth = value;
                OnPropertyChanged(nameof(GripWidth));
            }
        }
        public double GripThickness
        {
            get => _gripThickness;
            set
            {
                _gripThickness = value;
                OnPropertyChanged(nameof(GripThickness));
            }
        }
        public double GripExtension
        {
            get => _gripExtension;
            set
            {
                _gripExtension = value;
                OnPropertyChanged(nameof(GripExtension));
            }
        }
        public double HandleOffsetFromAdapter
        {
            get => _handleOffsetFromAdapter;
            set
            {
                _handleOffsetFromAdapter = value;
                OnPropertyChanged(nameof(HandleOffsetFromAdapter));
            }
        }
        public double AdapterWidth
        {
            get => _adapterWidth;
            set
            {
                _adapterWidth = value;
                OnPropertyChanged(nameof(AdapterWidth));
            }
        }
        public double AdapterThickness
        {
            get => _adapterThickness;
            set
            {
                _adapterThickness = value;
                OnPropertyChanged(nameof(AdapterThickness));
            }
        }
        public double AdapterHeight
        {
            get => _adapterHeight;
            set
            {
                _adapterHeight = value;
                OnPropertyChanged(nameof(AdapterHeight));
            }
        }
        public double HandleWallThickness
        {
            get => _handleWallThickness;
            set
            {
                _handleWallThickness = value;
                OnPropertyChanged(nameof(HandleWallThickness));
            }
        }
        public bool IsBetweenProfiles
        {
            get => _isBetweenProfiles;
            set
            {
                _isBetweenProfiles = value;
                OnPropertyChanged(nameof(IsBetweenProfiles));
            }
        }
        public bool IsBetweenProfilesCentered
        {
            get => _isBetweenProfilesCentered;
            set
            {
                _isBetweenProfilesCentered = value;
                OnPropertyChanged(nameof(IsBetweenProfilesCentered));
            }
        }
        public bool IsFromFloor
        {
            get => _isFromFloor;
            set
            {
                _isFromFloor = value;
                OnPropertyChanged(nameof(IsFromFloor));
            }
        }

        public bool IsFromProfile
        {
            get => _isFromProfile;
            set
            {
                _isFromProfile = value;
                OnPropertyChanged(nameof(IsFromProfile));
            }
        }

        public List<string> Handles { get; }
        public string SelectedHandle
        {
            get => _selectedHandle;
            set
            {
                _selectedHandle = value;
                OnPropertyChanged(nameof(SelectedHandle));
            }
        }

        public List<string> PositionMethods { get; }
        public string SelectedPositionMethod
        {
            get => _selectedPositionMethod;
            set
            {
                _selectedPositionMethod = value;
                OnPropertyChanged(nameof(SelectedPositionMethod));
            }
        }

        public HandleViewModel()
        {
            Handles = GeneralHelp.ReturnListOfClassNames(typeof(BusinessLogic.Classes.Handles.Handle));
            SelectedHandle = Handles[0];

            PositionMethods = new List<string> { "Between Profiles", "Between Profiles Centered", "From Profile", "From Floor" };
            SelectedPositionMethod = PositionMethods[0];
        }
    }
}