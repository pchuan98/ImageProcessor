using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using HandyControl.Themes;


namespace ImageS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        // note https://ghost1372.github.io/handycontrol/theme/
        private void SwitchWindowTheme()
        {
            //ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            ThemeManager.Current.AccentColor = Brushes.Red;

        }


        protected override void OnStartup(StartupEventArgs e)
        {
            SwitchWindowTheme();
            
        }
    }
}
