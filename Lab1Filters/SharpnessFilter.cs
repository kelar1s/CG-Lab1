using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class SharpnessFilter: MatrixFilter
    {
        private float[,] sharpnessKernel = new float[,]
       {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
       };
        public SharpnessFilter()
        {
            kernel = sharpnessKernel; 
        }
    }
}
