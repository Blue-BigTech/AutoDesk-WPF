using System.Windows;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using GUI;
using AcAp = Autodesk.AutoCAD.ApplicationServices.Application;
using Application = Autodesk.AutoCAD.ApplicationServices.Core.Application;
using Exception = Autodesk.AutoCAD.Runtime.Exception;

[assembly: CommandClass(typeof(AutoCAD))]

namespace GUI
{
    public static class AutoCAD
    {
        private static MainWindow Window { get; set; }

        [CommandMethod("doorpro")]
        public static void CreateDoorPROGUI()
        {
            Window = new MainWindow();

            Application.ShowModelessWindow(Window);
        }

        public static void HideDoorPROGUI()
        {
            Window.Hide();
        }
        
        public static void ShowDoorPROGUI()
        {
            Window.Show();
        }
    }
}