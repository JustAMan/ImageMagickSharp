﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageMagickSharp
{
    /// <summary> A pixel wand interop. </summary>
    internal static class PixelWandInterop
    {

        #region [Pixel Wand]
        /// <summary> Creates a new pixel wand. </summary>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr NewPixelWand();

        /// <summary> Destroys the pixel wand described by wand. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void ClearPixelWand(IntPtr wand);


        #endregion

        #region [Pixel Wand Color]
        /// <summary> Pixel set color. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="color"> The color. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int PixelSetColor(IntPtr wand, IntPtr color);

        /// <summary> Pixel set color. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="color"> The color. </param>
        /// <returns> An int. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern int PixelSetColor(IntPtr wand, string color);

        /// <summary> Pixel get color as string. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr PixelGetColorAsString(IntPtr wand);

        /// <summary> Pixel get color as normalized string. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> An IntPtr. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern IntPtr PixelGetColorAsNormalizedString(IntPtr wand);

        /// <summary> Pixel get alpha. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> A double. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern double PixelGetAlpha(IntPtr wand);

        /// <summary> Pixel set alpha. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="value"> The value. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void PixelSetAlpha(IntPtr wand, double value);

        /// <summary> Pixel get opacity. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> A double. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern double PixelGetOpacity(IntPtr wand);

        /// <summary> Pixel set opacity. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="value"> The value. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void PixelSetOpacity(IntPtr wand, double value);

        /// <summary> Pixel get red. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> A double. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern double PixelGetRed(IntPtr wand);

        /// <summary> Pixel set red. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="value"> The value. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void PixelSetRed(IntPtr wand, double value);

        /// <summary> Pixel get green. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> A double. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern double PixelGetGreen(IntPtr wand);

        /// <summary> Pixel set green. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="value"> The value. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void PixelSetGreen(IntPtr wand, double value);

        /// <summary> Pixel get blue. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <returns> A double. </returns>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern double PixelGetBlue(IntPtr wand);

        /// <summary> Pixel set blue. </summary>
        /// <param name="wand"> Handle of the wand. </param>
        /// <param name="value"> The value. </param>
        [DllImport(Constants.WandLibrary, CallingConvention = Constants.WandCallingConvention)]
        internal static extern void PixelSetBlue(IntPtr wand, double value);

        #endregion

    }
}
