using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeltaStore;

namespace UnitTestProject_DeltaStore
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void IsValidString()
        {
            bool isNull = true;
            bool isValid = true;
            string validString = ValidInput.Name();

            if (String.IsNullOrEmpty(validString))
                isValid = false;

            Assert.AreEqual(isValid, isNull);
        }

    }
}
