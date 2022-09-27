using BusinessLogic.Settings;

namespace BusinessLogic.Classes.Handles
{
    public class Hondla : Handle
    {
        public string Name { get; set; } = "Hondla";
        public int NumberOfAdapters { get; set; } = 2;
        public bool HasRoundHandle { get; set; }
        public bool NeedsHandlePlate { get; set; }
        public bool IsAdapterFulGripHeight { get; set; }
        public double WallThickness { get; set; } = GlobalSettings.DafaultHandleWallThickness;
        public double GripWidth { get; set; } = 20;
        public double GripThickness { get; set; } = 20;
        public double GripExtension { get; set; }
        public double HandleOffsetFromAdapter { get; set; } = 40;
        public double AdapterWidth { get; set; } = 20;
        public double AdapterHeight { get; set; } = 20;
        public double AdapterThickness { get; set; } = 20;
        
        public Hondla() 
        {
            
        }
        
        public Hondla(Element element, Data data, ConstructionOpening co)
        {
            
        }
        
        public HandleTopView CalculateTopView(Element element)
        {
            HandleTopView handleTopView = new HandleTopView();

            return handleTopView;
        }
    }
}