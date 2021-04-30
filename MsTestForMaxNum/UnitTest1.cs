using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumUsingGenerics;

namespace MsTestForMaxNum
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC1.1-Given Max Number at1st Position return the Same Number
        /// </summary>
        [TestMethod]
        public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///TC1.2-Given Max Number at 2nd Position return the Same Number
        /// </summary>
        [TestMethod]
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given Max Number at 3rd Position return the Same Number
        /// </summary>
        [TestMethod]
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            int firstValue = 20, secondValue = 10, thirdValue = 30;
            int expected = 30;
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
