using System.Collections.Generic;

namespace Euler.Utility
{
    internal static class PanDigital
    {
        public static IEnumerable<long> GetAll()
        {
            for (long i0 = 1; i0 <= 9; i0++)
            {
                for (long i1 = 0; i1 <= 9; i1++)
                {
                    if (i1 == i0) continue;
                    for (long i2 = 0; i2 <= 9; i2++)
                    {
                        if (i2 == i0 || i2 == i1) continue;
                        for (long i3 = 0; i3 <= 9; i3++)
                        {
                            if (i3 == i0 || i3 == i1 || i3 == i2) continue;
                            for (long i4 = 0; i4 <= 9; i4++)
                            {
                                if (i4 == i0 || i4 == i1 || i4 == i2 || i4 == i3) continue;
                                for (long i5 = 0; i5 <= 9; i5++)
                                {
                                    if (i5 == i0 || i5 == i1 || i5 == i2 || i5 == i3 || i5 == i4) continue;
                                    for (long i6 = 0; i6 <= 9; i6++)
                                    {
                                        if (i6 == i0 || i6 == i1 || i6 == i2 || i6 == i3 || i6 == i4 || i6 == i5)
                                            continue;
                                        for (long i7 = 0; i7 <= 9; i7++)
                                        {
                                            if (i7 == i0 || i7 == i1 || i7 == i2 || i7 == i3 || i7 == i4 || i7 == i5 ||
                                                i7 == i6) continue;
                                            for (long i8 = 0; i8 <= 9; i8++)
                                            {
                                                if (i8 == i0 || i8 == i1 || i8 == i2 || i8 == i3 || i8 == i4 || i8 == i5 ||
                                                    i8 == i6 || i8 == i7) continue;
                                                for (long i9 = 0; i9 <= 9; i9++)
                                                {
                                                    if (i9 == i0 || i9 == i1 || i9 == i2 || i9 == i3 || i9 == i4 ||
                                                        i9 == i5 || i9 == i6 || i9 == i7 || i9 == i8) continue;

                                                    yield return i9 + i8 * 10 + i7 * 100 + i6 * 1000 + i5 * 10000 + i4 * 100000 +
                                                        i3 * 1000000 + i2 * 10000000 + i1 * 100000000 + i0 * 1000000000;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}