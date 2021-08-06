using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ConverterTestTask.Model;
using ConverterTestTask.Utilities;
using Windows.UI.Popups;

namespace ConverterTestTask.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        //private Converter converter;
        public Parser p;
        private Currency currencyLeft;
        private Currency currencyRight;
        public ObservableCollection<Currency> Currencies { get; set; }

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
                Count(CurrencyLeft);
            }
        }
        public Currency CurrencyRight
        {
            get 
            {
                return currencyRight; 
            }
            set
            {
                //QQ();
                currencyRight = value;
                OnPropertyChanged("CurrencyRight");
                Count1(CurrencyRight);
                //Count(CurrencyRight, CurrencyLeft);
            }
        }
        private void QQ()
        {
            var dialog = new MessageDialog("No internet connection has been found.");
            dialog.Commands.Add(new UICommand("Yes", null));
            dialog.Commands.Add(new UICommand("No", null));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            var cmd = dialog.ShowAsync();
        }

        public void Count(Currency currency)
        {
            CurrencyRight.Quantity = currency.Quantity * currency.Rate / CurrencyRight.Rate;
        }

        public void Count1(Currency currency)
        {
            currencyLeft.Quantity = currency.Quantity * currency.Rate / currencyLeft.Rate;
        }

        public ViewModel()
        {
            p = new Parser();

            Currencies = new ObservableCollection<Currency>
            {
                new Currency
                {
                    Name = "Рубль",
                    CharCode = "RUB",
                    Rate = 1,
                    Nominal = 1,
                    Quantity = 1
                }
            };

            for (int i = 0; i < p.Length; i++)
            {
                Currencies.Add(new Currency
                {
                    Name = p.name[i],
                    CharCode = p.charCode[i],
                    Rate = p.rate[i],
                    Nominal = p.nominal[i],
                    Quantity = 1
                });
            }
            currencyLeft = Currencies[11];
            currencyRight = Currencies[0];
        }

        //private double leftValue = 0;
        //private double rightValue = 0;

        //public double LeftValue
        //{
        //    get
        //    {
        //        return leftValue;
        //    }
        //    set
        //    {
        //        leftValue = value;
        //        OnPropertyChanged("LeftValue");
        //    }
        //}
        //public double RightValue
        //{
        //    get
        //    {
        //        return rightValue;
        //    }
        //    set
        //    {
        //        rightValue = value;
        //        OnPropertyChanged("RightValue");
        //    }
        //}
    }
}
