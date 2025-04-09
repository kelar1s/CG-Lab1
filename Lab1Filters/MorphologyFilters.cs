using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    enum structElement
    {
        Cross,
        Cube
    }
    internal abstract class MorphologyFilters: Filters
    {
        protected bool[,] kernel;
        protected int size, radius;
        public MorphologyFilters(structElement se = structElement.Cube, int sz = 3)
        {
            size = (sz % 2 == 0) ? sz + 1 : sz;
            radius = size / 2;
            kernel = new bool[size, size];
            switch (se)
            {
                case structElement.Cross:
                    for (int i = 0; i < size; i++)
                    {
                        kernel[i, size / 2 + 1] = true;
                    }
                    for (int j = 0; j < sz; j++)
                    {
                        kernel[size / 2 + 1, j] = true;
                    }
                    break;
                case structElement.Cube:
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < sz; j++)
                        {
                            kernel[i, j] = true;
                        }
                    }
                    break;
            }
        }
    }
}
