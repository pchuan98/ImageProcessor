using HandyControl.Controls;
using System;
using System.ComponentModel;
using System.Windows.Media;

namespace ImageS.Views
{
    /// <summary>
    /// Interaction logic for ProcessorWindow.xaml
    /// </summary>
    public partial class ProcessorView : Window
    {
        public ProcessorView()
        {
            InitializeComponent();

            CompositionTarget.Rendering += CompositionTarget_Rendering;

            ImageS.Helper.WindowHelper.LoadSizeAndPosition(this);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ImageS.Helper.WindowHelper.SaveSizeAndPosition(this);
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
