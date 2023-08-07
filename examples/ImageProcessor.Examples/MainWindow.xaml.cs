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
using ImageProcessor.Common.Models;
using ImageProcessor.Extensions;
using OpenCvSharp.WpfExtensions;
using Image = ImageProcessor.Common.Models.Image;

namespace ImageProcessor.Examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Image img;

        public MainWindow()
        {
            InitializeComponent();

            var path = @"C:\Users\haeer\Pictures\2.png";

            var path2 = @"C:\Users\haeer\Pictures\1.jpg";

            img = new Image(path2);


            img.ToGray();
            img.Fixed();

            //img.SetInversion(threshold: 0);
            Viewer1.ImageSource = BitmapFrame.Create(img.Present.ToBitmapSource());

            S1.ValueChanged += Changed;
            S2.ValueChanged += Changed;
            S3.ValueChanged += Changed;
        }

        private void Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            Application.Current.Dispatcher.InvokeAsync(() =>
            {
                var v1 = S1.Value;
                var v2 = S2.Value;
                var v3 = S3.Value;

                var map = (LutColormap)v3;
                img.SetLut(map);

                Viewer2.ImageSource = BitmapFrame.Create(img.Present.ToBitmapSource());
            });
        }
    }
}
