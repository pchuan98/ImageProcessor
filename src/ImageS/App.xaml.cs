using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using HandyControl.Themes;
using ImageS.Core.ViewModels;
using ImageS.Services;
using ImageS.Views;
using Microsoft.Extensions.DependencyInjection;


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
            // commands
            Ioc.AddSingleton<Core.ViewModels.Command.IoCommand>();

            // services
            Ioc.AddSingleton<Core.Services.IFileService, FileService>();

            // viewmodels
            Ioc.AddSingleton<MenuViewModel>();
            Ioc.AddSingleton<GalleryViewModel>();
            Ioc.AddSingleton<PresentViewModel>();
            Ioc.AddSingleton<ShellViewModel>();

            // components
            Ioc.AddSingleton<MenuView>(s => new MenuView()
            {
                DataContext = s.GetRequiredService<MenuViewModel>(),
            });

            // windows
            Ioc.AddSingleton<ShellView>(s => new ShellView()
            {
                DataContext = s.GetRequiredService<ShellViewModel>(),
                Background = Brushes.White
            });

        }
        public App()
        {
            Injection();
            SwitchWindowTheme();
        }


        // note https://ghost1372.github.io/handycontrol/theme/
        private void SwitchWindowTheme()
        {
            //ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            //ThemeManager.Current.AccentColor = Brushes.Red;

        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var main = Ioc.BuildServiceProvider().GetService<ShellView>();

            // components
            var menu = Ioc.BuildServiceProvider().GetService<MenuView>();

            main!.MenuPresent.Children.Add(menu!);

            main.Show();
        }
    }
}
