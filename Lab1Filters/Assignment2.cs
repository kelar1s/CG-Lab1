using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1Filters
{
    internal class Assignment2:Filters
    {
        GlassFilter glassFilter;
        SepiaFilter sepiaFilter;
        GrayScaleFilter grayScaleFilter;
        InvertFilter invertFilter;
        public Assignment2()
        {
            glassFilter = new GlassFilter();
            sepiaFilter = new SepiaFilter();
            grayScaleFilter = new GrayScaleFilter();
            invertFilter = new InvertFilter();
        }
        public override Color calculateNewPixelColor(Bitmap image, int x, int y)
        {
            float otnoshenie = (float)image.Width / (float)image.Height;
            if ((x / otnoshenie > y) && (x / (otnoshenie) > image.Width / otnoshenie - y))
            {
                return glassFilter.calculateNewPixelColor(image, x, y);
            }  
            if((x / otnoshenie < y) && (x / (otnoshenie) > image.Width / otnoshenie - y))
            {
                return sepiaFilter.calculateNewPixelColor(image, x, y);
            }
            if((x / otnoshenie < y) && (x / (otnoshenie) < image.Width / otnoshenie - y))
            {
                return grayScaleFilter.calculateNewPixelColor(image, x, y);
            }
            if((x / otnoshenie > y) && (x / (otnoshenie) < image.Width / otnoshenie - y))
            {
                return invertFilter.calculateNewPixelColor(image, x, y);
            }
            else return image.GetPixel(x, y);
        }
    }
}
