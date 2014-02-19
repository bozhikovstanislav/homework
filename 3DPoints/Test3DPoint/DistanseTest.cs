using _3DPoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test3DPoint
{
    
    
    /// <summary>
    ///This is a test class for DistanseTest and is intended
    ///to contain all DistanseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DistanseTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for get_Distance
        ///</summary>
        [TestMethod()]
        public void get_DistanceTest()
        {
          Points3D poit1 = new Points3D(12,23,43); // TODO: Initialize to an appropriate value
            Points3D Point2 = new Points3D(24,56,77); // TODO: Initialize to an appropriate value
            double expected = 48.877; // TODO: Initialize to an appropriate value
            double actual;
            actual = Distanse.get_Distance(poit1, Point2);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
