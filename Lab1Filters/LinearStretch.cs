using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class LinearStretch : Filters
    {
        int minR, maxR, minG, maxG, minB, maxB;
        public LinearStretch()
        {
            minR = 255;
            minG = 255;
            minB = 255;
            maxR = 0;
            maxG = 0;
            maxB = 0;
        }
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color pixel = sourceImage.GetPixel(x, y);
            int nR = Clamp(255 * (pixel.R - minR) / (maxR - minR));
            int nG = Clamp(255 * (pixel.G - minG) / (maxG - minG));
            int nB = Clamp(255 * (pixel.B - minB) / (maxB - minB));
            return Color.FromArgb(nR, nG, nB);
        }
        public override Bitmap processImage(Bitmap image, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    minR = Math.Min(minR, pixel.R);
                    minG = Math.Min(minG, pixel.G);
                    minB = Math.Min(minB, pixel.B);
                    maxR = Math.Max(maxR, pixel.R);
                    maxG = Math.Max(maxG, pixel.G);
                    maxB = Math.Max(maxB, pixel.B);
                }
            }
            for (int i = 0; i < image.Width; i++)
            {
                worker.ReportProgress((int)((float)i / image.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < image.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(image, i, j));
                }
            }
            return resultImage;
        }
    }
}
