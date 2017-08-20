﻿using MeteringDevices.Core.Common;
using MeteringDevices.Core.Notification;
using MeteringDevices.Core.RestSharp;
using MeteringDevices.Core.Spb;
using MeteringDevices.Data;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;

namespace MeteringDevices.Core
{
    public class Register : NinjectModule
    {
        private const string _NotifierTelegramBaseUrl = "Notifier.Telegram.BaseUrl";
        private const string _NotifierTelegramToken = "Notifier.Telegram.Token";
        private const string _NotifierTelegramChatId = "Notifier.Telegram.ChatId";

        private const string _KznUsernameKey = "Kzn.Service.Username";
        private const string _KznPasswordKey = "Kzn.Service.Password";
        private const string _KznBaseUrlKey = "Kzn.Service.BaseUrl";

        private const string _KznAccountNumberKey = "Kzn.AccountNumber";
        private const string _KznEnabledKey = "Kzn.Enabled";
        private const string _KznMeteringDeviceDayIdKey = "Kzn.MeteringDevice.DayId";
        private const string _KznMeteringDeviceNightIdKey = "Kzn.MeteringDevice.NightId";
        private const string _KznMeteringDeviceColdIdKey = "Kzn.MeteringDevice.ColdId";
        private const string _KznMeteringDeviceHotIdKey = "Kzn.MeteringDevice.HotId";

        private const string _SpbUsernameKey = "Spb.Service.Username";
        private const string _SpbPasswordKey = "Spb.Service.Password";
        private const string _SpbBaseUrlKey = "Spb.Service.BaseUrl";

        private const string _SpbAccountNumberKey = "Spb.AccountNumber";
        private const string _SpbEnabledKey = "Spb.Enabled";
        private const string _SpbMeteringDeviceDayIdKey = "Spb.MeteringDevice.DayId";
        private const string _SpbMeteringDeviceNightIdKey = "Spb.MeteringDevice.NightId";
        
        public override void Load()
        {
            Kernel.Bind<Kzn.ISendApiService>().ToMethod(CreateKznSendApiService).InSingletonScope();
            Kernel.Bind<Spb.IAccountsApiService>().ToMethod(CreateSpbAccountsApiService).InSingletonScope();
            Kernel.Bind<IJsonSerializerFactory>().To<JsonSerializerFactory>().InSingletonScope();
            Kernel.Bind<IRestSharpFactory>().To<RestSharpFactory>().InSingletonScope();
            Kernel.Bind<ISendApiServiceFactory>().To<SendApiServiceFactory>();
            Kernel.Bind<INotifier>().ToMethod(CreateNotifier).InSingletonScope();
            Kernel.Bind<IApp>().ToMethod(CreateApp).InSingletonScope();
        }

        private Kzn.ISendApiService CreateKznSendApiService(IContext arg)
        {
            return new Kzn.SendApiService(arg.Kernel.Get<IRestSharpFactory>(), ConfigUtils.GetStringFromConfig(_KznBaseUrlKey));
        }

        private IAccountsApiService CreateSpbAccountsApiService(IContext arg)
        {
            return new Spb.AccountsApiService(arg.Kernel.Get<IRestSharpFactory>(), ConfigUtils.GetStringFromConfig(_SpbBaseUrlKey));
        }

        private IApp CreateApp(IContext arg)
        {
            return new App(
                new DataProvider(
                    arg.Kernel.Get<ISessionFactory>(),
                    arg.Kernel.Get<INotifier>(),
                    new Kzn.RetrieverService(
                        ConfigUtils.GetStringFromConfig(_KznMeteringDeviceDayIdKey),
                        ConfigUtils.GetStringFromConfig(_KznMeteringDeviceNightIdKey),
                        ConfigUtils.GetStringFromConfig(_KznMeteringDeviceColdIdKey),
                        ConfigUtils.GetStringFromConfig(_KznMeteringDeviceHotIdKey)
                    ),
                    new Kzn.SendService(
                        arg.Kernel.Get<Kzn.ISendApiService>(),
                        ConfigUtils.GetStringFromConfig(_KznUsernameKey),
                        ConfigUtils.GetStringFromConfig(_KznPasswordKey)
                    ),
                    ConfigUtils.GetBoolFromConfig(_KznEnabledKey),
                    ConfigUtils.GetStringFromConfig(_KznAccountNumberKey)
                ),
                new DataProvider(
                    arg.Kernel.Get<ISessionFactory>(),
                    arg.Kernel.Get<INotifier>(),
                    new Spb.RetrieverService(
                        ConfigUtils.GetStringFromConfig(_SpbMeteringDeviceDayIdKey),
                        ConfigUtils.GetStringFromConfig(_SpbMeteringDeviceNightIdKey)
                    ),
                    new Spb.SendService(
                        arg.Kernel.Get<ISendApiServiceFactory>(),
                        arg.Kernel.Get<IAccountsApiService>(),
                        ConfigUtils.GetStringFromConfig(_SpbUsernameKey),
                        ConfigUtils.GetStringFromConfig(_SpbPasswordKey)
                    ),
                    ConfigUtils.GetBoolFromConfig(_SpbEnabledKey),
                    ConfigUtils.GetStringFromConfig(_SpbAccountNumberKey)
               )
            );
        }

        private INotifier CreateNotifier(IContext arg)
        {
            return new TelegramNotifier(
                ConfigUtils.GetStringFromConfig(_NotifierTelegramBaseUrl),
                ConfigUtils.GetStringFromConfig(_NotifierTelegramToken), 
                ConfigUtils.GetLongFromConfig(_NotifierTelegramChatId),
                Kernel.Get<IRestSharpFactory>()
            );
        }
    }
}