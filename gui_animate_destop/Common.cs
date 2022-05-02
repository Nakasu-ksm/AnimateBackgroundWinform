using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui_animate_destop
{
    public static class Common
    {
        public static long NextLong(this Random random, long minValue, long maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentException("minValue is great than maxValue", "minValue");
            }
            long num = maxValue - minValue;
            return minValue + (long)(random.NextDouble() * num);
        }

    }
}
