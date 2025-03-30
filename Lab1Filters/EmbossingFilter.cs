using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class EmbossingFilter: MatrixFilter
    {
        private float[,] embossingKernel = new float[,]
        {
            {0, 1, 0 },
            {-1, 0, 1 },
            { 0, -1, 0 }
        };
        
        public EmbossingFilter()
        {
            kernel = embossingKernel;
        }
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0, resultG = 0, resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighbourColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighbourColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighbourColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighbourColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            resultR = Clamp((int)resultR + 100);
            resultG = Clamp((int)resultG + 100);
            resultB = Clamp((int)resultB + 100);
            return Color.FromArgb(Clamp((int)resultR), Clamp((int)resultG), Clamp((int)resultB));
        }
    }
}
