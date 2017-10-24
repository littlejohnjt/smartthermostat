using System;

using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

using SmartThermostat.Services;
using SmartThermostat.Views;

namespace SmartThermostat.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<MainViewModel, MainPage>();
            Register<HomeViewModel, HomePage>();
            Register<ZonesViewModel, ZonesPage>();
            Register<WeatherViewModel, WeatherPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public WeatherViewModel WeatherViewModel => ServiceLocator.Current.GetInstance<WeatherViewModel>();

        public ZonesViewModel ZonesViewModel => ServiceLocator.Current.GetInstance<ZonesViewModel>();

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
