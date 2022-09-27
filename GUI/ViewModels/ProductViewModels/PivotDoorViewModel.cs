using BusinessLogic.Classes;
using BusinessLogic.Classes.Datas;

namespace GUI.ViewModels.ProductViewModels
{
    public class PivotDoorViewModel : ViewModelBase
    {
        // SETTINGS ----------------------------------------------------------------------------------------------------
        private double _doorHorizontalDesignProfile;
        private double _doorVerticalDesignProfile;
        private double _doorStandingProfile;
        private double _doorTopProfile;
        private double _doorBottomProfile;
        private double _defaultGapDoorToWall;
        private double _defaultGapDoorToFloor;
        private double _defaultGapDoorToCeiling;
        private double _defaultGapDoorToDoor;
        private double _defaultGapDoorToSidelight;
        private double _sidelightStandingProfile;
        private double _sidelightTopProfile;
        private double _sidelightBottomProfile;
        private double _defaultGapSidelightToWall;
        private double _defaultGapSidelightToFloor;
        private double _defaultGapSidelightToCeiling;
        private double _elementThickness;
        private double _profileWallThickness;
        private double _pivotPointDistance;
        private double _pivotLineLength;
        
        public double DoorHorizontalDesignProfile
        {
            get => _doorHorizontalDesignProfile;
            set
            {
                _doorHorizontalDesignProfile = value;
                OnPropertyChanged(nameof(DoorHorizontalDesignProfile));
            }
        }
        public double DoorVerticalDesignProfile
        {
            get => _doorVerticalDesignProfile;
            set
            {
                _doorVerticalDesignProfile = value;
                OnPropertyChanged(nameof(DoorVerticalDesignProfile));
            }
        }
        public double DoorStandingProfile
        {
            get => _doorStandingProfile;
            set
            {
                _doorStandingProfile = value;
                OnPropertyChanged(nameof(DoorStandingProfile));
            }
        }
        public double DoorTopProfile
        {
            get => _doorTopProfile;
            set
            {
                _doorTopProfile = value;
                OnPropertyChanged(nameof(DoorTopProfile));
            }
        }
        public double DoorBottomProfile
        {
            get => _doorBottomProfile;
            set
            {
                _doorBottomProfile = value;
                OnPropertyChanged(nameof(DoorBottomProfile));
            }
        }
        public double DefaultGapDoorToWall
        {
            get => _defaultGapDoorToWall;
            set
            {
                _defaultGapDoorToWall = value;
                OnPropertyChanged(nameof(DefaultGapDoorToWall));
            }
        }
        public double DefaultGapDoorToFloor
        {
            get => _defaultGapDoorToFloor;
            set
            {
                _defaultGapDoorToFloor = value;
                OnPropertyChanged(nameof(DefaultGapDoorToFloor));
            }
        }
        public double DefaultGapDoorToCeiling
        {
            get => _defaultGapDoorToCeiling;
            set
            {
                _defaultGapDoorToCeiling = value;
                OnPropertyChanged(nameof(DefaultGapDoorToCeiling));
            }
        }
        public double DefaultGapDoorToDoor
        {
            get => _defaultGapDoorToDoor;
            set
            {
                _defaultGapDoorToDoor = value;
                OnPropertyChanged(nameof(DefaultGapDoorToDoor));
            }
        }
        public double DefaultGapDoorToSidelight
        {
            get => _defaultGapDoorToSidelight;
            set
            {
                _defaultGapDoorToSidelight = value;
                OnPropertyChanged(nameof(DefaultGapDoorToSidelight));
            }
        }
        public double SidelightStandingProfile
        {
            get => _sidelightStandingProfile;
            set
            {
                _sidelightStandingProfile = value;
                OnPropertyChanged(nameof(SidelightStandingProfile));
            }
        }
        public double SidelightTopProfile
        {
            get => _sidelightTopProfile;
            set
            {
                _sidelightTopProfile = value;
                OnPropertyChanged(nameof(SidelightTopProfile));
            }
        }
        public double SidelightBottomProfile
        {
            get => _sidelightBottomProfile;
            set
            {
                _sidelightBottomProfile = value;
                OnPropertyChanged(nameof(SidelightBottomProfile));
            }
        }
        public double DefaultGapSidelightToWall
        {
            get => _defaultGapSidelightToWall;
            set
            {
                _defaultGapSidelightToWall = value;
                OnPropertyChanged(nameof(DefaultGapSidelightToWall));
            }
        }
        public double DefaultGapSidelightToFloor
        {
            get => _defaultGapSidelightToFloor;
            set
            {
                _defaultGapSidelightToFloor = value;
                OnPropertyChanged(nameof(DefaultGapSidelightToFloor));
            }
        }
        public double DefaultGapSidelightToCeiling
        {
            get => _defaultGapSidelightToCeiling;
            set
            {
                _defaultGapSidelightToCeiling = value;
                OnPropertyChanged(nameof(DefaultGapSidelightToCeiling));
            }
        }
        public double ElementThickness
        {
            get => _elementThickness;
            set
            {
                _elementThickness = value;
                OnPropertyChanged(nameof(ElementThickness));
            }
        }
        public double ProfileWallThickness
        {
            get => _profileWallThickness;
            set
            {
                _profileWallThickness = value;
                OnPropertyChanged(nameof(ProfileWallThickness));
            }
        }
        public double PivotPointDistance
        {
            get => _pivotPointDistance;
            set
            {
                _pivotPointDistance = value;
                OnPropertyChanged(nameof(PivotPointDistance));
            }
        }
        public double PivotLineLength
        {
            get => _pivotLineLength;
            set
            {
                _pivotLineLength = value;
                OnPropertyChanged(nameof(PivotLineLength));
            }
        }

