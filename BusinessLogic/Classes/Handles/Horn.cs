using System.Collections.Generic;
using BusinessLogic.Settings;

namespace BusinessLogic.Classes.Handles
{
    public class Horn : Handle
    {
        public string Name { get; set; } = "Horn";
        public int NumberOfAdapters { get; set; } = 1;
        public bool HasRoundHandle { get; set; }
        public bool NeedsHandlePlate { get; set; }
        public bool IsAdapterFulGripHeight { get; set; } = true;
        public double WallThickness { get; set; } = 3;
        public double GripWidth { get; set; } = 30;
        public double GripThickness { get; set; } = 3;
        public double GripExtension { get; set; }
        public double HandleOffsetFromAdapter { get; set; }

        public double AdapterWidth { get; set; } = 3;
        public double AdapterHeight { get => 9999; set { } }

        public double AdapterThickness { get; set; } = 27;

        public Horn()
        {
            
        }
        
        public Horn(Element element, Data data, ConstructionOpening co)
        {
            
        }
        
        public HandleTopView CalculateTopView(Element element)
        {
            HandleTopView handleTopView = new HandleTopView { };

            return handleTopView;
        }
    }
}