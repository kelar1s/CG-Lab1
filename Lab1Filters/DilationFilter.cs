using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class DilationFilter:MorphologyFilters
    {
        public DilationFilter(structElement mode = structElement.Cube, int sz = 3) : base(mode, sz)
        {

        }
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int posX, posY;
            List<int> redChanel = new List<int>();
            List<int> greenChanel = new List<int>();
            List<int> blueChanel = new List<int>();
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    posX = Clamp(x + i, 0, sourceImage.Width - 1);
                    posY = Clamp(y + j, 0, sourceImage.Height - 1);
                    if (kernel[i + radius, j + radius])
                    {
                        redChanel.Add(sourceImage.GetPixel(posX, posY).R);
                        greenChanel.Add(sourceImage.GetPixel(posX, posY).G);
                        blueChanel.Add(sourceImage.GetPixel(posX, posY).B);
                    }
                }
            }
            return Color.FromArgb(redChanel.Max(), greenChanel.Max(), blueChanel.Max());
        }
    }
}
