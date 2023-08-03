using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandyControl.Controls;
using ImageS.Core.Services;

namespace ImageS.Services;

internal class LogService : ILogService
{
    public void Trace(string msg)
    {
        System.Diagnostics.Debug.WriteLine(msg);
    }

    public void Trace(string msg, Exception ex)
    {
        throw new NotImplementedException();
    }

    public void Debug(string msg)
    {
        System.Diagnostics.Debug.WriteLine(msg);
    }

    public void Debug(string msg, Exception ex)
    {
        throw new NotImplementedException();
    }

    public void Info(string msg)
    {
        throw new NotImplementedException();
    }

    public void Info(string msg, Exception ex)
    {
        throw new NotImplementedException();
    }

    public void Warn(string msg)
    {
        MessageBox.Show(msg);
    }

    public void Warn(string msg, Exception ex)
    {
        throw new NotImplementedException();
    }

    public void Error(string msg)
    {
        throw new NotImplementedException();
    }

    public void Error(string msg, Exception ex)
    {
        
    }

    public void Fatal(string msg)
    {
        throw new NotImplementedException();
    }

    public void Fatal(string msg, Exception ex)
    {
        throw new NotImplementedException();
    }
}