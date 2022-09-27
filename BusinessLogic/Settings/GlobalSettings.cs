namespace BusinessLogic.Settings
{
    public static class GlobalSettings
    {
        // GUI AND MAIN SETTINGS----------------------------------------------------------------------------------------
        public static string Language { get; set; } = "Dutch";
        
        
        //HANDLES SETTINGS----------------------------------------------------------------------------------------------
        public static double ThicknessOfHandlePlate { get; set; } = 2;
        public static double DafaultHandleWallThickness { get; set; } = 2;


        //CONSTRUCTION OPENING SETTINGS---------------------------------------------------------------------------------
        public static double TopViewWallThickness { get; set; } = 100;
        public static double TopViewWallLength { get; set; } = 250;

        public static double ConstructionDimOffset { get; set; } = 250;
        public static double HelpDimOffset { get; set; } = 450;


        //TOP VIEW GENERAL SETTINGS-------------------------------------------------------------------------------------

        public static double DefaultTopViewOffset { get; set; } = 1000;
        public static double TopViewDimensionChainOffset { get; set; } = 275;
        public static double TopViewDimensionWallToWallOffset { get; set; } = 375;


        //PRODUCTION DRAWING SETTINGS ----------------------------------------------------------------------------------

        //Production Drawing Positions
        public static double ProductionFrontViewOffset { get; set; } = -10000;
        public static double ProductionTopViewOffset { get; set; } = 500;
        public static double ProductionMarginRight { get; set; } = 600;
        public static double ProductionProfileMargin { get; set; } = 0;

        
        //Dimension Levels
        public static double DimOffset { get; set; } = 60;
        public static double DimInitialOffset { get; set; } = 60;

        //Installation Hole Positions
        public static double MinWidthForWideInstallationHoles { get; set; } = 300;
        public static double InstallationHoleVertical { get; set; } = 400;
        public static double InstallationHoleWide { get; set; } = 100;
        public static double InstallationHoleNarrow { get; set; } = 70;
        public static double InstallationHoleExtension { get; set; } = 20;
        
    }
}