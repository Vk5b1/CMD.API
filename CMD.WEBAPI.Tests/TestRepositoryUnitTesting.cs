using CMD.Repository.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMD.WEBAPI.Tests
{
    /// <summary>
    /// Summary description for TestRepositoryUnitTesting
    /// </summary>
    [TestClass]
    public class TestRepositoryUnitTesting
    {
        TestRepository obj = null;


        [TestInitialize]
        public void Initializer()
        {
            obj = new TestRepository();
        }

        [TestCleanup]
        public void Cleaner()
        {
            obj = null;
        }

        [TestMethod]
        public void GetAllTests_ShouldReturnAllTests()
        {
            var tests = obj.GetAllTests();
            Assert.IsNotNull(tests);
        }

        [TestMethod]
        public void GetTestReports_ShouldReturnAllTestReports()
        {
            var testReports = obj.GetTestReports();
            Assert.IsNotNull(testReports);
        }



    }
}
