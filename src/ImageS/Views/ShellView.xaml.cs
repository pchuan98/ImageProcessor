using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
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
using System.Windows.Shapes;
using HandyWindow = HandyControl.Controls.Window;

namespace ImageS.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : HandyWindow
    {
        public ShellView()
        {
            InitializeComponent();

            CompositionTarget.Rendering += CompositionTarget_Rendering;
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

                Left = left;
                Top = top;
                Height = height;
                Width = width;
            }
            catch
            {
                // ignored
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var collection = new string[]
            {
                Left.ToString(CultureInfo.InvariantCulture),
                Top.ToString(CultureInfo.InvariantCulture),
                Height.ToString(CultureInfo.InvariantCulture),
                Width.ToString(CultureInfo.InvariantCulture)
            };


            Properties.Settings.Default.MainWindowBounds.Clear();
            Properties.Settings.Default.MainWindowBounds.AddRange(collection);
            Properties.Settings.Default.Save();
        }

        private int _frameCount = 0;
        private DateTime _lastTime = DateTime.Now;
        private void CompositionTarget_Rendering(object? sender, EventArgs e)
        {
            // 计算帧率
            _frameCount++;
            var now = DateTime.Now;
            var elapsed = now - _lastTime;
            if (elapsed >= TimeSpan.FromSeconds(1))
            {
                var fps = _frameCount / elapsed.TotalSeconds;
                // 更新界面显示
                FpsLabel.Content = $"FPS: {fps:F0}";
                // 重置计数器
                _frameCount = 0;
                _lastTime = now;
            }
        }
    }
}
