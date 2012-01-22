using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTime
{
    public class Numbers
    {
        public static IEnumerable<long> Range(long start, long end)
        {
            for (long l = start; l <= end; l++)
                yield return l;
        }
    }
}
