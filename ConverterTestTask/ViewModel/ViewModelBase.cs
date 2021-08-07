using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ConverterTestTask.Model;
using ConverterTestTask.Utilities;
using Windows.UI.Core;

namespace ConverterTestTask.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private Currency currencyLeft;
        private Currency currencyRight;
        private Currency selectedCurrency;
        public bool isLeft;
        public ObservableCollection<Currency> Currencies { get; set; }

        public Currency SelectedCurrency
        {
            get
            {
                return selectedCurrency;
            }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
            }
        }

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
                currencyRight = value;
                OnPropertyChanged("CurrencyRight");
                Count1(CurrencyRight);
            }
        }


        public void Count(Currency currency)
        {
            CurrencyRight.Quantity =  ((currency.Quantity * currency.Rate) / currency.Nominal) 
                / (CurrencyRight.Rate / CurrencyRight.Nominal);
        }

        public void Count1(Currency currency)
        {
            currencyLeft.Quantity = ((currency.Quantity * currency.Rate) / currency.Nominal)
                / (CurrencyLeft.Rate / CurrencyLeft.Nominal);
        }

        public ViewModelBase()
        {

            Parser p = new Parser();

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
            currencyLeft = Currencies[11];//
            currencyRight = Currencies[0];//
            Count(CurrencyLeft);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
