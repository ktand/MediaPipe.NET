// Copyright (c) homuler and Vignette
// This file is part of MediaPipe.NET.
// MediaPipe.NET is licensed under the MIT License. See LICENSE for details.

using System;
using Mediapipe.Net.Native;

namespace Mediapipe.Net.Gpu
{
    public class Gl
    {
        public const uint GL_TEXTURE_2D = 0x0DE1;

        public static void Flush() => UnsafeNativeMethods.glFlush();

        public static void ReadPixels(int x, int y, int width, int height, uint glFormat, uint glType, IntPtr pixels)
            => UnsafeNativeMethods.glReadPixels(x, y, width, height, glFormat, glType, pixels);
    }
}
