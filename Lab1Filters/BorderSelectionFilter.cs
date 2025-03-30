using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Filters
{
    internal class ScharraFilter : EdgeFilter
    {
        public ScharraFilter()
        {
            kernelX = new float[3, 3]
            {
                {3, 0, -3 }, {10, 0, -10}, {3, 0, -3 }
            };

            kernelY = new float[3, 3]
            {
                {3, 10, 3 }, {0, 0, 0}, {-3, -10, -3 }
            };
        }
    }

    class PruittaFilter : EdgeFilter
    { 
        public PruittaFilter()
        {
            kernelX = new float[3, 3]
            {
                {-1, 0, 1 }, {-1, 0, 1}, {-1, 0, 1 }
            };

            kernelY = new float[3, 3]
            {
                {-1, -1, -1 }, {0, 0, 0}, {1, 1, 1 }
            };
        }
    }
}
