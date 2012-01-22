using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTime
{
    class Numbers
    {
        public static IEnumerable<long> Range(long start, long length)
        {
            for (long l = start; l < length; l++)
                yield return l;
        }
    }
}
