using System;
using CustomMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomMathLibrary_Tests
{
    [TestClass]
    public class Sum_EquationSolveServiceTests
    {
        private EquationSolveService _equationSolveService;

        [TestInitialize]
        public void BeforeAll()
        {
            _equationSolveService = new EquationSolveService();
        }

        [TestCleanup]
        public void AfterAll()
        {
            _equationSolveService.Dispose();
        }

        [TestMethod]
        public void Sum_Test_1_0()
        {
            // 1. Preparation
            int a = 1;
            int b = 0;

            // 2. Execution
            int sum = _equationSolveService.Sum(a, b);

            // 3. Assertion 
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void Sum_Test_2_2()
        {
            // 1. Preparation
            int a = 2;
            int b = 2;

            // 2. Execution
            int sum = _equationSolveService.Sum(a, b);

            // 3. Assertion 
            Assert.AreEqual(4, sum);
        }


        [TestMethod]
        public void Sum_Test_0_0()
        {
            // 1. Preparation
            int a = 0;
            int b = 0;

            // 2. Execution
            int sum = _equationSolveService.Sum(a, b);

            // 3. Assertion 
            Assert.AreEqual(0, sum);
        }
    }
}
