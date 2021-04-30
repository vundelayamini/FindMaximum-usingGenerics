using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumUsingGenerics;

namespace MsTestForMaxNum
{
    [TestClass]
    public class UnitTest1
    {
        
        /// UC3-
        /// </summary>
        //TC1.1
        [TestMethod]
        public void Maximum_String_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Peach", secondValue = "Banana", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_String_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Banana", secondValue = "Peach", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_string_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Carrot";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }

    
}


