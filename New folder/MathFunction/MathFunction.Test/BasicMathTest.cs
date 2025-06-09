namespace MathFunction.Test
{
    [TestClass]
    public class BasicMathTest
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMath bm = new BasicMath();
            double result = bm.Add(10,10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test_SubMethod()
        {
            BasicMath bm = new BasicMath();
            double result = bm.Sub(10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_DivMethod()
        {
            BasicMath bm = new BasicMath();
            double result = bm.Divide(10, 10);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_MulMethod()
        {
            BasicMath bm = new BasicMath();
            double result = bm.Multi(10, 10);
            Assert.AreEqual(100, result);
        }
    }
}