using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SWE_Project_PALATests
{
    [TestClass]
    public class CustomerListTests
    {
        CustomerList TestCustomerList;

        int[] SortByCustomerNumber_expectedResult;
        int[] SortByFirstName_expectedResult;
        int[] SortByLastName_expectedResult;
        int[] SortByEmail_expectedResult;
        int[] SortByAccountBalance_expectedResult;
        int[] SortByLastAccess_expectedResult;

        int[] FilterByFirstName_expectedResult;
        int[] FilterByLastName_expectedResult;
        int[] FilterByEmail_expectedResult;
        int[] FilterByPostCode_expectedResult;
        int[] FilterByCity_expectedResult;

        string SearchFirstName;
        string SearchLastName;
        string SearchEmail;
        string SearchPostCode;
        string SearchCity;

        [TestInitialize]
        public void Initialize()
        {
            TestCustomerList = new CustomerList();
            
            TestCustomerList.CustList.Add(new Customer(4, "Patrick", "Gehmayr", "p.gehmayr@gmail.com", new Adresse("Streeter", "1", 4201, "Wels"),new DateTime(2010, 9, 20), -99));
            TestCustomerList.CustList.Add(new Customer(3, "Laurenz", "Hiho", "l.hiho@mail.at", new Adresse("Hans", "5", 4201, "Wels"),new DateTime(2013, 2, 28), -50));
            TestCustomerList.CustList.Add(new Customer(1, "Luigi", "Italiano", "luigi.italy@imail.com", new Adresse("Winden", "9", 2323, "Schwertberg"),new DateTime(2008, 6, 3), 100));
            TestCustomerList.CustList.Add(new Customer(2, "Max", "Mustermann", "m.muster@mmail.max", new Adresse("Windegg", "166", 3324, "Mauthausen"),new DateTime(2018, 7, 20), 1300));
            TestCustomerList.CustList.Add(new Customer(5, "Anna", "Huber", "huber.anna@hmail.at", new Adresse("Hinterstoßer", "133", 3434, "Perg"),new DateTime(2019, 3, 30), -3000));
            
            SortByCustomerNumber_expectedResult = new int[] {1, 2, 3, 4, 5};
            SortByFirstName_expectedResult = new int[] {5, 3, 1, 2, 4};
            SortByLastName_expectedResult = new int[] {4, 3, 5, 1, 2};
            SortByEmail_expectedResult = new int[] {5, 3, 1, 2, 4};
            SortByAccountBalance_expectedResult = new int[] {5, 4, 3, 1, 2};
            SortByLastAccess_expectedResult = new int[] {1, 4, 3, 2, 5};
            
            FilterByFirstName_expectedResult = new int[] { 1};
            FilterByLastName_expectedResult = new int[] { 3};
            FilterByEmail_expectedResult = new int[] { 2};
            FilterByPostCode_expectedResult = new int[] { 5};
            FilterByCity_expectedResult = new int[] { 3,4};

            SearchFirstName = "luigi";
            SearchLastName = "hih";
            SearchEmail = "muster@mmail.max";
            SearchPostCode = "3434";
            SearchCity = "Wels";
        }

        #region sortTests
        [TestMethod]
        public void TestSortByCustomerNumberAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByCustomerNumber(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByCustomerNumber_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortByCustomerNumberDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByCustomerNumber(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByCustomerNumber_expectedResult[4 - i]);
            }
        }

        [TestMethod]
        public void TestSortByFirstNameAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByFirstName(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByFirstName_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortByFirstNameDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByFirstName(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByFirstName_expectedResult[4-i]);
            }
        }

        [TestMethod]
        public void TestSortByLastNameAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByLastName(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByLastName_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortByLastNameDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByLastName(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByLastName_expectedResult[4-i]);
            }
        }

        [TestMethod]
        public void TestSortByEmailAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByEmail(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByEmail_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortByEmailDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByEmail(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByEmail_expectedResult[4 - i]);
            }
        }

        [TestMethod]
        public void TestSortAccountBalanceAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByAccountBalance(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByAccountBalance_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortAccountBalanceDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByAccountBalance(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByAccountBalance_expectedResult[4-i]);
            }
        }

        [TestMethod]
        public void TestSortLastAccessAscending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByLastAccess(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByLastAccess_expectedResult[i]);
            }
        }

        [TestMethod]
        public void TestSortLastAccessDescending_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByLastAccess(true);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByLastAccess_expectedResult[4-i]);
            }
        }

        #endregion

        #region filterTests

        [TestMethod]
        public void FilterByFirstName_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.FilterByFirstName(SearchFirstName);

            if(TestList.CustList.Count != FilterByFirstName_expectedResult.Length)
            {
                Assert.Fail("Too many or too few customers found.");
            }
            else
            {
                for (int i = 0; i < FilterByFirstName_expectedResult.Length; i++)
                {
                    Assert.IsTrue(FilterByFirstName_expectedResult.Contains(TestList.CustList[i].CustomerNumber));
                }
            }
        }

        [TestMethod]
        public void FilterByLastName_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.FilterByLastName(SearchLastName);

            if (TestList.CustList.Count != FilterByLastName_expectedResult.Length)
            {
                Assert.Fail("Too many or too few customers found.");
            }
            else
            {
                for (int i = 0; i < FilterByLastName_expectedResult.Length; i++)
                {
                    Assert.IsTrue(FilterByLastName_expectedResult.Contains(TestList.CustList[i].CustomerNumber));
                }
            }
        }

        [TestMethod]
        public void FilterByEmail_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.FilterByEmail(SearchEmail);

            if (TestList.CustList.Count != FilterByEmail_expectedResult.Length)
            {
                Assert.Fail("Too many or too few customers found.");
            }
            else
            {
                for (int i = 0; i < FilterByEmail_expectedResult.Length; i++)
                {
                    Assert.IsTrue(FilterByEmail_expectedResult.Contains(TestList.CustList[i].CustomerNumber));
                }
            }
        }

        [TestMethod]
        public void FilterByPostCode_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.FilterByPostCode(SearchPostCode);

            if (TestList.CustList.Count != FilterByPostCode_expectedResult.Length)
            {
                Assert.Fail("Too many or too few customers found.");
            }
            else
            {
                for (int i = 0; i < FilterByPostCode_expectedResult.Length; i++)
                {
                    Assert.IsTrue(FilterByPostCode_expectedResult.Contains(TestList.CustList[i].CustomerNumber));
                }
            }
        }

        [TestMethod]
        public void FilterByCity_Test()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.FilterByCity(SearchCity);

            if (TestList.CustList.Count != FilterByCity_expectedResult.Length)
            {
                Assert.Fail("Too many or too few customers found.");
            }
            else
            {
                for (int i = 0; i < FilterByCity_expectedResult.Length; i++)
                {
                    Assert.IsTrue(FilterByCity_expectedResult.Contains(TestList.CustList[i].CustomerNumber));
                }
            }
        }


        #endregion
    }
}
