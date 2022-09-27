using System.Windows;
using BusinessLogic.Settings;
using GUI.ViewModels;

namespace GUI.Commands.DrawCommands
{
    public class DrawConstructionOpeningCommand : CommandBase
    {
        private ConstructionViewModel _cvm;
        public DrawConstructionOpeningCommand(ConstructionViewModel cvm)
        {
            _cvm = cvm;
        }
        public override void Execute(object parameter)
        {
            //CONSTRUCTION OPENING
            CurrentDrawInfo.ConstructionWidthBottom = _cvm.WidthOpeningBottom;
            CurrentDrawInfo.ConstructionWidthTop = _cvm.WidthOpeningTop;
            CurrentDrawInfo.ConstructionHeightLeft = _cvm.HeightOpeningLeft;
            CurrentDrawInfo.ConstructionHeightRight = _cvm.HeightOpeningRight;
        
            CurrentDrawInfo.MoveX = _cvm.MoveX;
            CurrentDrawInfo.MoveY = _cvm.MoveY;
        
            CurrentDrawInfo.DownLeftX = _cvm.DownLeftX;
            CurrentDrawInfo.DownLeftY = _cvm.DownLeftY;
        
            CurrentDrawInfo.DownRightX = _cvm.DownRightX;
            CurrentDrawInfo.DownRightY = _cvm.DownRightY;
        
            CurrentDrawInfo.UpRightX = _cvm.UpRightX;
            CurrentDrawInfo.UpRightY = _cvm.UpRightY;
        
            CurrentDrawInfo.UpLeftX = _cvm.UpLeftX;
            CurrentDrawInfo.UpLeftY = _cvm.UpLeftY;

            CurrentDrawInfo.MiddleDownY = _cvm.MiddleDown;
            CurrentDrawInfo.MiddleRightX = _cvm.MiddleRight;
            CurrentDrawInfo.MiddleUpY = _cvm.MiddleUp;
            CurrentDrawInfo.MiddleLeftX = _cvm.MiddleLeft;

            //Create and draw construction opening
            MessageBox.Show("Construction opening drawn.");
        }
    }
}