// ReSharper disable once CheckNamespace
namespace ImageS.Core.Services;

public interface IFileService
{
    /// <summary>
    /// 打开文件对话框
    /// </summary>
    /// <param name="pathCollection">打开文件</param>
    /// <param name="filter"></param>
    /// <param name="title"></param>
    /// <param name="root"></param>
    /// <param name="isMulti">是否多选文件</param>
    /// <returns>是否有选择</returns>
    public bool ShowOpenFileDialog(out string[] pathCollection, string filter, string title, string? root = null, bool isMulti = false);

    /// <summary>
    /// 保存文件对话框
    /// </summary>
    /// <param name="path">保存文件路径</param>
    /// <param name="filter"></param>
    /// <param name="title"></param>
    /// <param name="root"></param>
    /// <returns>是否有保存</returns>
    public bool ShowSaveFileDialog(out string path, string filter, string title, string? root = null);

    /// <summary>
    /// 选择文件夹对话框
    /// </summary>
    /// <param name="path"></param>
    /// <param name="title"></param>
    /// <param name="root"></param>
    /// <param name="isMulti"></param>
    /// <returns></returns>
    public bool ShowOpenFolderBrowserDialog(out string path, string title, string? root = null, bool isMulti = false);

    /// <summary>
    /// 选择保存文件夹对话框
    /// </summary>
    /// <param name="path"></param>
    /// <param name="title"></param>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool ShowSaveFolderBrowserDialog(out string path, string title, string? root = null);
}