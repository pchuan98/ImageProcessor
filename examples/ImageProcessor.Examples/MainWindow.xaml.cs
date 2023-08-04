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
        public MainWindow()
        {
            InitializeComponent();

            var path = "C:\\Users\\haeer\\Desktop\\核心文档\\转盘\\images\\1024.png";

            var img = new Image(path);
            img.ToGray();
            img.Inversion();

            Viewer.ImageSource = BitmapFrame.Create(img.GetSrc().ToBitmapSource());
        }
    }
}
