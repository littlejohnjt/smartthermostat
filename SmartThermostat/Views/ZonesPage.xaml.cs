using System;

using SmartThermostat.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SmartThermostat.Views
{
    public sealed partial class ZonesPage : Page
    {
        private ZonesViewModel ViewModel
        {
            get { return DataContext as ZonesViewModel; }
        }

        public ZonesPage()
        {
            InitializeComponent();
        }
    }
}
