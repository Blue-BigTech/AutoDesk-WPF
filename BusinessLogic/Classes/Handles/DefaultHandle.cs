namespace BusinessLogic.Classes.Handles
{
    public class DefaultHandle : Handle
    {
        public string Name { get; set; } = "Default Handle";
        public int NumberOfAdapters { get; set; }
        public bool HasRoundHandle { get; set; }
        public bool NeedsHandlePlate { get; set; }
        public bool IsAdapterFulGripHeight { get; set; }
        public double WallThickness { get; set; }
        public double GripWidth { get; set; }
        public double GripThickness { get; set; }
        public double GripExtension { get; set; }
        
        public double HandleOffsetFromAdapter { get; set; }
        public double AdapterWidth { get; set; }
        public double AdapterHeight { get; set; }
        public double AdapterThickness { get; set; }


        public DefaultHandle()
        {
            
        }
        
        public HandleTopView CalculateTopView(Element element)
        {
            return new HandleTopView();
        }
    }
}