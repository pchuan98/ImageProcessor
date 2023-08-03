// ReSharper disable once CheckNamespace
namespace ImageS.Core.Services;

/**
 * 消息数据格式
 *
 * 1、[Class] - [Method] - [Message]
 */

public interface ILogService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Trace(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Trace(string msg, Exception ex);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Debug(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Debug(string msg, Exception ex);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Info(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Info(string msg, Exception ex);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Warn(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Warn(string msg, Exception ex);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Error(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Error(string msg, Exception ex);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Fatal(string msg);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="ex"></param>
    public void Fatal(string msg, Exception ex);
}