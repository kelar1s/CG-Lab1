using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1Filters
{
    public class EdgeFilter : Filters
    {
        protected float[,] kernelX;
        protected float[,] kernelY;

        protected override Color calcualteNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            float xR = 0, xG = 0, xB = 0;
            float yR = 0, yG = 0, yB = 0;
            int radius = 1;

            for (int dy = -radius; dy <= radius; dy++)
            {
                for (int dx = -radius; dx <= radius; dx++)
                {
                    int idX = Clamp(x + dx, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + dy, 0, sourceImage.Height - 1);
                    Color pixel = sourceImage.GetPixel(idX, idY);

                    xR += pixel.R * kernelX[dx + radius, dy + radius];
                    xG += pixel.G * kernelX[dx + radius, dy + radius];
                    xB += pixel.B * kernelX[dx + radius, dy + radius];

                    yR += pixel.R * kernelY[dx + radius, dy + radius];
                    yG += pixel.G * kernelY[dx + radius, dy + radius];
                    yB += pixel.B * kernelY[dx + radius, dy + radius];
                }
            }

            int resultR = Clamp((int)Math.Sqrt(xR * xR + yR * yR), 0, 255);
            int resultG = Clamp((int)Math.Sqrt(xG * xG + yG * yG), 0, 255);
            int resultB = Clamp((int)Math.Sqrt(xB * xB + yB * yB), 0, 255);

            return Color.FromArgb(resultR, resultG, resultB);
        }
    }
}
