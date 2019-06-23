// -----------------------------------------------------------------------
// <copyright file="BitCounter.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Algorithms.CountingBits
{
    using System;
    using System.Collections.Generic;

    public class PositiveBitCounter
    {
        int[] binaryValues;
        const short NUM_BITS = 31;

        public PositiveBitCounter()
        {
            binaryValues = new int[NUM_BITS];
            binaryValues[0] = 1;
            for (int i = 1; i < binaryValues.Length; i++)
            {
                binaryValues[i] = binaryValues[i - 1] * 2;
            }
        }
        public IEnumerable<int> Count(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("Negative values are not allowed.");
            }
            int bitCount = 0;
            IList<int> result = new List<int>();
            for ( int i = 0; i < binaryValues.Length; i++ )
            {
                if ( (input & binaryValues[i]) != 0)
                {
                    bitCount++;
                    result.Add(i);
                }
            }
            result.Insert(0, bitCount);
            return result;
        }
    }
}