        public override Data ParseData()
        {
            PivotData data = new PivotData
            {
                DoorHorizontalDesignProfile = DoorHorizontalDesignProfile,
                DoorVerticalDesignProfile = DoorVerticalDesignProfile,
                DoorStandingProfile = DoorStandingProfile,
                DoorTopProfile = DoorTopProfile,
                DoorBottomProfile = DoorBottomProfile,
                DefaultGapDoorToWall = DefaultGapDoorToWall,
                DefaultGapDoorToFloor = DefaultGapDoorToFloor,
                DefaultGapDoorToCeiling = DefaultGapDoorToCeiling,
                DefaultGapDoorToDoor = DefaultGapDoorToDoor,
                DefaultGapDoorToSidelight = DefaultGapDoorToSidelight,
                SidelightStandingProfile = SidelightStandingProfile,
                SidelightTopProfile = SidelightTopProfile,
                SidelightBottomProfile = SidelightBottomProfile,
                DefaultGapSidelightToWall = DefaultGapSidelightToWall,
                DefaultGapSidelightToFloor = DefaultGapSidelightToFloor,
                DefaultGapSidelightToCeiling = DefaultGapSidelightToCeiling,
                ElementThickness = ElementThickness,
                ProfileWallThickness = ProfileWallThickness,
                PivotPointDistance = PivotPointDistance,
                PivotLineLength = PivotLineLength
            };

            return data;
        }
        
        public PivotDoorViewModel()
        {
            PivotData pivotData = new PivotData();
            
            DoorHorizontalDesignProfile = pivotData.DoorHorizontalDesignProfile;
            DoorVerticalDesignProfile = pivotData.DoorVerticalDesignProfile;
            DoorStandingProfile = pivotData.DoorStandingProfile;
            DoorTopProfile = pivotData.DoorTopProfile;
            DoorBottomProfile = pivotData.DoorBottomProfile;
            DefaultGapDoorToWall = pivotData.DefaultGapDoorToWall;
            DefaultGapDoorToFloor = pivotData.DefaultGapDoorToFloor;
            DefaultGapDoorToCeiling = pivotData.DefaultGapDoorToCeiling;
            DefaultGapDoorToDoor = pivotData.DefaultGapDoorToDoor;
            DefaultGapDoorToSidelight = pivotData.DefaultGapDoorToSidelight;
            SidelightStandingProfile = pivotData.SidelightStandingProfile;
            SidelightTopProfile = pivotData.SidelightTopProfile;
            SidelightBottomProfile = pivotData.SidelightBottomProfile;
            DefaultGapSidelightToWall = pivotData.DefaultGapSidelightToWall;
            DefaultGapSidelightToFloor = pivotData.DefaultGapSidelightToFloor;
            DefaultGapSidelightToCeiling = pivotData.DefaultGapSidelightToCeiling;
            ElementThickness = pivotData.ElementThickness;
            ProfileWallThickness = pivotData.ProfileWallThickness;
            PivotPointDistance = pivotData.PivotPointDistance;
            PivotLineLength = pivotData.PivotLineLength;
        } 
    }
}