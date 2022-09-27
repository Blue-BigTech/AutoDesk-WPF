using BusinessLogic.Classes;
using BusinessLogic.Classes.Datas;

namespace GUI.ViewModels.ProductViewModels
{
    public class HingeDoorViewModel : ViewModelBase
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

        private bool _isClosingStripOnlyTop;

        private double _hingeHeight;
        private double _topStripWidth;
        private double _topViewStripThickness;
        private double _standingStripWidth;
        private double _magnetRadius;
        private double _hingeRadius;
        private double _magnetEdgeOffset;
        private double _profileRadius;
        
        private double _productionFrameProfileMargin;
        private double _productionStripDetailsMargin;
        private double _dimInitialOffsetFrame;
        
        
        //Frame Profiles
        private double _frameLeftStandingProfile;
        private double _frameRightStandingProfile;
        private double _frameTopProfile;


        //Default Frame Gaps
        private double _defaultGapFrameToWall;
        private double _defaultGapFrameToCeiling;
        private double _defaultGapFrameToFloor;
        private double _defaultGapDoorToFrame;


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
        public bool IsClosingStripOnlyTop
        {
            get => _isClosingStripOnlyTop;
            set
            {
                _isClosingStripOnlyTop = value;
                OnPropertyChanged(nameof(IsClosingStripOnlyTop));
            }
        }
        public double HingeHeight
        {
            get => _hingeHeight;
            set
            {
                _hingeHeight = value;
                OnPropertyChanged(nameof(HingeHeight));
            }
        }
        public double TopStripWidth
        {
            get => _topStripWidth;
            set
            {
                _topStripWidth = value;
                OnPropertyChanged(nameof(TopStripWidth));
            }
        }
        public double TopViewStripThickness
        {
            get => _topViewStripThickness;
            set
            {
                _topViewStripThickness = value;
                OnPropertyChanged(nameof(TopViewStripThickness));
            }
        }
        public double StandingStripWidth
        {
            get => _standingStripWidth;
            set
            {
                _standingStripWidth = value;
                OnPropertyChanged(nameof(StandingStripWidth));
            }
        }
        public double MagnetRadius
        {
            get => _magnetRadius;
            set
            {
                _magnetRadius = value;
                OnPropertyChanged(nameof(MagnetRadius));
            }
        }
        public double HingeRadius
        {
            get => _hingeRadius;
            set
            {
                _hingeRadius = value;
                OnPropertyChanged(nameof(HingeRadius));
            }
        }
        public double MagnetEdgeOffset
        {
            get => _magnetEdgeOffset;
            set
            {
                _magnetEdgeOffset = value;
                OnPropertyChanged(nameof(MagnetEdgeOffset));
            }
        }
        public double ProfileRadius
        {
            get => _profileRadius;
            set
            {
                _profileRadius = value;
                OnPropertyChanged(nameof(ProfileRadius));
            }
        }
        public double ProductionFrameProfileMargin
        {
            get => _productionFrameProfileMargin;
            set
            {
                _productionFrameProfileMargin = value;
                OnPropertyChanged(nameof(ProductionFrameProfileMargin));
            }
        }
        public double ProductionStripDetailsMargin
        {
            get => _productionStripDetailsMargin;
            set
            {
                _productionStripDetailsMargin = value;
                OnPropertyChanged(nameof(ProductionStripDetailsMargin));
            }
        }
        public double DimInitialOffsetFrame
        {
            get => _dimInitialOffsetFrame;
            set
            {
                _dimInitialOffsetFrame = value;
                OnPropertyChanged(nameof(DimInitialOffsetFrame));
            }
        }
        public double FrameLeftStandingProfile
        {
            get => _frameLeftStandingProfile;
            set
            {
                _frameLeftStandingProfile = value;
                OnPropertyChanged(nameof(FrameLeftStandingProfile));
            }
        }
        public double FrameRightStandingProfile
        {
            get => _frameRightStandingProfile;
            set
            {
                _frameRightStandingProfile = value;
                OnPropertyChanged(nameof(FrameRightStandingProfile));
            }
        }
        public double FrameTopProfile
        {
            get => _frameTopProfile;
            set
            {
                _frameTopProfile = value;
                OnPropertyChanged(nameof(FrameTopProfile));
            }
        }
        public double DefaultGapFrameToWall
        {
            get => _defaultGapFrameToWall;
            set
            {
                _defaultGapFrameToWall = value;
                OnPropertyChanged(nameof(DefaultGapFrameToWall));
            }
        }
        public double DefaultGapFrameToCeiling
        {
            get => _defaultGapFrameToCeiling;
            set
            {
                _defaultGapFrameToCeiling = value;
                OnPropertyChanged(nameof(DefaultGapFrameToCeiling));
            }
        }
        public double DefaultGapFrameToFloor
        {
            get => _defaultGapFrameToFloor;
            set
            {
                _defaultGapFrameToFloor = value;
                OnPropertyChanged(nameof(DefaultGapFrameToFloor));
            }
        }
        public double DefaultGapDoorToFrame
        {
            get => _defaultGapDoorToFrame;
            set
            {
                _defaultGapDoorToFrame = value;
                OnPropertyChanged(nameof(DefaultGapDoorToFrame));
            }
        }


