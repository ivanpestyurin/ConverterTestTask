using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ConverterTestTask.ViewModel;
using Windows.Foundation;

namespace ConverterTestTask.View
{
    public sealed partial class View : Page
    {
        public View()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            Windows.UI.ViewManagement.ApplicationView appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.SetPreferredMinSize(new Size(400, 600));

            SizeChanged += Page_SizeChanged;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                DataContext = (MainViewModel)e.Parameter;

                ((MainViewModel)DataContext).SelectedCurrency = ((MainViewModel)e.Parameter).SelectedCurrency;

                if (((MainViewModel)DataContext).isLeft)
                {
                    ((MainViewModel)DataContext).CurrencyLeft = ((MainViewModel)DataContext).SelectedCurrency;
                    ((MainViewModel)DataContext).SetRightCurrencyValue();
                }
                else
                {
                    ((MainViewModel)DataContext).CurrencyRight = ((MainViewModel)DataContext).SelectedCurrency;
                    ((MainViewModel)DataContext).SetLeftCurrencyValue();
                }
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)DataContext).isLeft = true;
            ((MainViewModel)DataContext).SelectedCurrency = ((MainViewModel)DataContext).CurrencyLeft;////////
            Frame.Navigate(typeof(ChoicePage), (MainViewModel)DataContext);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)DataContext).isLeft = false;
            ((MainViewModel)DataContext).SelectedCurrency = ((MainViewModel)DataContext).CurrencyRight;///////
            Frame.Navigate(typeof(ChoicePage), (MainViewModel)DataContext);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox2.TextChanged -= TextBox_TextChanged_1;
            TextBox tb = sender as TextBox;
            if (double.TryParse(tb.Text, out _))
            {
                ((MainViewModel)DataContext).SetRightCurrencyValue();
            }

            textBox2.TextChanged += TextBox_TextChanged_1;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            textBox1.TextChanged -= TextBox_TextChanged;
            TextBox tb = sender as TextBox;
            if (double.TryParse(tb.Text, out _))
            {
                ((MainViewModel)DataContext).SetLeftCurrencyValue();
            }

            textBox1.TextChanged += TextBox_TextChanged;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
