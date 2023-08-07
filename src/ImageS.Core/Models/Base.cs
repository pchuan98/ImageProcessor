using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageS.Core.Models;

/// <summary>
/// 常规三元数据类型，最大最小和阈值
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="Minimum"></param>
/// <param name="Maximum"></param>
/// <param name="Threshold"></param>
public record TripleValue<T>(T Minimum, T Maximum, T Threshold);