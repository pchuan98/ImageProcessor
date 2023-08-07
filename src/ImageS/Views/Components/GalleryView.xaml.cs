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
using ImageS.Core.ViewModels;
using Image = ImageProcessor.Common.Models.Image;

namespace ImageS.Views
{
    /// <summary>
    /// Interaction logic for GalleryView.xaml
    /// </summary>
    public partial class GalleryView : UserControl
    {
        public GalleryView()
        {
            InitializeComponent();
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var view = sender as ListView;
            var vm = this.DataContext as GalleryViewModel;

            if (view == null || vm == null) return;

            if (view.SelectedIndex == -1) return;

            vm.SelectedImage = view.SelectedItem as Image;
        }
    }
}