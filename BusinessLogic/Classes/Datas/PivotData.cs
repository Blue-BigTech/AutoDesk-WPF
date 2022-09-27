namespace BusinessLogic.Classes.Datas
{
    public class PivotData : Data
    {
        //COMMON SETTINGS ----------------------------------------------------------------------------------------------
        
        // DOOR DATA----------------------------------------------------------------------------------------------------

        //Door Profiles
        public override double DoorStandingProfile { get; set; } = 30;
        public override double DoorTopProfile { get; set; } = 30;
        public override double DoorBottomProfile { get; set; } = 60;
        
        //Door Design Profiles
        public override double DoorHorizontalDesignProfile { get; set; } = 30;
        public override double DoorVerticalDesignProfile { get; set; } = 30;
               
        //Default Door Gaps
        public override double DefaultGapDoorToWall { get; set; } = 5;
        public override double DefaultGapDoorToFloor { get; set; } = 13;
        public override double DefaultGapDoorToCeiling { get; set; } = 8;
        public override double DefaultGapDoorToDoor { get; set; } = 5;
        public override double DefaultGapDoorToSidelight { get; set; } = 5;

        //Door Top View
        public override double ElementThickness { get; set; } = 40;
        public override double ProfileWallThickness { get; set; } = 2;

        
        // SIDELIGHT DATA-----------------------------------------------------------------------------------------------
       
        //Sidelight Profiles
        public override double SidelightStandingProfile { get; set; } = 30;
        public override double SidelightTopProfile { get; set; } = 40;
        public override double SidelightBottomProfile { get; set; } = 70;

        //Default Sidelight Gaps
        public override double DefaultGapSidelightToWall { get; set; }
        public override double DefaultGapSidelightToFloor { get; set; }
        public override double DefaultGapSidelightToCeiling { get; set; } = 2;



        //SPECIFIC SETTINGS --------------------------------------------------------------------------------------------

        //Pivot Point
        public double PivotPointDistance { get; set; } = 60;
        public double PivotLineLength { get; set; } = 40;
    }
}