        public override Data ParseData()
        {
            HingeData data = new HingeData
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
                IsClosingStripOnlyTop = IsClosingStripOnlyTop,
                HingeHeight = HingeHeight,
                TopStripWidth = TopStripWidth,
                TopViewStripThickness = TopViewStripThickness,
                StandingStripWidth = StandingStripWidth,
                MagnetRadius = MagnetRadius,
                HingeRadius = HingeRadius,
                MagnetEdgeOffset = MagnetEdgeOffset,
                ProfileRadius = ProfileRadius,
                ProductionFrameProfileMargin = ProductionFrameProfileMargin,
                ProductionStripDetailsMargin = ProductionStripDetailsMargin,
                DimInitialOffsetFrame = DimInitialOffsetFrame,
                FrameLeftStandingProfile = FrameLeftStandingProfile,
                FrameRightStandingProfile = FrameRightStandingProfile,
                FrameTopProfile = FrameTopProfile,
                DefaultGapFrameToWall = DefaultGapFrameToWall,
                DefaultGapFrameToCeiling = DefaultGapFrameToCeiling,
                DefaultGapFrameToFloor = DefaultGapFrameToFloor,
                DefaultGapDoorToFrame = DefaultGapDoorToFrame
            };
            
            return data;
        }

        public HingeDoorViewModel()
        {
            HingeData hingeData = new HingeData();
            
            DoorHorizontalDesignProfile = hingeData.DoorHorizontalDesignProfile;
            DoorVerticalDesignProfile = hingeData.DoorVerticalDesignProfile;
            DoorStandingProfile = hingeData.DoorStandingProfile;
            DoorTopProfile = hingeData.DoorTopProfile;
            DoorBottomProfile = hingeData.DoorBottomProfile;
            DefaultGapDoorToWall = hingeData.DefaultGapDoorToWall;
            DefaultGapDoorToFloor = hingeData.DefaultGapDoorToFloor;
            DefaultGapDoorToCeiling = hingeData.DefaultGapDoorToCeiling;
            DefaultGapDoorToDoor = hingeData.DefaultGapDoorToDoor;
            DefaultGapDoorToSidelight = hingeData.DefaultGapDoorToSidelight;
            SidelightStandingProfile = hingeData.SidelightStandingProfile;
            SidelightTopProfile = hingeData.SidelightTopProfile;
            SidelightBottomProfile = hingeData.SidelightBottomProfile;
            DefaultGapSidelightToWall = hingeData.DefaultGapSidelightToWall;
            DefaultGapSidelightToFloor = hingeData.DefaultGapSidelightToFloor;
            DefaultGapSidelightToCeiling = hingeData.DefaultGapSidelightToCeiling;
            ElementThickness = hingeData.ElementThickness;
            ProfileWallThickness = hingeData.ProfileWallThickness;
            IsClosingStripOnlyTop = hingeData.IsClosingStripOnlyTop;
            HingeHeight = hingeData.HingeHeight;
            TopStripWidth = hingeData.TopStripWidth;
            TopViewStripThickness = hingeData.TopViewStripThickness;
            StandingStripWidth = hingeData.StandingStripWidth;
            MagnetRadius = hingeData.MagnetRadius;
            HingeRadius = hingeData.HingeRadius;
            MagnetEdgeOffset = hingeData.MagnetEdgeOffset;
            ProfileRadius = hingeData.ProfileRadius;
            ProductionFrameProfileMargin = hingeData.ProductionFrameProfileMargin;
            ProductionStripDetailsMargin = hingeData.ProductionStripDetailsMargin;
            DimInitialOffsetFrame = hingeData.DimInitialOffsetFrame;
            FrameLeftStandingProfile = hingeData.FrameLeftStandingProfile;
            FrameRightStandingProfile = hingeData.FrameRightStandingProfile;
            FrameTopProfile = hingeData.FrameTopProfile;
            DefaultGapFrameToWall = hingeData.DefaultGapFrameToWall;
            DefaultGapFrameToCeiling = hingeData.DefaultGapFrameToCeiling;
            DefaultGapFrameToFloor = hingeData.DefaultGapFrameToFloor;
            DefaultGapDoorToFrame = hingeData.DefaultGapDoorToFrame;        
        }
    }
}