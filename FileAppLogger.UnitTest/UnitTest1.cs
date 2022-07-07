using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileAppLogger.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Logger.LogToFile("Test Message 002");
        }
    }
}
