using CustomMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomMathLibrary_Tests
{
    [TestClass]
    public class Divide_EquationSolveServiceTests
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
        public void Divide_Test_4_2()
        {
            // 1. Preparation
            double a = 4, b = 2;

            // 2. Execution
            double result = _equationSolveService.Divide(a, b);

            // 3. Assertion 
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Divide_Test_4_4()
        {
            // 1. Preparation
            double a = 4, b = 4;

            // 2. Execution
            double result = _equationSolveService.Divide(a, b);

            // 3. Assertion 
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_Test_DecimalA_intB()
        {
            // 1. Preparation
            double a = 2.5, b = 2;

            // 2. Execution
            double result = _equationSolveService.Divide(a, b);

            // 3. Assertion 
            Assert.AreEqual(1.25, result);
        }

        [TestMethod]
        public void Divide_Test_4_0()
        {
            // 1. Preparation
            double a = 4, b = 0;

            // 2. Execution
            double result = _equationSolveService.Divide(a, b);

            // 3. Assertion 
            Assert.AreEqual(0, result);
        }
    }
}