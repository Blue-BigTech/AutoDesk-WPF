using System.Collections.Generic;

namespace BusinessLogic.Classes.Designs

{
    public class Johannes : Design
    {
        public override string Name { get; set; } = "Johannes";
        public sealed override double NumberOfHorizontalProfileGroups { get; set; } = 3;
        public override double NumberOfVerticalProfileGroups { get; set; } = 1;
        public override double NumberOfGlassPanels { get; set; } = 8;
        public override double NumberOfSteelPlates { get; set; } = 0;
        public override bool CanBeMirrored { get; set; }
        public override bool IsBottomGlassCustom { get; set; }

        public Johannes()
        {
            
        }

        public Johannes(Data data, ConstructionOpening co, double doorHeight)
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