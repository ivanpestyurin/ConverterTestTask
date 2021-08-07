using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ConverterTestTask.ViewModel;
using ConverterTestTask.Model;
using System.Drawing;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Core;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterTestTask.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View : Page
    {
        public View()
        {
            this.InitializeComponent();

            DataContext = new ViewModel.ViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                DataContext = (ViewModel.ViewModel)e.Parameter;

                if (((ViewModel.ViewModel)DataContext).isLeft)
                {
                    ((ViewModel.ViewModel)DataContext).SelectedCurrency = ((ViewModel.ViewModel)e.Parameter).SelectedCurrency;
                    ((ViewModel.ViewModel)DataContext).CurrencyLeft = ((ViewModel.ViewModel)DataContext).SelectedCurrency;
                }
                else
                {
                    ((ViewModel.ViewModel)DataContext).SelectedCurrency = ((ViewModel.ViewModel)e.Parameter).SelectedCurrency;
                    ((ViewModel.ViewModel)DataContext).CurrencyRight = ((ViewModel.ViewModel)DataContext).SelectedCurrency;
                }
                
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModel.ViewModel)DataContext).isLeft = true;
            Frame.Navigate(typeof(ChoicePage), (ViewModel.ViewModel)DataContext);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((ViewModel.ViewModel)DataContext).isLeft = false;
            Frame.Navigate(typeof(ChoicePage), (ViewModel.ViewModel)DataContext);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;

            if (double.TryParse(tb.Text, out tmp))
            {
                ((ViewModel.ViewModel)DataContext).CurrencyLeft = ((ViewModel.ViewModel)DataContext).CurrencyLeft;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;
            if (double.TryParse(tb.Text, out tmp))
            {
                ((ViewModel.ViewModel)DataContext).CurrencyRight = ((ViewModel.ViewModel)DataContext).CurrencyRight;
            }
        }

    }
}
