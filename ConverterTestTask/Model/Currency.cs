using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterTestTask.Model
{
    public class Currency : INotifyPropertyChanged
    {
        private string name;
        private string charCode;
        private double value;
        private double quantity = 0;//

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
        public double Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
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
