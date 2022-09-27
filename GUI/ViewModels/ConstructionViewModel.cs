using System;
using System.Collections.Generic;
using GUI.ViewModels;
using GUI.Commands.DrawCommands;
using GUI.Helpers;

namespace GUI.ViewModels
{
    public class ConstructionViewModel : ViewModelBase
    {
        private void ValidateWidth()
        {
            ClearErrors(nameof(WidthOpeningBottom));

            if (WidthOpeningBottom == 0)
            {
                AddError(nameof(WidthOpeningBottom), "Width cannot be 0.");
            }
        }
        
        //Construction Opening Width & Height
        private double _widthOpeningBottom = 1000;
        private double _widthOpeningTop = 1000;
        private double _heightOpeningLeft = 2600;
        private double _heightOpeningRight = 2600;
        
        //Move X & Y
        private double _moveX;
        private double _moveY;
        
        //Corner Points
        private double _downLeftX;
        private double _downLeftY;
        
        private double _downRightX;
        private double _downRightY;
        
        private double _upRightX;
        private double _upRightY;
        
        private double _upLeftX;
        private double _upLeftY;
        
        //Middle Points
        private double _middleDown;
        private double _middleRight;
        private double _middleUp;
        private double _middleLeft;
        
        //Rooms
        private string _roomTop = "Hal";
        private string _roomBottom = "Woonkamer";
        
        //Wall Dimensions
        private double _leftWallX = 250;
        private double _leftWallY = 100;
        private double _rightWallX = 250;
        private double _rightWallY = 100;
        
        private bool _isPositionedOnLeftWall = true;
        private string _selectedPositionOnWall;
        private double _distanceProductCenter = 50;

        public double WidthOpeningBottom
        {
            get => _widthOpeningBottom;
            set
            {
                _widthOpeningBottom = value;
                ValidateWidth();
                OnPropertyChanged(nameof(WidthOpeningBottom));
            }
        }
        public double WidthOpeningTop
        {
            get => _widthOpeningTop;
            set
            {
                _widthOpeningTop = value;
                OnPropertyChanged(nameof(WidthOpeningTop));
            }
        }
        public double HeightOpeningLeft
        {
            get => _heightOpeningLeft;
            set
            {
                _heightOpeningLeft = value;
                OnPropertyChanged(nameof(HeightOpeningLeft));
            }
        }
        public double HeightOpeningRight
        {
            get => _heightOpeningRight;
            set
            {
                _heightOpeningRight = value;
                OnPropertyChanged(nameof(HeightOpeningRight));
            }
        }
        public double MoveX
        {
            get => _moveX;
            set
            {
                _moveX = value;
                OnPropertyChanged(nameof(MoveX));
            }
        }
        public double MoveY
        {
            get => _moveY;
            set
            {
                _moveY = value;
                OnPropertyChanged(nameof(MoveY));
            }
        }

