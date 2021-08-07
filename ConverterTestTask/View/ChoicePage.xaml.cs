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
using ConverterTestTask.View;
using ConverterTestTask.ViewModel;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterTestTask.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChoicePage : Page
    {
        ViewModelBase viewModel;
        int i = 0;
        public ChoicePage()
        {
            this.InitializeComponent();

            DataContext = new ChoiceModel();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
                viewModel = (ViewModelBase)e.Parameter;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedCurrency = ((ChoiceModel)DataContext).SelectedCurrency;
            Frame.Navigate(typeof(View), viewModel);
        }
    }
}
