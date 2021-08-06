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
        ViewModel.ViewModel viewModel;
        public View()
        {
            this.InitializeComponent();

            viewModel = new ViewModel.ViewModel();

            DataContext = viewModel;
            //qwe();
            //func();
        }
        public void func()
        {
            //layoutGrid.Background = new SolidColorBrush(Colors.White);
            layoutGrid.Background = new SolidColorBrush(Colors.Wheat);

            for (int i = 0; i < 5; i++)
            {
                layoutGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Pixel) });
            }
            for (int i = 0; i < 3; i++)
            {
                layoutGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            Image img = new Image();
            img.HorizontalAlignment = HorizontalAlignment.Center;
            img.VerticalAlignment = VerticalAlignment.Center;
            img.Source = new BitmapImage(new Uri("ms-appx:///Images/50897.png"));
            Grid.SetRow(img, 0);
            Grid.SetRowSpan(img, 2);
            Grid.SetColumn(img, 1);
            layoutGrid.Children.Add(img);

            TextBox tb = new TextBox();
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.Text = "{Binding CurrencyLeft.Quantity, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}";
            tb.BorderThickness = new Thickness(0);
            tb.FontSize = 36;
            Grid.SetRow(tb, 0);
            Grid.SetColumn(tb, 0);
            layoutGrid.Children.Add(tb);

            TextBox tb1 = new TextBox();
            tb1.HorizontalAlignment = HorizontalAlignment.Center;
            tb1.VerticalAlignment = VerticalAlignment.Center;
            tb1.Text = "{Binding CurrencyRight.Quantity, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}";
            tb1.BorderThickness = new Thickness(0);
            tb1.FontSize = 36;
            Grid.SetRow(tb1, 0);
            Grid.SetColumn(tb1, 2);
            layoutGrid.Children.Add(tb1);

            TextBox tb2 = new TextBox();
            tb2.HorizontalAlignment = HorizontalAlignment.Center;
            tb2.VerticalAlignment = VerticalAlignment.Center;
            tb2.Text = "{Binding CurrencyLeft.CharCode, UpdateSourceTrigger=PropertyChanged}";
            tb2.BorderThickness = new Thickness(0);
            tb2.FontSize = 36;
            Grid.SetRow(tb2, 1);
            Grid.SetColumn(tb2, 0);
            layoutGrid.Children.Add(tb2);

            TextBox tb3 = new TextBox();
            tb3.HorizontalAlignment = HorizontalAlignment.Center;
            tb3.VerticalAlignment = VerticalAlignment.Center;
            tb3.Text = "{Binding CurrencyRight.CharCode, UpdateSourceTrigger=PropertyChanged}";
            tb3.BorderThickness = new Thickness(0);
            tb3.FontSize = 36;
            Grid.SetRow(tb3, 1);
            Grid.SetColumn(tb3, 2);
            layoutGrid.Children.Add(tb3);


            //Button btn = new Button();
            //btn.HorizontalAlignment = HorizontalAlignment.Center;
            ////Background = "#00000000"
            //btn.Background = new SolidColorBrush(Colors.Transparent);
            //btn.Foreground = new SolidColorBrush(Colors.Blue);
            //btn.Text = "{Binding CurrencyRight.CharCode, UpdateSourceTrigger=PropertyChanged}";
            //btn.BorderThickness = new Thickness(0);
            //btn.FontSize = 12;
            
            //btn.
            //Grid.SetRow(btn, 2);
            //Grid.SetColumn(btn, 0);
            //layoutGrid.Children.Add(btn);

            //                < !--< Image
            //    Grid.Row = "0"
            //    Grid.RowSpan = "2"
            //    Grid.Column = "1"
            //    Source = "/Images/50897.png" />

            //< TextBox
            //    Grid.Row = "0"
            //    Grid.Column = "0"
            //    HorizontalAlignment = "Center"
            //    VerticalAlignment = "Center"
            //    BorderThickness = "0"
            //    FontSize = "36"
            //    Text = "{Binding CurrencyLeft.Quantity, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />

            //< TextBox
            //    Grid.Row = "0"
            //    Grid.Column = "2"
            //    HorizontalAlignment = "Center"
            //    VerticalAlignment = "Center"
            //    BorderThickness = "0"
            //    FontSize = "36"
            //    Text = "{Binding CurrencyRight.Quantity, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />

            //< TextBox
            //    Grid.Row = "1"
            //    Grid.Column = "0"
            //    HorizontalAlignment = "Center"
            //    VerticalAlignment = "Center"
            //    BorderThickness = "0"
            //    FontSize = "36"
            //    IsReadOnly = "True"
            //    Text = "{Binding CurrencyLeft.CharCode, UpdateSourceTrigger=PropertyChanged}" />

            //< TextBox
            //    Grid.Row = "1"
            //    Grid.Column = "2"
            //    HorizontalAlignment = "Center"
            //    VerticalAlignment = "Center"
            //    BorderThickness = "0"
            //    FontSize = "36"
            //    IsReadOnly = "True"
            //    Text = "{Binding CurrencyRight.CharCode, Mode=TwoWay}" />

            //< Button
            //    Grid.Row = "2"
            //    Width = "80"
            //    Height = "61"
            //    HorizontalAlignment = "Center"
            //    Background = "#00000000"
            //    Click = "Button_Click"
            //    FontSize = "12"
            //    Foreground = "#FF007AF3" >
            //    < TextBlock
            //        Text = "Изменить валюту"
            //        TextAlignment = "Center"
            //        TextWrapping = "Wrap" />
            //</ Button >

            //< Button
            //    Grid.Row = "2"
            //    Grid.Column = "2"
            //    Width = "80"
            //    Height = "61"
            //    HorizontalAlignment = "Center"
            //    Background = "#00000000"
            //    FontSize = "12"
            //    Foreground = "#FF007AF3" >
            //    < TextBlock
            //        Text = "Изменить валюту"
            //        TextAlignment = "Center"
            //        TextWrapping = "Wrap" />
            //</ Button > -->
        }
        public void qwe()
        {
            int len = viewModel.Currencies.Count;

            layoutGrid.Background = new SolidColorBrush(Colors.LightGray);

            for (int i = 0; i < len; i++)
            {
                layoutGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Pixel) });
            }
            for (int i = 0; i < 5; i++)
            {
                layoutGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < len; i++)
            {
                TextBlock tb = new TextBlock();
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.VerticalAlignment = VerticalAlignment.Center;
                tb.FontSize = 18;
                tb.TextWrapping = TextWrapping.Wrap;
                tb.Text = viewModel.Currencies[i].Name;
                Grid.SetRow(tb, i);
                Grid.SetColumn(tb, 0);
                Grid.SetColumnSpan(tb, 3);
                layoutGrid.Children.Add(tb);

                TextBlock tb1 = new TextBlock();
                tb1.HorizontalAlignment = HorizontalAlignment.Center;
                tb1.VerticalAlignment = VerticalAlignment.Center;
                tb1.FontSize = 24;
                tb1.Foreground = new SolidColorBrush(Colors.DarkGray);
                tb1.TextWrapping = TextWrapping.Wrap;
                tb1.Text = viewModel.Currencies[i].CharCode;
                Grid.SetRow(tb1, i);
                Grid.SetColumn(tb1, 3);
                layoutGrid.Children.Add(tb1);

                CheckBox cb = new CheckBox();
                Grid.SetRow(cb, i);
                Grid.SetColumn(cb, 4);
                layoutGrid.Children.Add(cb);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(ChoicePage));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;
            //double tmp1 = Convert.ToDouble(tb.Text);

            if (double.TryParse(tb.Text, out tmp))
            {
                viewModel.CurrencyLeft = viewModel.CurrencyLeft;
            }
            //viewModel.CurrencyLeft = viewModel.CurrencyLeft;
            //viewModel.
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            double tmp;
            if (double.TryParse(tb.Text, out tmp))
            {
                viewModel.CurrencyRight = viewModel.CurrencyRight;
            }
            //viewModel.CurrencyRight = viewModel.CurrencyRight;
        }
    }
}
