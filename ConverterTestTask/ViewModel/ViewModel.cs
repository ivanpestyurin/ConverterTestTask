using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ConverterTestTask.Model;

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
            for (int i = 0; i < 10; i++)
            {
                Currencies.Add(new Currency { Name = "a", CharCode = "b", Value = 4 });
            }
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
