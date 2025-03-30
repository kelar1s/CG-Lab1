using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class MotionBlurFilter:MatrixFilter
    {
        public MotionBlurFilter()
        {
            int size = 5;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                kernel[i, i] = 1.0f / (float)(size);
            }
        }
    }
}
