using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestInitialize()]
        public void TestInitialize()
        {
            CustomerList CustList = new CustomerList();
            Customer Cust;

            StringBuilder CustListString = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                //Commented for running other tests
                //Cust = new Customer("Vorname" + i.ToString(), "Nachname" + i.ToString(), "Email" + 1 + "@com.at");
                //CustList.AddCustomer(this, new EventArgsNewCustomer(Cust));

                //CustListString.AppendLine("Vorname" + i.ToString() + "; " + "Nachname" + i.ToString() + "; " + "Email" + 1 + "@com.at");
            }
        }

        [TestMethod()]
        public void PrintCustomerTest()
        {
            Assert.Fail();
        }
    }
}