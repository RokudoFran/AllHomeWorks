using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHomeWorks.Tests
{
    public class TestDataFifthHW
    {
        public static int[,] GetArrayForTest(int index)
        {
            return index switch
            {
                0 => new int[,] { {5,2,3},{4,1,6} },
                1 => new int[,] { { 7, 8, 6 }, { 4, 5, 3 },{ 1, 2, 9 } },
                2 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                3 => new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetExpectedArrayForTest(int index)
        {
            return index switch
            {
                2 => new int[,] { { 1, 4, 7, }, { 2, 5, 8 }, { 3, 6, 9 } },
                3 => new int[,] { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } },
                _ => new int[,] { { } },
            };
        }

    }
}
