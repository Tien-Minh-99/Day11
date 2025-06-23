using Unity.Jobs;
using Unity.Burst;
using UnityEngine;
using Unity.Collections;
using System;
using Unity.Collections.LowLevel.Unsafe;

namespace PaintDotNet.Data.PhotoshopFileType
{
    internal enum DecodeType
    {
        RGB32 = 0,
        Grayscale32 = 1,
        RGB = 2,
        CMYK = 3,
        Bitmap = 4,
        Grayscale = 5,
        Indexed = 6,
        Lab = 7
    }
}