using System.Collections.ObjectModel;
using System.ComponentModel;
using ConverterTestTask.Model;
using ConverterTestTask.Utilities;

namespace ConverterTestTask.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public ObservableCollection<Currency> Currencies { get; set; }

        private Currency selectedCurrency;
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

        public ViewModelBase()
        {
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

            Parser p = new Parser();

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
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
