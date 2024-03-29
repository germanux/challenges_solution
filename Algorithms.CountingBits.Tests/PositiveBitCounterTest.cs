﻿// -----------------------------------------------------------------------
// <copyright file="PositiveBitCounterTest.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace CountingBits.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Payvision.CodeChallenge.Algorithms.CountingBits;

    [TestClass]
    public class PositiveBitCounterTest
    {
        private readonly PositiveBitCounter bitCounter = new PositiveBitCounter();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Count_NegativeValue_ArgumentExceptionExpected()
        {
            this.bitCounter.Count(-2);
        }

        [TestMethod]
        public void Count_Zero_NoOccurrences()
        {
            CollectionAssert.AreEqual(
                expected: new List<int> { 0 },
                actual: this.bitCounter.Count(0).ToList(),
                message: "The result is not the expected");
        }

        [TestMethod]
        public void Count_ValidInput_OneOcurrence()
        {
            CollectionAssert.AreEqual(
                expected: new List<int> { 1, 0 },
                actual: this.bitCounter.Count(1).ToList(),
                message: "The result is not the expected");
        }

        [TestMethod]
        public void Count_ValidInput_MultipleOcurrence()
        {
            CollectionAssert.AreEqual(
                expected: new List<int> { 3, 0, 5, 7 },
                actual: this.bitCounter.Count(161).ToList(),
                message: "The result is not the expected");
        }

        [TestMethod]
        public void Count_ValidInput_TwoBytesMultipleOcurrence()
        {
            CollectionAssert.AreEqual(
                // 161 + 512 + 1024 = 1697
                // 0    0   0   0   0   1   1   0
                // 1    0 	0 	0 	0 	1 	0 	1
                expected: new List<int> { 5, 0, 5, 7, 9, 10 },
                actual: this.bitCounter.Count(161 + 512 + 1024).ToList(),
                message: "The result is not the expected");
        }
    }
}