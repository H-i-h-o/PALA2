using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;

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

        [TestInitialize]
        public void Initialize()
        {
            TestCustomerList = new CustomerList();

            TestCustomerList.CustList.Add(new Customer(4, "Patrick", "Gehmayr", "p.gehmayr@gmail.com", -99, new Adresse("Streeter", "1", 4201, "Wels"),
                new DateTime(2010, 9, 20)));
            TestCustomerList.CustList.Add(new Customer(3, "Laurenz", "Hiho", "l.hiho@mail.at", -50, new Adresse("Hans", "5", 4201, "Wels"),
                new DateTime(2013, 2, 28)));
            TestCustomerList.CustList.Add(new Customer(1, "Luigi", "Italiano", "luigi.italy@imail.com", 100, new Adresse("Winden", "9", 2323, "Schwertberg"),
                new DateTime(2008, 6, 3)));
            TestCustomerList.CustList.Add(new Customer(2, "Max", "Mustermann", "m.muster@mmail.max", 1300, new Adresse("Windegg", "166", 3324, "Mauthausen"),
                new DateTime(2018, 7, 20)));
            TestCustomerList.CustList.Add(new Customer(5, "Anna", "Huber", "huber.anna@hmail.at", -3000, new Adresse("Hinterstoßer", "133", 3434, "Perg"),
                new DateTime(2019, 3, 30)));

            SortByCustomerNumber_expectedResult = new int[] {1, 2, 3, 4, 5};
            SortByFirstName_expectedResult = new int[] {5, 3, 1, 2, 4};
            SortByLastName_expectedResult = new int[] {4, 3, 5, 1, 2};
            SortByEmail_expectedResult = new int[] {5, 3, 1, 2, 4};
            SortByAccountBalance_expectedResult = new int[] {5, 4, 3, 1, 2};
            SortByLastAccess_expectedResult = new int[] {1, 4, 3, 2, 5};
        }
        [TestMethod]
        public void TestSortByCustomerNumberAscending()
        {
            CustomerList TestList = new CustomerList();
            TestList.CustList = TestCustomerList.SortByCustomerNumber(false);
            for (int i = 0; i < TestCustomerList.CustList.Count; i++)
            {
                Assert.IsTrue(TestCustomerList.CustList[i].CustomerNumber == SortByCustomerNumber_expectedResult[i]);
            }
        }
        // 11 more to go....to be continued
    }
}
