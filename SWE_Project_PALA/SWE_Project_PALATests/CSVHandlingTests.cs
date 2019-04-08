using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;

namespace SWE_Project_PALATests
{
    [TestClass]
    public class CSVHandlingTests
    {
        
        [TestMethod]
        public void TestCSVHandling()
        {
            CustomerList CList1 = new CustomerList();
            CList1.CustList.Add(new Customer(1, "Patrick", "Gehmayr", "patrick.gehmayr@gmail.com", -155, new Adresse("Street", "12", 4201, "Traun"), new DateTime(2016, 3, 26)));
            CList1.CustList.Add(new Customer(2, "Laurenz", "Hiho", "l.hiho@mail.at", 2365, new Adresse("Streeter", "1", 4201, "Hochkar"), new DateTime(2018, 10, 3)));
            CList1.CustList.Add(new Customer(3, "Max", "Mustermann", "max.muster@anymail.any", int.MinValue, new Adresse("Lina", "9a", 4311, "Schwertberg"), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)));

            string TestPath = @"C:\Users\patri\source\repos\H-i-h-o\PALA2\SWE_Project_PALA\SWE_Project_PALA\bin\Debug\TestFileCSVHandling.csv";
            CSVHandling.SaveCustomerListToCSV(CList1, TestPath);
            CustomerList Clist2 = CSVHandling.LoadCustomerListFromCSV(TestPath);

            if(CList1.CustList.Count != Clist2.CustList.Count)
            {
                Assert.Fail("Original and read customer list do not have the same size!");
            }

            bool CustomerNumbersEqual = true;
            bool FirstNamesEqual = true;
            bool LastNamesEqual = true;
            bool EmailsEqual = true;
            bool AccountsEqual = true;
            bool LastEditsEqual = true;

            for (int i = 0; i < CList1.CustList.Count; i++)
            {
                CustomerNumbersEqual = CList1.CustList[i].CustomerNumber == Clist2.CustList[i].CustomerNumber;
                FirstNamesEqual = CList1.CustList[i].FirstName == Clist2.CustList[i].FirstName;
                LastNamesEqual = CList1.CustList[i].LastName == Clist2.CustList[i].LastName;
                EmailsEqual = CList1.CustList[i].EmailAddress.EmailAddress == Clist2.CustList[i].EmailAddress.EmailAddress;
                AccountsEqual = CList1.CustList[i].AccountBalance == Clist2.CustList[i].AccountBalance;
                LastEditsEqual = CList1.CustList[i].LastAccess == CList1.CustList[i].LastAccess;
            }

            Assert.IsTrue(CustomerNumbersEqual && FirstNamesEqual && LastNamesEqual && EmailsEqual && AccountsEqual && LastEditsEqual);
            //Assert.AreEqual(CList1;Clist2);
        }
    }
}
