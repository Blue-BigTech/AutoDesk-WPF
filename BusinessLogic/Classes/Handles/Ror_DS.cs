using BusinessLogic.Settings;

namespace BusinessLogic.Classes.Handles
{
    public class Ror_DS : Handle
    {
        public string Name { get; set; } = "Ror_DS";
        public int NumberOfAdapters { get; set; } = 2;
        public bool HasRoundHandle { get; set; } = true;
        public bool NeedsHandlePlate { get; set; } = true;
        public bool IsAdapterFulGripHeight { get; set; }
        public double WallThickness { get; set; } = GlobalSettings.DafaultHandleWallThickness;
        public double GripWidth { get; set; } = 21;
        public double GripThickness { get; set; } = 21;
        public double GripExtension { get; set; } = 30;
        public double HandleOffsetFromAdapter { get; set; }
        public double AdapterWidth { get; set; } = 21;
        public double AdapterHeight { get; set; } = 21;
        public double AdapterThickness { get; set; } = 40;
        
        public Ror_DS()
        {
            
        }
        
        public Ror_DS(Element element, Data data, ConstructionOpening co) { }
        
        public HandleTopView CalculateTopView(Element element)
        {
            HandleTopView handleTopView = new HandleTopView { };

            return handleTopView;
        }
    }
}