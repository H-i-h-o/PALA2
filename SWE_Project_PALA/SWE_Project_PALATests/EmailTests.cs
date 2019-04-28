using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE_Project_PALA;

namespace SWE_Project_PALATests
{
    [TestClass]
    public class EmailTests
    {
        ///valid email; true expected
        [TestMethod]
        public void TestID04_EmailTest1()
        {
            string TestEmail = "max.muster94@mmail.max";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email contains no "@"; false expected
        [TestMethod]
        public void TestID05_EmailTest2()
        {
            string TestEmail = "max.muster94_mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains more than 1 "@"; false expected
        [TestMethod]
        public void TestID06_EmailTest3()
        {
            string TestEmail = "max.muster96@m@mail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains no "." after the "@"; false expected
        [TestMethod]
        public void TestID07_EmailTest4()
        {
            string TestEmail = "max.muster96@mmailmax";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains more than 1 "." after the "@"; false expected
        [TestMethod]
        public void TestID08_EmailTest5()
        {
            string TestEmail = "max.muster96@m.mail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has only 1 character after the final "."; false expected
        [TestMethod]
        public void TestID09_EmailTest6()
        {
            string TestEmail = "max.muster96@mmail.m";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has 2 characters after the final "."; true expected
        [TestMethod]
        public void TestID10_EmailTest7()
        {
            string TestEmail = "max.muster96@mmail.at";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email has 4 characters after the final "."; true expected
        [TestMethod]
        public void TestID11_EmailTest8()
        {
            string TestEmail = "max.muster96@mmail.comm";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email has 5 characters after the final "."; false expected
        [TestMethod]
        public void TestID12_EmailTest9()
        {
            string TestEmail = "max.muster96@mmail.abcde";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has no character before the "@"; false expected
        [TestMethod]
        public void TestID13_EmailTest10()
        {
            string TestEmail = "@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has 1 character before the "@"; true expected
        [TestMethod]
        public void TestID14_EmailTest11()
        {
            string TestEmail = "z@mmail.max";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email starts with a "."; false expected
        [TestMethod]
        public void TestID15_EmailTest12()
        {
            string TestEmail = ".max.muster@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email ends with a "."; false expected
        [TestMethod]
        public void TestID16_EmailTest13()
        {
            string TestEmail = "max.muster@mmail.max.";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has a "." just before the "@"; false expected
        [TestMethod]
        public void TestID17_EmailTest14()
        {
            string TestEmail = "max.muster.@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has a "." just after the "@"; false expected
        [TestMethod]
        public void TestID18_EmailTest15()
        {
            string TestEmail = "max.muster@.mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains all allowed characters; true expected
        [TestMethod]
        public void TestID19_EmailTest16()
        {
            string TestEmail = "abcdefghijklmnopqrstuvwxyz.ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$'*+-/=?^{|}~_@mmail.com";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email null; exception expected
        [TestMethod]
        public void TestID20_EmailTest17()
        {
            bool ExceptionOccured = false;
            try
            {
                bool Result = Email.CheckEmailInput(null);
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                ExceptionOccured = true;
            }
            Assert.IsTrue(ExceptionOccured, "As expected an exception occured!");
            
        }

    }
}