        public double DownLeftX
        {
            get => _downLeftX;
            set
            {
                _downLeftX = value;

                if (_downLeftX - _upLeftX == 0)
                {
                    GuiDisplayValidation.IsLeftSlant = false;
                }
                else
                {
                    GuiDisplayValidation.IsLeftSlant = true;
                    GuiDisplayValidation.LeftSlantAmount = Math.Abs(_downLeftX - _upLeftX);
                }
                
                if (_downLeftX > _upLeftX)
                {
                    GuiDisplayValidation.IsSlantLeftTop = true;
                }
                else
                {
                    GuiDisplayValidation.IsSlantLeftTop = false;
                }
                
                MiddleLeft = value / 2;
                
                OnPropertyChanged(nameof(DownLeftX));
            }
        }
        public double DownLeftY
        {
            get => _downLeftY;
            set
            {
                _downLeftY = value;
                
                // if (double.Parse(_downLeftY) != 0 && double.Parse(_downRightY) != 0)
                // {
                //     DownRightY = "0";
                // }

                MiddleDown = value / 2;

                OnPropertyChanged(nameof(DownLeftY));
            }
        }
        public double DownRightX
        {
            get => _downRightX;
            set
            {
                _downRightX = value;
                
                if (_downRightX - _upRightX == 0)
                {
                    GuiDisplayValidation.IsRightSlant = false;
                }
                else
                {
                    GuiDisplayValidation.IsRightSlant = true;
                    GuiDisplayValidation.RightSlantAmount = Math.Abs(_downRightX - _upRightX);
                }
                
                if (_downRightX < _upRightX)
                {
                    GuiDisplayValidation.IsSlantRightTop = true;
                }
                else
                {
                    GuiDisplayValidation.IsSlantRightTop = false;
                }
                
                MiddleRight = value / 2;

                OnPropertyChanged(nameof(DownRightX));
            }
        }
        public double DownRightY
        {
            get => _downRightY;
            set
            {
                _downRightY = value;
                
                // if (double.Parse(_downRightY) != 0 && double.Parse(_downLeftY) != 0)
                // {
                //     DownLeftY = "0";
                // }

                MiddleDown = value / 2;

                OnPropertyChanged(nameof(DownRightY));
            }
        }
        public double UpRightX
        {
            get => _upRightX;
            set
            {
                _upRightX = value;
                
                if (_upRightX - _downRightX == 0)
                {
                    GuiDisplayValidation.IsRightSlant = false;
                }
                else
                {
                    GuiDisplayValidation.IsRightSlant = true;
                    GuiDisplayValidation.RightSlantAmount = Math.Abs(_downRightX - _upRightX);
                }
                
                if (_upRightX > _downRightX)
                {
                    GuiDisplayValidation.IsSlantRightTop = true;
                }
                else
                {
                    GuiDisplayValidation.IsSlantRightTop = false;
                }
                
                MiddleRight = value / 2;
                
                OnPropertyChanged(nameof(UpRightX));
            }
        }
        public double UpRightY
        {
            get => _upRightY;
            set
            {
                _upRightY = value;
                
                // if (double.Parse(_upRightY) != 0 && double.Parse(_upLeftY) != 0)
                // {
                //     UpLeftY = "0";
                // }

                MiddleUp = value / 2;

                OnPropertyChanged(nameof(UpRightY));
            }
        }
        public double UpLeftX
        {
            get => _upLeftX;
            set
            {
                _upLeftX = value;
                
                if (_upLeftX - _downLeftX == 0)
                {
                    GuiDisplayValidation.IsLeftSlant = false;
                }
                else
                {
                    GuiDisplayValidation.IsLeftSlant = true;
                    GuiDisplayValidation.LeftSlantAmount = Math.Abs(_downLeftX - _upLeftX);
                }
                
                if (_upLeftX < _downLeftX)
                {
                    GuiDisplayValidation.IsSlantLeftTop = true;
                }
                else
                {
                    GuiDisplayValidation.IsSlantLeftTop = false;
                }

                MiddleLeft = value / 2;
                
                OnPropertyChanged(nameof(UpLeftX));
            }
        }
        public double UpLeftY
        {
            get => _upLeftY;
            set
            {
                _upLeftY = value;
                
                // if (double.Parse(_upLeftY) != 0 && double.Parse(_upRightY) != 0)
                // {
                //     UpRightY = "0";
                // }

                MiddleUp = value / 2;

                OnPropertyChanged(nameof(UpLeftY));
            }
        }

        public double MiddleDown
        {
            get => _middleDown;
            set
            {
                _middleDown = value;
                OnPropertyChanged(nameof(MiddleDown));
            }
        }
        public double MiddleRight
        {
            get => _middleRight;
            set
            {
                _middleRight = value;
                OnPropertyChanged(nameof(MiddleRight));
            }
        }
        public double MiddleUp
        {
            get => _middleUp;
            set
            {
                _middleUp = value;
                OnPropertyChanged(nameof(MiddleUp));
            }
        }
        public double MiddleLeft
        {
            get => _middleLeft;
            set
            {
                _middleLeft = value;
                OnPropertyChanged(nameof(MiddleLeft));
            }
        }

        public DrawConstructionOpeningCommand DrawConstructionOpening { get; }

        public string RoomTop
        {
            get => _roomTop;
            set
            {
                _roomTop = value;
                OnPropertyChanged(nameof(RoomTop));
            }
        }
        public string RoomBottom
        {
            get => _roomBottom;
            set
            {
                _roomBottom = value;
                OnPropertyChanged(nameof(RoomBottom));
            }
        }

        public double LeftWallX
        {
            get => _leftWallX;
            set
            {
                _leftWallX = value;
                OnPropertyChanged(nameof(LeftWallX));
            }
        }
        public double LeftWallY
        {
            get => _leftWallY;
            set
            {
                _leftWallY = value;
                OnPropertyChanged(nameof(LeftWallY));
            }
        }
        public double RightWallX
        {
            get => _rightWallX;
            set
            {
                _rightWallX = value;
                OnPropertyChanged(nameof(RightWallX));
            }
        }
        public double RightWallY
        {
            get => _rightWallY;
            set
            {
                _rightWallY = value;
                OnPropertyChanged(nameof(RightWallY));
            }
        }

        public List<string> WallPositions { get; }
        public bool IsPositionedOnLeftWall
        {
            get => _isPositionedOnLeftWall;
            set
            {
                _isPositionedOnLeftWall = value;
                OnPropertyChanged(nameof(IsPositionedOnLeftWall));
            }
        }
        public string SelectedPositionOnWall
        {
            get => _selectedPositionOnWall;
            set
            {
                _selectedPositionOnWall = value;
                OnPropertyChanged(nameof(SelectedPositionOnWall));
            }
        }
        public double DistanceProductCenter
        {
            get => _distanceProductCenter;
            set
            {
                _distanceProductCenter = value;
                OnPropertyChanged(nameof(DistanceProductCenter));
            }
        }


        public ConstructionViewModel()
        {
            WallPositions = new List<string> { "Top", "Center", "Bottom" };
            SelectedPositionOnWall = WallPositions[1];
            
            DrawConstructionOpening = new DrawConstructionOpeningCommand(this);
        }
    }
}