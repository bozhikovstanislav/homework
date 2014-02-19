using _3DPoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test3DPoint
{
    
    
    /// <summary>
    ///This is a test class for GenericListTest and is intended
    ///to contain all GenericListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GenericListTest
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
        ///A test for addelement
        ///</summary>
        public void addelementTestHelper<T>()
        {
            GenericList<T> target = new GenericList<T>(); // TODO: Initialize to an appropriate value
            T element = default(T); // TODO: Initialize to an appropriate value
            target.addelement(element);
            
        }

        [TestMethod()]
        public void addelementTest()
        {
            addelementTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        public void MaxTestHelper<T, T1>()

            where T1 : IComparable<T>
        {
            GenericList<T> target = new GenericList<T>(); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            object a = target;
            T a1 = (T)a;
            //actual = a1.Max<T>();
           // Assert.AreEqual(expected, actual);
         
        }

        [TestMethod()]
        public void MaxTest()
        {
           
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        public void MinTestHelper<T, T1>()

            where T1 : IComparable<T>
        {
            GenericList<T> target = new GenericList<T>(); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            object a = target;
            T a1 = (T)a;
            //actual = a1.Min<T>();
           // Assert.AreEqual(expected, actual);
     
        }

        [TestMethod()]
        public void MinTest()
        {
          
        }

        /// <summary>
        ///A test for ResizeData
        ///</summary>
        public void ResizeDataTestHelper<T>()
        {
            GenericList_Accessor<T> target = new GenericList_Accessor<T>(); // TODO: Initialize to an appropriate value
            target.ResizeData();
          
        }

        [TestMethod()]
        [DeploymentItem("3DPoints.dll")]
        public void ResizeDataTest()
        {
            ResizeDataTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for clear
        ///</summary>
        public void clearTestHelper<T>()
        {
            GenericList<T> target = new GenericList<T>(); // TODO: Initialize to an appropriate value
            target.clear();
          
        }

        [TestMethod()]
        public void clearTest()
        {
            clearTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for findVaue
        ///</summary>
        public void findVaueTestHelper<T>()
        {
            GenericList<T> target = new GenericList<T>(); // TODO: Initialize to an appropriate value
            T value = default(T); // TODO: Initialize to an appropriate value
            target.findVaue(value);
            
        }

        [TestMethod()]
        public void findVaueTest()
        {
            findVaueTestHelper<GenericParameterHelper>();
        }
    }
}
