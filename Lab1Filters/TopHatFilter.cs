using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class TopHatFilter:Filters
    {
        OpeningFilter op;
        Bitmap tmp;
        public TopHatFilter(structElement se = structElement.Cube, int sz = 3)
        {
            op = new OpeningFilter(se, sz);
        }
        public override Bitmap processImage(Bitmap image, BackgroundWorker worker)
        {
            Bitmap res = new Bitmap(image.Width, image.Height);
            tmp = op.processImage(image, worker);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color sourceCol = image.GetPixel(i, j);
                    Color openCol = tmp.GetPixel(i, j);
                    int red = Clamp(sourceCol.R - openCol.R);
                    int green = Clamp(sourceCol.G - openCol.G);
                    int blue = Clamp(sourceCol.B - openCol.B);
                    Color resCol = Color.FromArgb(red, green, blue);
                    res.SetPixel(i, j, resCol);
                }
            }
            return res;
        }
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return Color.Black;
        }
    }
}
