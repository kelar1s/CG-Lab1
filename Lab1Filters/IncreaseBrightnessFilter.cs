using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    class IncreaseBrightnessFilter : Filters
    {
        protected override Color calcualteNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            const int cnst = 50;
            int r = Clamp(sourceColor.R + cnst, 0, 255);
            int g = Clamp(sourceColor.G + cnst, 0, 255);
            int b = Clamp(sourceColor.B + cnst, 0, 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
