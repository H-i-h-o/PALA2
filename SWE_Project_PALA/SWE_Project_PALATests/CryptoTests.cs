using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SWE_Project_PALATests
{
    [TestClass()]
    public class CryptoTests
    {
        string[] Input_TestCase1;
        string[] Input_TestCase2;
        string[] Input_TestCase3;

        [TestInitialize()]
        public void TestInitialize()
        {
            Input_TestCase1 = new string[] { "15","Patrick", "Gehmayr","patrick.gehmayr@gmail.com","159","24.03.2019" };
            Input_TestCase2 = new string[] { int.MaxValue.ToString(),string.Empty ,string.Empty, "a!b#c$d%e&f'g*h+i-j/k=l?m^n_o`p{q|r}s~t_u.lastname123456789@ANYMAIL.ANY",int.MinValue.ToString(),string.Empty };
            Input_TestCase3 = new string[] { null, null, null, null, null, null };
        }

        [TestMethod]
        public void TestClassCrypto_Test1_successful()
        {
            string[] DecodedStrings = SWE_Project_PALA.Crypto.DecodeLine(SWE_Project_PALA.Crypto.EncodeLine(Input_TestCase1));
            //Assert.IsTrue(Input_TestCase1 == DecodedStrings);
            //Assert.AreEqual(Input_TestCase1; DecodedStrings);
            //Assert.AreSame(Input_TestCase1; DecodedStrings);

            bool AllStringsEqual = true;

            if(Input_TestCase1.Length == DecodedStrings.Length)
            {
                for (int i = 0; i < Input_TestCase1.Length; i++)
                {
                    AllStringsEqual = AllStringsEqual && (Input_TestCase1[i] == DecodedStrings[i]);
                }
            }
            else
            {
                Assert.Fail("The expected test sting array and the returne string array have not the same size!");
            }
            Assert.IsTrue(AllStringsEqual,"All strings inside the arrays were equal!");
        }

        [TestMethod]
        public void TestClassCrypto_Test2_successful()
        {
            string[] DecodedStrings = SWE_Project_PALA.Crypto.DecodeLine(SWE_Project_PALA.Crypto.EncodeLine(Input_TestCase2));

            bool AllStringsEqual = true;

            if (Input_TestCase2.Length == DecodedStrings.Length)
            {
                for (int i = 0; i < Input_TestCase2.Length; i++)
                {
                    AllStringsEqual = AllStringsEqual && (Input_TestCase2[i] == DecodedStrings[i]);
                }
            }
            else
            {
                Assert.Fail("The expected test sting array and the returne string array have not the same size!");
            }
            Assert.IsTrue(AllStringsEqual, "All strings inside the arrays were equal!");
        }

        [TestMethod]
        public void TestClassCrypto_Test3_exception()
        {
            bool ExceptionOccured = false;
            try
            {
                string[] DecodedStrings = SWE_Project_PALA.Crypto.DecodeLine(SWE_Project_PALA.Crypto.EncodeLine(Input_TestCase3));
            }
            catch(Exception ex)
            {
                ExceptionOccured = true;
            }
            Assert.IsTrue(ExceptionOccured, "As expected an exception occured!");
        }
    }
}
