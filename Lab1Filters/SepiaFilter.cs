using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    class SepiaFilter : Filters
    {
        protected override Color calcualteNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            double intensity = 0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B;
            int intIntensity = (int)intensity;
            int k = 20;
            int r = Clamp(intIntensity + 2 * k, 0, 255);
            int g = Clamp((int)(intIntensity + 0.5 * k), 0, 255);
            int b = Clamp(intIntensity - k, 0, 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
