using System;

using SmartThermostat.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SmartThermostat.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
