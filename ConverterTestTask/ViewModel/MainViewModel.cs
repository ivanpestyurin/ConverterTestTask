using ConverterTestTask.Model;
using ConverterTestTask.Utilities;

namespace ConverterTestTask.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public bool isLeft;
        private Currency currencyLeft;
        public Currency CurrencyLeft
        {
            get
            {
                return currencyLeft;
            }
            set
            {
                currencyLeft = value;
                OnPropertyChanged("CurrencyLeft");
            }
        }

        private Currency currencyRight;
        public Currency CurrencyRight
        {
            get
            {
                return currencyRight;
            }
            set
            {
                currencyRight = value;
                OnPropertyChanged("CurrencyRight");
            }
        }

        private RelayCommand leftButtonCommand;
        public RelayCommand LeftButtonCommand
        {
            get
            {
                return leftButtonCommand ??
                  (leftButtonCommand = new RelayCommand(obj =>
                  {
                      SelectedCurrency = CurrencyLeft;
                  }));
            }
        }

        private RelayCommand rightButtonCommand;
        public RelayCommand RightButtonCommand
        {
            get
            {
                return rightButtonCommand ??
                  (rightButtonCommand = new RelayCommand(obj =>
                  {
                      SelectedCurrency = CurrencyRight;
                  }));
            }
        }

        public MainViewModel()
        {
            currencyLeft = Currencies[11];
            currencyRight = Currencies[0];
            SetRightCurrencyValue();
        }

        public void SetRightCurrencyValue()
        {
            CurrencyRight.Quantity = ((CurrencyLeft.Quantity * CurrencyLeft.Rate) / CurrencyLeft.Nominal)
                / (CurrencyRight.Rate / CurrencyRight.Nominal);
        }

        public void SetLeftCurrencyValue()
        {
            currencyLeft.Quantity = ((CurrencyRight.Quantity * CurrencyRight.Rate) / CurrencyRight.Nominal)
                / (CurrencyLeft.Rate / CurrencyLeft.Nominal);
        }
    }
}
