using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : HandyControl.Controls.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title.Header = SystemBackdropType.ToString();
        }

        int Count = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SystemBackdropType = (HandyControl.Tools.BackdropType)((++Count) % 5 + 1);
            this.Title.Header = SystemBackdropType.ToString();
        }
        
    }
}
