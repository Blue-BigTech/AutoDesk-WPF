using System.Windows.Controls;
using GUI.Views;

namespace GUI.Stores
{
    public class NavigationStore
    {
        public MainWindow MainWindow { get; set; }
        public HomeView HomeView { get; set; }
        public ProductSelectionView ProductSelectionView { get; set; }
        public ConstructionView ConstructView { get; set; }
        public GeneralProductView GeneralProductView { get; set; }
        public UserControl SpecificProductView { get; set; }
        public DesignView DesignView { get; set; }
        public HandleView HandleView { get; set; }
        public FinishView FinishView { get; set; }
    }
}