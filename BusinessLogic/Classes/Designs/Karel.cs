using System.Collections.Generic;

namespace BusinessLogic.Classes.Designs

{
    public class Karel : Design
    {
        public override string Name { get; set; } = "Karel";
        public sealed override double NumberOfHorizontalProfileGroups { get; set; } = 2;
        public override double NumberOfVerticalProfileGroups { get; set; } = 1;
        public override double NumberOfGlassPanels { get; set; } = 6;
        public override double NumberOfSteelPlates { get; set; } = 0;
        public override bool CanBeMirrored { get; set; } = true;
        public override bool IsBottomGlassCustom { get; set; } = true;

        public Karel()
        {
            
        }

        public Karel(Data data, ConstructionOpening co, double doorHeight)
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