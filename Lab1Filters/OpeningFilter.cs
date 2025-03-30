using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class OpeningFilter: Filters
    {
        DilationFilter dil;
        ErosionFilter er;
        public OpeningFilter(structElement se = structElement.Cube, int sz = 3)
        {
            dil = new DilationFilter(se, sz);
            er = new ErosionFilter(se, sz);
        }
        public override Bitmap processImage(Bitmap image, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            resultImage = er.processImage(image, worker);
            if (resultImage == null) return null;
            resultImage = dil.processImage(resultImage, worker);
            return resultImage;
        }
        public override Color calculateNewPixelColor(Bitmap image, int x, int y)
        {
            return Color.Black;
        }
    }
}
