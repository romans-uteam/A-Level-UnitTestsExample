using System;
using System.Collections;
using System.Security.Cryptography;
using CustomMathLibrary;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class EquationSolve_tests
    {
        private EquationSolveService _equationSolveService;

        [SetUp]
        public void Setup()
        {
            _equationSolveService = new EquationSolveService();
        }

        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(1, 0, 1)]
        [TestCase(int.MaxValue, int.MaxValue, 0)]
        [TestCase(-1000, 0, -1000)]
        public void Sum_Test(int a, int b, int expected)
        {
            // 1. Prepare

            // 2. Execute 
            var sum = _equationSolveService.Sum(a, b);

            // 3. Assertion
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCaseSource(typeof(MyFactoryClass), "TestCases")]
        public double Divide_Test(double a, double b)
        {
            // 1. Prepare
            double result = default(double);

            Assert.DoesNotThrow(() =>
            {
                // 2. Execute 
                result = _equationSolveService.Divide(a, b);
            });

            // 3. Assertion
            return result;
        }

        [Test]
        [TestCase(0, double.MinValue)]
        public void Divide_ExceptionTest(double a, double b)
        {
            // 1. Prepare

            // 3. Assertion
            Assert.Throws(typeof(ArgumentException), () =>
            {
                // 2. Execute 
                var result = _equationSolveService.Divide(a, b);
            });
        }

        [Test]
        [TestCase(0, 100)]
        [TestCase(0, 1)]
        public void GetRandom_Test(int min, int max)
        {
            var result = _equationSolveService.GetRandom(min, max);

            Assert.True(result >= min && result <= max, message: $"{result} should be between {min} and {max}");
        }
    }

    public class MyFactoryClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(12, 3).Returns(4);
                yield return new TestCaseData(12, 2).Returns(6);
                yield return new TestCaseData(12, 4).Returns(3);
            }
        }
    }
}
