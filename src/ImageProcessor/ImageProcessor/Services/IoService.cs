using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Constant;
using ImageProcessor.Common.Models;

namespace ImageProcessor.Services;

internal static class IoService
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="image"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal static bool ReadFromBytes<T>(out Image image)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="image"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal static bool ReadFromPath(out Image image, ImageType type)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="image"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal static bool ReadFromPath(out Image image, string path)
    {
        throw new NotImplementedException();
    }
}