
namespace BusinessLogic.Classes
{
    public abstract class Data
    {
        // DOOR DATA----------------------------------------------------------------------------------------------------
        
        //Door Design Profiles
        public abstract double DoorHorizontalDesignProfile { get; set; }
        public abstract double DoorVerticalDesignProfile { get; set; }
        
        //Door Profiles
        public abstract double DoorStandingProfile { get; set; }
        public abstract double DoorTopProfile { get; set; }
        public abstract double DoorBottomProfile { get; set; }

        //Default Door Gaps
        public abstract double DefaultGapDoorToWall { get; set; }
        public abstract double DefaultGapDoorToFloor { get; set; }
        public abstract double DefaultGapDoorToCeiling { get; set; }
        public abstract double DefaultGapDoorToDoor { get; set; }
        public abstract double DefaultGapDoorToSidelight { get; set; }

        //Door Slant Info
        public double LeftDoorLeftBottomSlant { get; set; }
        public double LeftDoorLeftTopSlant { get; set; }
        public double LeftDoorRightBottomSlant { get; set; }
        public double LeftDoorRightTopSlant { get; set; }
        public double RightDoorLeftBottomSlant { get; set; }
        public double RightDoorLeftTopSlant { get; set; }
        public double RightDoorRightBottomSlant { get; set; }
        public double RightDoorRightTopSlant { get; set; }

        // SIDELIGHT DATA-----------------------------------------------------------------------------------------------
       
        //Sidelight Profiles
        public abstract double SidelightStandingProfile { get; set; }
        public abstract double SidelightTopProfile { get; set; }
        public abstract double SidelightBottomProfile { get; set; }

        //Default Sidelight Gaps
        public abstract double DefaultGapSidelightToWall { get; set; }
        public abstract double DefaultGapSidelightToFloor { get; set; }
        public abstract double DefaultGapSidelightToCeiling { get; set; }
        
        
        //PRODUCT TOP VIEW INFO
        public abstract double ElementThickness { get; set; }
        public abstract double ProfileWallThickness { get; set; }
        
        // HANDLES DATA-----------------------------------------------------------------------------------------------
        public Point  HandleTopPoint { get; set; }
        public Point HandleCenterPoint { get; set; }
        public Point  HandleBottomPoint { get; set; }

        public double HandleWidth { get; set; } = 30;
        public double HandleHeight { get; set; } = 300;
        public double HandleThickness { get; set; } = 30;
        public double HandleExtension { get; set; } = 0;
        public double HandleOffsetFromAdapter { get; set; } = 40;
        
        public double HandleAdapterWidth { get; set; } = 30;
        public double HandleAdapterHeight { get; set; } = 30;
        public double HandleAdapterThickness { get; set; } = 30;

    }
}