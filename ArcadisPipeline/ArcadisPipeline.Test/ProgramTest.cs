using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArcadisPipeline;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArcadisPipeline.Tests
{
    [TestClass()]
    public class ProgramTest
    {
        [TestMethod()]
        public void IsAdultAgeTest()
        {
            Assert.IsTrue(new Program().IsAdultAge(19));
        }

        [TestMethod]
        public void IsAdultAgeTestFail()
        {
            Assert.IsTrue(new Program().IsAdultAge(13));
        }
    }
}