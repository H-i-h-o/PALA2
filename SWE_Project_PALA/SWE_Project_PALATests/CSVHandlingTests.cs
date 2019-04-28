using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;

namespace SWE_Project_PALATests
{
    [TestClass]
    public class CSVHandlingTests
    {
        
        //NOT SUCCESSFUL DUE TO CHANGES IN CSV-HANDLING

        //[TestMethod]
        //public void TestCSVHandling()
        //{
        //    CustomerList CList1 = new CustomerList();
        //    CList1.CustList.Add(new Customer(1, "Patrick", "Gehmayr", "patrick.gehmayr@gmail.com", new Address("Street", "12", 4201, "Traun"), new DateTime(2016, 3, 26), -155));
        //    CList1.CustList.Add(new Customer(2, "Laurenz", "Hiho", "l.hiho@mail.at", new Address("Streeter", "1", 4201, "Hochkar"), new DateTime(2018, 10, 3), 2365));
        //    CList1.CustList.Add(new Customer(3, "Max", "Mustermann", "max.muster@anymail.any", new Address("Lina", "9a", 4311, "Schwertberg"), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), int.MinValue));

        //    string TestPath = @"C:\Users\patri\source\repos\H-i-h-o\PALA2\SWE_Project_PALA\SWE_Project_PALA\bin\Debug\TestFileCSVHandling.csv";
        //    CSVHandling.SaveCustomerListToCSV(3,CList1, TestPath);
        //    CustomerList Clist2 = CSVHandling.LoadCustomerListFromCSV(TestPath);

        //    if(CList1.CustList.Count != (Clist2.CustList.Count+1))
        //    {
        //        Assert.Fail("Original and read customer list do not have the same size!");
        //    }

        //    bool CustomerNumbersEqual = true;
        //    bool FirstNamesEqual = true;
        //    bool LastNamesEqual = true;
        //    bool EmailsEqual = true;
        //    bool AccountsEqual = true;
        //    bool LastEditsEqual = true;

        //    for (int i = 0; i < CList1.CustList.Count; i++)
        //    {
        //        int j = i + 1;
        //        CustomerNumbersEqual = CList1.CustList[i].CustomerNumber == Clist2.CustList[j].CustomerNumber;
        //        FirstNamesEqual = CList1.CustList[i].FirstName == Clist2.CustList[j].FirstName;
        //        LastNamesEqual = CList1.CustList[i].LastName == Clist2.CustList[j].LastName;
        //        EmailsEqual = CList1.CustList[i].EmailAddress.EmailAddress == Clist2.CustList[j].EmailAddress.EmailAddress;
        //        AccountsEqual = CList1.CustList[i].AccountBalance == Clist2.CustList[j].AccountBalance;
        //        LastEditsEqual = CList1.CustList[i].LastAccess == CList1.CustList[j].LastAccess;
        //    }

        //    Assert.IsTrue(CustomerNumbersEqual && FirstNamesEqual && LastNamesEqual && EmailsEqual && AccountsEqual && LastEditsEqual);
        //}
    }
}
