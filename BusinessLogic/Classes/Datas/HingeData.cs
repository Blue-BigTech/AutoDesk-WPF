
namespace BusinessLogic.Classes.Datas
{
    public class HingeData : Data
    {
        //COMMON SETTINGS ----------------------------------------------------------------------------------------------

        // DOOR DATA----------------------------------------------------------------------------------------------------

        //Door Profiles
        public override double DoorStandingProfile { get; set; } = 30;
        public override double DoorTopProfile { get; set; } = 30;
        public override double DoorBottomProfile { get; set; } = 30;
        
        //Door Design Profiles
        public override double DoorHorizontalDesignProfile { get; set; } = 30;
        public override double DoorVerticalDesignProfile { get; set; } = 30;
        
        //Default Door Gaps
        public override double DefaultGapDoorToWall { get; set; } = 0; //in the interface, but Not for hinge
        public override double DefaultGapDoorToFloor { get; set; } = 10;
        public override double DefaultGapDoorToCeiling { get; set; } = 0; //in the interface, Not for hinge
        public override double DefaultGapDoorToDoor { get; set; } = 4;
        public override double DefaultGapDoorToSidelight { get; set; } = 4;
        
        //Door Top View
        public override double ElementThickness { get; set; } = 30;
        public override double ProfileWallThickness { get; set; } = 2;

        
        // SIDELIGHT DATA-----------------------------------------------------------------------------------------------
        
        //Sidelight Profiles
        public override double SidelightStandingProfile { get; set; } = 30;
        public override double SidelightTopProfile { get; set; } = 30;
        public override double SidelightBottomProfile { get; set; } = 30;
        
        //Default Sidelight Gaps
        public override double DefaultGapSidelightToWall { get; set; } = 1;
        public override double DefaultGapSidelightToFloor { get; set; }
        public override double DefaultGapSidelightToCeiling { get; set; } = 2;
        

        //SPECIFIC SETTINGS --------------------------------------------------------------------------------------------

        public bool IsClosingStripOnlyTop { get; set; } = true; //true == top, false == around

        public double HingeHeight { get; set; } = 310;
        public double TopStripWidth { get; set; } = 50;
        public double TopViewStripThickness { get; set; } = 6;
        public double StandingStripWidth { get; set; } = 40;
        public double MagnetRadius { get; set; } = 8;
        public double HingeRadius { get; set; } = 8;
        public double MagnetEdgeOffset { get; set; } = 10;
        public double ProfileRadius { get; set; } = 3;
        
        public double ProductionFrameProfileMargin { get; set; } = 250;
        public double ProductionStripDetailsMargin { get; set; } = 150;
        public double DimInitialOffsetFrame { get; set; } = 60;
        
        
        //Frame Profiles
        public double FrameLeftStandingProfile { get; set; } = 30;
        public double FrameRightStandingProfile { get; set; } = 30;
        public double FrameTopProfile { get; set; } = 30;


        //Default Frame Gaps
        public double DefaultGapFrameToWall { get; set; } = 1;
        public double DefaultGapFrameToCeiling { get; set; } = 2;
        public double DefaultGapFrameToFloor { get; set; } = 0;
        public double DefaultGapDoorToFrame { get; set; } = 4;
    }
}