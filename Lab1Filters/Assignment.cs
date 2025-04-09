using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class Assignment: MatrixFilter
    {
        public Assignment(int strength = 9)
        {
            int size = strength;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                int j = size - 1 - i;
                kernel[i, j] = 1.0f / (float)size;
            }
        }
    }
}
