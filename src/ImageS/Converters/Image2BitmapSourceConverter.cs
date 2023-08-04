using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using ImageProcessor.Common.Models;
using ImageS.Extension;
using OpenCvSharp.WpfExtensions;

namespace ImageS.Converters;

public class Image2BitmapSourceConverter : BaseValueConverter<Image2BitmapSourceConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not Image image) return Binding.DoNothing;

        image.ToBitmapSource(out var source);
        return BitmapFrame.Create(source);
    }
}