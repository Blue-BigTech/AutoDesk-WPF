using System.Collections.Generic;

namespace BusinessLogic.Classes
{
    public abstract class Design
    {
        public abstract string Name { get; set; }
        public abstract double  NumberOfHorizontalProfileGroups { get; set; }
        public abstract double NumberOfVerticalProfileGroups { get; set; }
        public abstract double NumberOfGlassPanels { get; set; }
        public abstract double NumberOfSteelPlates { get; set; }
        public abstract bool CanBeMirrored { get; set; }
        public abstract bool IsBottomGlassCustom { get; set; }


        // V PRODUCTU KJER SE REFLECTIONIRA SE UPORAB CONSTRUCTOR: (Data data, ConstructionOpening co, double doorHeight)
        // Prazen construktor se rabi za reflection v gui da se prebere št vert profilov in če je mirrored


        
        public abstract void CalculateSidelightDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles);
        public abstract void CalculateDoorDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles);
    }

    public class Element
    {
    }
}