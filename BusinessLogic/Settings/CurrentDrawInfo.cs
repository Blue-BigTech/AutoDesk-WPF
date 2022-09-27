namespace BusinessLogic.Settings
{
    public static class CurrentDrawInfo
    {
        //DRAW INFORMATION ---------------------------------------------------------------------------------------------
        public static bool DrawLSL { get; set; }
        public static bool DrawLD { get; set; }
        public static bool DrawRD { get; set; }
        public static bool DrawRSL { get; set; }
        
        public static bool IsSingle { get; set; }
        public static bool IsTurningLeft { get; set; } = true;

        public static double LSLWidth { get; set; }
        public static double RSLWidth { get; set; }

        public static string ProductType { get; set; }
        
        //CUTLIST
        public static bool MakeCutlist { get; set; } = true;
        
        public static string ProjectNumber { get; set; }
        public static string ProjectName { get; set; }
        public static string DoorLetter { get; set; }

        public static string CutlistPathName { get; set; } = "";
        public static string CutlistFileName { get; set; } = "";

        //HINGE
        public static bool IsClosingStripOnlyTop { get; set; } = true; //true == top, false == around


        //CURRENT CONSTRUCTION OPENING----------------------------------------------------------------------------------
        public static double MoveX { get; set; }
        public static double MoveY { get; set; }
        
        public static double ConstructionWidthBottom { get; set; }
        public static double ConstructionWidthTop { get; set; }
        public static double ConstructionHeightLeft { get; set; }
        public static double ConstructionHeightRight { get; set; }
        
        public static double CorrectedConstructionWidth { get; set; }
        public static double CorrectedConstructionHeight { get; set; }

        //Point Slides
        public static double DownLeftX { get; set; }
        public static double DownLeftY { get; set; }
        public static double DownRightX { get; set; }
        public static double DownRightY { get; set; }
        public static double UpRightX { get; set; }
        public static double UpRightY { get; set; }
        public static double UpLeftX { get; set; }
        public static double UpLeftY { get; set; }
        
        public static double MiddleDownY { get; set; }
        public static double MiddleRightX { get; set; }
        public static double MiddleUpY { get; set; }
        public static double MiddleLeftX { get; set; }

        
        //------------------------------------------------------------------------------------------------------------//

        //SLANTED DOORS-------------------------------------------------------------------------------------------------
        public static double LeftBottomSlant { get; set; }
        public static double LeftTopSlant { get; set; }
        public static double RightTopSlant { get; set; }
        public static double RightBottomSlant { get; set; }


        //DESIGN--------------------------------------------------------------------------------------------------------

        public static string DesignName { get; set; } = "George";
        public static bool IsMirrored { get; set; }


        public static double DesignParameterX { get; set; }
        public static double DesignParameterY { get; set; }
        
        
        //HANDLE--------------------------------------------------------------------------------------------------------
        
        public static string HandleName { get; set; } = "Ror_DS";
        public static double LengthOfHandle { get; set; } = 300;

        
        // Custom mode
        public static bool IsCustomMode { get; set; } = true;
        public static double HeightToHandle { get; set; } = 600;

        public static bool IsFromFloor { get; set; } = true;
        public static bool IsFromBottomOfProfile { get; set; }
        public static int IndexOfProfile { get; set; }
        
        public static bool IsToBottom { get; set; }
        public static bool IsToCenter { get; set; }
        public static bool IsToTop { get; set; }
        
        // Automatic mode
        public static bool IsCenterBetweenProfiles { get; set; }
        public static int BottomProfileIndex { get; set; } = 1;
        public static int TopProfileIndex { get; set; } = 1;

        
        // Info for x
        public static bool IsOnVerticalDesignProfile { get; set; }
        public static double CenterHandleToEdgeOfDoorX { get; set; } = 75;


        public static void ResetCurrentDrawInfo()
        {
            //DRAW INFORMATION ---------------------------------------------------------------------------------------------
            DrawLSL = false;
            DrawLD = false;
            DrawRD = false;
            DrawRSL = false;

            IsSingle = false;
            IsTurningLeft = false;

            LSLWidth = 0;
            RSLWidth = 0;

            ProductType = "Empty";

            //CUTLIST
            MakeCutlist = false;

            ProjectNumber = "Empty";
            ProjectName = "Empty";
            DoorLetter = "Empty";

            CutlistPathName = "Empty";
            CutlistFileName = "Empty";

            //HINGE
            IsClosingStripOnlyTop = false;


            //CURRENT CONSTRUCTION OPENING----------------------------------------------------------------------------------
            MoveX = 0;
            MoveY = 0;

            ConstructionWidthBottom = 0;
            ConstructionWidthTop = 0;
            ConstructionHeightLeft = 0;
            ConstructionHeightRight = 0;

            CorrectedConstructionWidth = 0;
            CorrectedConstructionHeight = 0;

            //Point Slides
            DownLeftX = 0;
            DownLeftY = 0;
            DownRightX = 0;
            DownRightY = 0;
            UpRightX = 0;
            UpRightY = 0;
            UpLeftX = 0;
            UpLeftY = 0;

            MiddleDownY = 0;
            MiddleRightX = 0;
            MiddleUpY = 0;
            MiddleLeftX = 0;

            //SLANTED DOORS-------------------------------------------------------------------------------------------------
            LeftBottomSlant = 0;
            LeftTopSlant = 0;
            RightTopSlant = 0;
            RightBottomSlant = 0;

            //DESIGN--------------------------------------------------------------------------------------------------------
            DesignName = "Empty";
            IsMirrored = false;

            DesignParameterX = 0;
            DesignParameterY = 0;

            //HANDLE--------------------------------------------------------------------------------------------------------
            HandleName = "Empty";
            LengthOfHandle = 0;

            // Custom mode
            IsCustomMode = false;
            HeightToHandle = 0;

            IsFromFloor = false;
            IsFromBottomOfProfile = false;
            IndexOfProfile = 0;

            IsToBottom = false;
            IsToCenter = false;
            IsToTop = false;

            // Automatic mode
            IsCenterBetweenProfiles = false;
            BottomProfileIndex = 0;
            TopProfileIndex = 0;

            // Info for x
            IsOnVerticalDesignProfile = false;
            CenterHandleToEdgeOfDoorX = 0;
        }
    }
}