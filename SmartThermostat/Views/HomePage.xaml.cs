using System;

using SmartThermostat.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SmartThermostat.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return DataContext as HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
