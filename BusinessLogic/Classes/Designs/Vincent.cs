using System.Collections.Generic;

namespace BusinessLogic.Classes.Designs

{
    public class Vincent : Design
    {
        public override string Name { get; set; } = "Vincent";
        public sealed override double NumberOfHorizontalProfileGroups { get; set; } = 1;
        public override double NumberOfVerticalProfileGroups { get; set; } = 1;
        public override double NumberOfGlassPanels { get; set; } = 2;
        public override double NumberOfSteelPlates { get; set; } = 1;
        public override bool CanBeMirrored { get; set; }
        public override bool IsBottomGlassCustom { get; set; } = true;

        public Vincent()
        {
            
        }

        public Vincent(Data data, ConstructionOpening co, double doorHeight)
        {
        }


        public override void CalculateSidelightDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles)
        {
        }

        public override void CalculateDoorDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles)
        {
        }
    }
}