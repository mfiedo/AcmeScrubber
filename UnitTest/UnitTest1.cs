using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcmeScrubber;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CodeExtractor codeExtractor = new CodeExtractor();
            string output = codeExtractor.GetCode("28667~Guitar pick_739~FR_TNGN~e5552129-8f0b-4a69-bae2-f7cc139dcd32.xml");
            Assert.AreEqual("TNGN", output);

        }
    }
    
}
