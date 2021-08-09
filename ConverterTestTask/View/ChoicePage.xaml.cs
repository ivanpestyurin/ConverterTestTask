using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ConverterTestTask.ViewModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterTestTask.View
{
    public sealed partial class ChoicePage : Page
    {
        private ViewModelBase viewModel;
        public ChoicePage()
        {
            InitializeComponent();

            DataContext = new ChoiceViewModel();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                viewModel = (ViewModelBase)e.Parameter;

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedCurrency = ((ChoiceViewModel)DataContext).SelectedCurrency;
            Frame.Navigate(typeof(View), viewModel);
        }

    }
}
