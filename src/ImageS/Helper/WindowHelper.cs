using HandyControl.Tools.Extension;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;
using ImageS.Properties;

namespace ImageS.Helper;

public static class WindowHelper
{
    public static void SaveSizeAndPosition(Window window)
    {
        try
        {
            var collection = new string[]
            {
                window.Left.ToString(CultureInfo.InvariantCulture),
                window.Top.ToString(CultureInfo.InvariantCulture),
                window.Height.ToString(CultureInfo.InvariantCulture),
                window.Width.ToString(CultureInfo.InvariantCulture)
            };


            Settings.Default.MainWindowBounds.Clear();
            Settings.Default.MainWindowBounds.AddRange(collection);
            Settings.Default.Save();
        }
        catch
        {
            // ignored
        }
    }

    public static void LoadSizeAndPosition(Window window)
    {
        try
        {
            //设置位置、大小
            var bounds = Properties.Settings.Default.MainWindowBounds;

            if (bounds is null)
            {
                Properties.Settings.Default.MainWindowBounds = new StringCollection();
                Properties.Settings.Default.Save();
            }
            if (bounds is not { Count: 4 }) throw new Exception();

            if (!double.TryParse(bounds[0], out var left)
                || !double.TryParse(bounds[1], out var top)
                || !double.TryParse(bounds[2], out var height)
                || !double.TryParse(bounds[3], out var width)) throw new Exception();

            window.Left = left;
            window.Top = top;
            window.Height = height;
            window.Width = width;
        }
        catch
        {
            // ignored
        }
    }

}