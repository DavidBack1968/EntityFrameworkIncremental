using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using EntityFrameworkList.Tests.EFContexts;
using EntityFrameworkList.Tests.Interfaces.EFContexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkList.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EFContextTests
    {
        public EFContextTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("Test Started");
        }
        
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            Console.WriteLine("Test Completed");
        }
        
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            using (
                IInternetContext ctx =
                    new InternetContext(
                        new ConnectionStringDefinitions().GetConnectionString(ApplicationEnvironment.Testing,
                            ApplicationDatabase.Internet)))
            {

                int count = ctx.FreightTransactions.Count(ft => ft.CompanyCode == 2);
                Debug.WriteLine(count);
                Assert.IsTrue(count > 0);
            }
        }
    }
}
