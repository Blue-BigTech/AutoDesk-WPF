using System.Collections.Generic;
using BusinessLogic.Settings;

namespace BusinessLogic.Classes.Designs

{
    public class Piet : Design
    {
        public override string Name { get; set; } = "Piet";
        public sealed override double NumberOfHorizontalProfileGroups { get; set; } = 2;
        public override double NumberOfVerticalProfileGroups { get; set; } = 1;
        public override double NumberOfGlassPanels { get; set; } = 5;
        public override double NumberOfSteelPlates { get; set; } = 1;
        public override bool CanBeMirrored { get; set; } = true;
        public override bool IsBottomGlassCustom { get; set; } = true;

        public Piet()
        {
            
        }

        public Piet(Data data, ConstructionOpening co, double doorHeight)
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