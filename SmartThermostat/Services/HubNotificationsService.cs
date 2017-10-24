﻿using System;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.Messaging;

using SmartThermostat.Activation;

using Windows.ApplicationModel.Activation;
using Windows.Networking.PushNotifications;

namespace SmartThermostat.Services
{
    internal class HubNotificationsService : ActivationHandler<ToastNotificationActivatedEventArgs>
    {
        public async Task InitializeAsync()
        {
            //// See more about adding push notifications to your Windows app at
            //// https://docs.microsoft.com/azure/app-service-mobile/app-service-mobile-windows-store-dotnet-get-started-push

            // Specify your Hub Name here
            var hubName = string.Empty;

            // Specify your DefaultListenSharedAccessSignature here
            var accessSignature = string.Empty;

            var channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

            var hub = new NotificationHub(hubName, accessSignature);
            var result = await hub.RegisterNativeAsync(channel.Uri);
            if (result.RegistrationId != null)
            {
                // Registration was successful
            }

            // You can also send push notifications from Windows Developer Center targeting your app consumers
            // Documentation: https://docs.microsoft.com/windows/uwp/publish/send-push-notifications-to-your-apps-customers
        }

        protected override async Task HandleInternalAsync(ToastNotificationActivatedEventArgs args)
        {
            //// TODO WTS: Handle activation from toast notification,
            //// For more info handling activation see documentation at
            //// https://blogs.msdn.microsoft.com/tiles_and_toasts/2015/07/08/quickstart-sending-a-local-toast-notification-and-handling-activations-from-it-windows-10/

            await Task.CompletedTask;
        }
    }
}
