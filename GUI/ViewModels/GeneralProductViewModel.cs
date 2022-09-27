using GUI.ViewModels.ProductViewModels;

namespace GUI.ViewModels
{
    public class GeneralProductViewModel : ViewModelBase
    {
        private bool _isSingle = false;
        private bool _isTurningLeft = true;
        private double _lslWidth = 300;
        private double _rslWidth = 300;
        private bool _isLeftSlant;
        private bool _isRightSlant;
        private bool _isLeftSlantTop;
        private bool _isRightSlantTop;
        private double _leftSlantAmount;
        private double _rightSlantAmount;

        public bool IsSingle
        { 
            get => _isSingle;
            set
            {
                _isSingle = value;
                OnPropertyChanged(nameof(IsSingle));
            }
        }
        public bool IsTurningLeft
        { 
            get => _isTurningLeft;
            set
            {
                _isTurningLeft = value;
                OnPropertyChanged(nameof(IsTurningLeft));
            }
        }
        public double LSLWidth
        {
            get => _lslWidth;
            set
            {
                _lslWidth = value;
                OnPropertyChanged(nameof(LSLWidth));
            }
        }
        public double RSLWidth
        {
            get => _rslWidth;
            set
            {
                _rslWidth = value;
                OnPropertyChanged(nameof(RSLWidth));
            }
        }
        public bool IsLeftSlant 
        {
            get => _isLeftSlant;
            set
            {
                _isLeftSlant = value;
                OnPropertyChanged(nameof(IsLeftSlant));
            }
        }
        public bool IsRightSlant
        {
            get => _isRightSlant;
            set
            {
                _isRightSlant = value;
                OnPropertyChanged(nameof(IsRightSlant));
            }
        }
        public bool IsLeftSlantTop
        { 
            get => _isLeftSlantTop;
            set
            {
                _isLeftSlantTop = value;
                OnPropertyChanged(nameof(IsLeftSlantTop));
            }
        }
        public bool IsRightSlantTop
        { 
            get => _isRightSlantTop;
            set
            {
                _isRightSlantTop = value;
                OnPropertyChanged(nameof(IsRightSlantTop));
            }
        }
        public double LeftSlantAmount
        {
            get => _leftSlantAmount;
            set
            {
                _leftSlantAmount = value;
                OnPropertyChanged(nameof(LeftSlantAmount));
            }
        }
        public double RightSlantAmount
        {
            get => _rightSlantAmount;
            set
            {
                _rightSlantAmount = value;
                OnPropertyChanged(nameof(RightSlantAmount));
            }
        }
        
        public GeneralProductViewModel()
        {

        }
    }
}