using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    public static class TDMock
    {
        public static int[,] GetMock(TDAMockType type)
        {
            switch (type)
            {
                case TDAMockType.first:
                    return new int[,]
                    {
                        { 3, 5, 1 },
                        { 23, 15, 12},
                        { 9, -5, 12 },
                    };

                case TDAMockType.second:
                    return new int[,]
                    {
                        { 4, 9, -10},
                        { 9, 1, 11},
                        { 3, 6, -24},
                    };

                case TDAMockType.third:
                    return new int[,]
                    {
                        { -19, 4, 2},
                        { 10, 8, 3},
                        { -67, -6, -7},
                    };

                case TDAMockType.empty:
                    return new int[,] { };


                default:
                    throw new Exception("a.GetLength(0) and a.GetLength(1) must be > 0");

                case TDAMockType.reflectFirst:
                    return new int[,]
                    {
                        { 3, 23, 9 },
                        { 5, 15, -5},
                        { 1, 12, 12 },
                    };

                case TDAMockType.reflectSecond:
                    return new int[,]
                    {
                        { 4, 9, 3},
                        { 9, 1, 6},
                        { -10, 11, -24},
                    };

            }
        }
        
    }
}
