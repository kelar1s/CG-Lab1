using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class GrayWorldFilter:Filters
    {
        int allR = 0, allG = 0, allB = 0;
        float avg;
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color pixel = sourceImage.GetPixel(x, y);
            int pixelR = (int)((pixel.R * avg) / allR);
            int pixelG = (int)((pixel.G * avg) / allG);
            int pixelB = (int)((pixel.B * avg) / allB);
            Color nPixel = Color.FromArgb(Clamp(pixelR), Clamp(pixelG), Clamp(pixelB));
            return nPixel;
        }
        public override Bitmap processImage(Bitmap image, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    allR += pixel.R;
                    allG += pixel.G;
                    allB += pixel.B;
                }
            }
            if (worker.CancellationPending) return null;
            avg = (allR + allB + allG) / 3;
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
