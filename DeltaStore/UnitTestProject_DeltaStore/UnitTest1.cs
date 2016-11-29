using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeltaStore;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject_DeltaStore
{
    [TestClass]
    public class UnitTest1
    {
        Manager manager = new Manager();

        List<string> InstrumentNames { get; set; }

        [TestMethod]
        public void IsValidString()
        {

            InstrumentNames = manager.Instruments
           .Select(x => x.Name)
           .ToList();


            bool isNull = true;
            bool isValid = true;
            string validString = ValidInput.Name(InstrumentNames);

            if (String.IsNullOrEmpty(validString))
                isValid = false;

            Assert.AreEqual(isValid, isNull);
        }

        [TestMethod]
        public void IsNotDuplicate()
        {


            string expectedResult = ValidInput.Name(InstrumentNames);
            bool isDuplicate = false;
            bool isPresentInList = false;
            if (String.IsNullOrEmpty(expectedResult))
                isDuplicate = true;

            Assert.AreEqual(isDuplicate, isPresentInList);

        }

    }
}
