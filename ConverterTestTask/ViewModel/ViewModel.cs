using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ConverterTestTask.Model;
using ConverterTestTask.Utilities;

namespace ConverterTestTask.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        //private Converter converter;

        private Currency currencyLeft;
        private Currency currencyRight;
        public ObservableCollection<Currency> Currencies { get; set; }

        public Currency CurrencyLeft
        {
            get { return currencyLeft; }
            set
            {
                currencyLeft = value;
                OnPropertyChanged("CurrencyLeft");
            }
        }
        public Currency CurrencyRight
        {
            get { return currencyRight; }
            set
            {
                currencyRight = value;
                OnPropertyChanged("CurrencyRight");
            }
        }

        public ViewModel()
        {
            Currencies = new ObservableCollection<Currency>();//

            Parser p = new Parser();

            Currencies.Add(new Currency
            {
                Name = "Рубль",
                CharCode = "RUB",
                Rate = 1,
                Nominal = 1,
                Quantity = 1
            });

            for (int i = 0; i < p.Length; i++)
            {
                Currencies.Add(new Currency { 
                    Name = p.name[i], 
                    CharCode = p.charCode[i], 
                    Rate = p.rate[i],
                    Nominal = p.nominal[i],
                    Quantity = 1
                });
            }
            currencyLeft = Currencies[0];
            currencyRight = Currencies[1];
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
