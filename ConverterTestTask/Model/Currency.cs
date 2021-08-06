using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ConverterTestTask.Model
{
    public class Currency : INotifyPropertyChanged
    {
        private string name;
        private string charCode;
        private double rate;
        private double quantity;//
        private int nominal;//

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharCode
        {
            get
            {
                return charCode;
            }
            set
            {
                charCode = value;
                OnPropertyChanged("CharCode");
            }
        }
        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
                OnPropertyChanged("Rate");
            }
        }
        public int Nominal
        {
            get
            {
                return nominal;
            }
            set
            {
                nominal = value;
                OnPropertyChanged("Nominal");
            }
        }
        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");

            }
        }
    }
}
