using _3DPoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test3DPoint
{
    
    
    /// <summary>
    ///This is a test class for _3Dpoints_Points3DTest and is intended
    ///to contain all _3Dpoints_Points3DTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _3Dpoints_Points3DTest
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
        ///A test for Points3D Constructor
        ///</summary>
        [TestMethod()]
        public void _3Dpoints_Points3DConstructorTest()
        {
            int x = 12; // TODO: Initialize to an appropriate value
            int y = 12; // TODO: Initialize to an appropriate value
            int z = 12; // TODO: Initialize to an appropriate value
            Points3D target = new Points3D(x, y, z);
         
        }
    }
}
