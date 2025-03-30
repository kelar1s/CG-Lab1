using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    class MoveLeftFilter : Filters 
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (x + 50 < sourceImage.Width)
            {
                return sourceImage.GetPixel(x + 50, y);
            }
            else { return Color.FromArgb(0, 0, 0); }
        }
    }
    class MoveRightFilter : Filters 
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (x - 50 >= 0)
            {
                return sourceImage.GetPixel(x - 50, y);
            }
            else { return Color.FromArgb(0, 0, 0); }
        }
    }

    class Rotate90DegreesFilter : Filters
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2; //центр поворота

            double phi = Math.PI / 2; //угол поворота

            int new_x = (int)((x - x0) * Math.Cos(phi)) - (int)((y - y0) * Math.Sin(phi)) + x0;
            int new_y = (int)((x - x0) * Math.Sin(phi)) + (int)((y - y0) * Math.Cos(phi)) + y0;

            if (new_x >= 0 && new_x < sourceImage.Width && new_y >= 0 && new_y < sourceImage.Height)
            {
                return sourceImage.GetPixel(new_x, new_y);
            }
            else
            {
                return Color.FromArgb(0, 0, 0);

            }
        }
    }

    class VerticalWaveFilter : Filters
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int xX = x;
            int yY = y + (int)(20 * Math.Sin(2 * Math.PI * x / 60));

            xX = Clamp(xX, 0, sourceImage.Width - 1);
            yY = Clamp(yY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(xX, yY);
        }
    }

    class HorizontalWaveFilter : Filters
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int xX = x + (int)(20 * Math.Sin(2 * Math.PI * y / 30));
            int yY = y;

            xX = Clamp(xX, 0, sourceImage.Width - 1);
            yY = Clamp(yY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(xX, yY);
        }
    }
}
