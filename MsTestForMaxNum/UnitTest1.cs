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
        /// TC1.3-Given Max Number at 3rd Position return the Same Number
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
        /// <summary>
        /// UC2-given 3 floats Find maximum
        /// </summar
        //TC1.1
        [TestMethod]
        public void Maximum_float_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 30.5f, secondValue = 20.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            FindMaximumNum find = new FindMaximumNum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Float_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 30.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            FindMaximumNum find = new FindMaximumNum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_float_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 10.5f, thirdValue = 30.5f;
            float expected = 30.5f;
            FindMaximumNum find = new FindMaximumNum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC3-
        /// </summary>
        //TC1.1
        [TestMethod]
        public void Maximum_String_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Peach", secondValue = "Banana", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximumNum find = new FindMaximumNum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_String_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Banana", secondValue = "Peach", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximumNum find = new FindMaximumNum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_string_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Carrot";
            string expected = "Peach";
            FindMaximumNum find = new FindMaximumNum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}


