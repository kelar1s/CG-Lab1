﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    class SobelFilter : EdgeFilter
    {
        public SobelFilter()
        {
            kernelX = new float[3, 3];
            kernelY = new float[3, 3];
            float[] sobelCoeffs = new float[3] { 1, 2, 1 };
            for (int i = 0; i < 3; i++)
            {
                kernelX[i, 0] = -sobelCoeffs[i];
                kernelX[i, 2] = sobelCoeffs[i];
            }
            for (int i = 0; i < 3; i++)
            {
                kernelY[0, i] = -sobelCoeffs[i];
                kernelY[2, i] = sobelCoeffs[i];
            }
        }
    }
}
