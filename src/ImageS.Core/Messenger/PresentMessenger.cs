using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;

namespace ImageS.Core.Messenger;

public static class PresentMessenger
{
    /// <summary>
    /// 切换当前显示效果
    /// </summary>
    /// <param name="Present"></param>
    public record SwitchPresentMessage(Image? Present);

    /// <summary>
    /// 刷新显示效果
    /// </summary>
    public record RefreshPresent();
}