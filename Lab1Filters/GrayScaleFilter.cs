using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    class GrayScaleFilter : Filters
    {
        protected override Color calcualteNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double intensity = (0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B);
            int intIntensity = (int)intensity;
            Color resultColor = Color.FromArgb(intIntensity, intIntensity, intIntensity);
            return resultColor;
        }
    }
}
