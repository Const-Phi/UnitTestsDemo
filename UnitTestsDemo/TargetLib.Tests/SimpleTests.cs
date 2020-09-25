using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetLib.Tests
{
    public class SimpleTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        public void Add_ValidData_Success(int first, int second, int expectedResult)
        {
            // arrange
            var sut = new Simple();

            // act
            var actualResult = sut.Add(first, second);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test()
        {
            // arrange
            var expectedCount = 10;

            var t = new { X = 10, Y = 20 };

            Console.WriteLine(((dynamic)t).X);

            Console.WriteLine(t.GetType().GetProperty("X")?.GetValue(t));

            var sut = new Simple();

            // act
            var result = sut.Test(expectedCount);

            // (x as T) --> t (T) / null

            var actual = (result as IEnumerable<dynamic>)?.Select(x => x.Output).ToList();

            // assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCount, actual.Count);

            foreach (var item in actual)
            {
                Assert.IsTrue(item >= 0);
            }
        }
    }
}