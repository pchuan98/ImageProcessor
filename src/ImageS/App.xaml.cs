using System.Windows;
using System.Windows.Media;
using CommunityToolkit.Mvvm.Messaging;
using ImageS.Core.ViewModels;
using ImageS.Core.ViewModels.Command;
using ImageS.Services;
using ImageS.Views;
using Microsoft.Extensions.DependencyInjection;
using LogService = ImageS.Services.LogService;


namespace ImageS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceCollection Ioc = new ServiceCollection();

        private void Injection()
        {
            // services
            Ioc.AddSingleton<Core.Services.IFileService, FileService>();
            Ioc.AddSingleton<Core.Services.ILogService, LogService>();

            // viewmodels
            Ioc.AddSingleton<MenuViewModel>();
            Ioc.AddSingleton<GalleryViewModel>();
            Ioc.AddSingleton<PresentViewModel>();
            Ioc.AddSingleton<ShellViewModel>();


            // windows
            Ioc.AddSingleton<ShellView>(s => new ShellView()
            {
                DataContext = s.GetRequiredService<ShellViewModel>(),
                Background = Brushes.White
            });

            // Listeners
            Ioc.AddSingleton<IMessenger, WeakReferenceMessenger>();
            Ioc.AddSingleton<Core.Listener.IoListener>();
        }
        public App()
        {
            Injection();
            SwitchWindowTheme();

            KeepLive();
        }


        // note https://ghost1372.github.io/handycontrol/theme/
        private void SwitchWindowTheme()
        {
            //ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            //ThemeManager.Current.AccentColor = Brushes.Red;

        }

        public static object?[] KeepAlive = new object?[10];

        private static void KeepLive()
        {
            // note : don't create and get in the same function,the object will be arbage collected
            var ioc = Ioc.BuildServiceProvider().GetService<Core.Listener.IoListener>();
            KeepAlive[0] = ioc;
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            // keep lisener live
            //var io = Ioc.BuildServiceProvider().GetService<Core.Listener.IoListener>();


            var main = Ioc.BuildServiceProvider().GetService<ShellView>();

            // components
            main!.MenuPresent.DataContext = Ioc.BuildServiceProvider().GetService<MenuViewModel>();
            main!.GalleryPresent.DataContext = Ioc.BuildServiceProvider().GetService<GalleryViewModel>();

            main.Show();
        }
    }
}
