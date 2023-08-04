using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageS.Core.Messenger;

public static class InfoMessenger
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    public record LeftStatusMessage(string Message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    public record RightStatusMessage(string Message);
}