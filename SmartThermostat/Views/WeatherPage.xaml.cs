using System;

using SmartThermostat.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SmartThermostat.Views
{
    public sealed partial class WeatherPage : Page
    {
        private WeatherViewModel ViewModel
        {
            get { return DataContext as WeatherViewModel; }
        }

        public WeatherPage()
        {
            InitializeComponent();
        }
    }
}
