using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageS.Core.Services;
namespace ImageS.Services;

public class FileService : IFileService
{
    public bool ShowOpenFileDialog(out string[] path, string filter, string title, string? root = null, bool isMulti = false)
    {
        var openFileDialog = new Microsoft.Win32.OpenFileDialog
        {
            Filter = filter,
            Title = title,
            Multiselect = isMulti,
            InitialDirectory = root,
            CheckFileExists = true
        };

        var result = openFileDialog.ShowDialog();

        if (result.HasValue && result.Value)
        {
            path = openFileDialog.FileNames;
            return true;
        }

        path = new string[] { };
        return false;
    }

    public bool ShowSaveFileDialog(out string path, string filter, string title, string? root = null)
    {
        throw new NotImplementedException();
    }

    public bool ShowOpenFolderBrowserDialog(out string path, string title, string? root = null, bool isMulti = false)
    {
        throw new NotImplementedException();
    }

    public bool ShowSaveFolderBrowserDialog(out string path, string title, string? root = null)
    {
        throw new NotImplementedException();
    }
}