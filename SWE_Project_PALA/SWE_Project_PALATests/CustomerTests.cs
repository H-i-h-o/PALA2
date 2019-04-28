using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                Cust = new Customer(i,"Vorname" + i.ToString(), "Nachname" + i.ToString(), new Email("Email" + i.ToString() + "@com.at"), new Address( "Street" + i, i.ToString(), i + i, "City" + i));
                CustList.AddCustomer(this, new EventArgsCustomerChange(Cust));

                CustListString.AppendLine(i + "; " + "Vorname" + i.ToString() + "; " + "Nachname" + i.ToString() + "; " + "Email" + i.ToString() + "@com.at" + "; " + "Street" + i + "; " + i + "; " + i + i + "; " + "City" + i);
            }
        }

        [TestMethod()]
        public void PrintCustomerTest()
        {
            Assert.Fail();
        }
    }
}