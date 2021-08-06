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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterTestTask.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View : Page
    {
        ViewModelBase viewModel;
        public View()
        {
            this.InitializeComponent();

            viewModel = new ViewModel.ViewModel();

            DataContext = viewModel;

        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {

                if (viewModel.SelectedCurrency == viewModel.CurrencyLeft)
                {
                    viewModel.SelectedCurrency = (Currency)e.Parameter;
                    viewModel.CurrencyLeft = viewModel.SelectedCurrency;
                }
                else
                {
                    viewModel.SelectedCurrency = (Currency)e.Parameter;
                    viewModel.CurrencyRight = viewModel.SelectedCurrency;
                }
                
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SelectedCurrency = viewModel.CurrencyLeft;
            Frame.Navigate(typeof(ChoicePage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.SelectedCurrency = viewModel.CurrencyRight;
            Frame.Navigate(typeof(ChoicePage));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;

            if (double.TryParse(tb.Text, out tmp))
            {
                viewModel.CurrencyLeft = viewModel.CurrencyLeft;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;
            if (double.TryParse(tb.Text, out tmp))
            {
                viewModel.CurrencyRight = viewModel.CurrencyRight;
            }
        }

    }
}
