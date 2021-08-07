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
using Windows.UI.Xaml.Controls;
using ConverterTestTask.View;

namespace ConverterTestTask.ViewModel
{
    public class ViewModel : ViewModelBase
    {
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
    }
}
