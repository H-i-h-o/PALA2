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
        public void TestCase1()
        {
            string TestEmail = "max.muster94@mmail.max";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email contains no "@"; false expected
        [TestMethod]
        public void TestCase2()
        {
            string TestEmail = "max.muster94_mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains more than 1 "@"; false expected
        [TestMethod]
        public void TestCase3()
        {
            string TestEmail = "max.muster96@m@mail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains no "." after the "@"; false expected
        [TestMethod]
        public void TestCase4()
        {
            string TestEmail = "max.muster96@mmailmax";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains more than 1 "." after the "@"; false expected
        [TestMethod]
        public void TestCase5()
        {
            string TestEmail = "max.muster96@m.mail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has only 1 character after the final "."; false expected
        [TestMethod]
        public void TestCase6()
        {
            string TestEmail = "max.muster96@mmail.m";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has 2 characters after the final "."; true expected
        [TestMethod]
        public void TestCase7()
        {
            string TestEmail = "max.muster96@mmail.at";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email has 4 characters after the final "."; true expected
        [TestMethod]
        public void TestCase8()
        {
            string TestEmail = "max.muster96@mmail.comm";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email has 5 characters after the final "."; false expected
        [TestMethod]
        public void TestCase9()
        {
            string TestEmail = "max.muster96@mmail.abcde";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has no character before the "@"; false expected
        [TestMethod]
        public void TestCase10()
        {
            string TestEmail = "@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has 1 character before the "@"; true expected
        [TestMethod]
        public void TestCase11()
        {
            string TestEmail = "z@mmail.max";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email starts with a "."; false expected
        [TestMethod]
        public void TestCase12()
        {
            string TestEmail = ".max.muster@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email ends with a "."; false expected
        [TestMethod]
        public void TestCase13()
        {
            string TestEmail = "max.muster@mmail.max.";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has a "." just before the "@"; false expected
        [TestMethod]
        public void TestCase14()
        {
            string TestEmail = "max.muster.@mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email has a "." just after the "@"; false expected
        [TestMethod]
        public void TestCase15()
        {
            string TestEmail = "max.muster@.mmail.max";
            Assert.IsFalse(Email.CheckEmailInput(TestEmail));
        }

        ///email contains all allowed characters; true expected
        [TestMethod]
        public void TestCase16()
        {
            string TestEmail = "abcdefghijklmnopqrstuvwxyz.ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$'*+-/=?^{|}~_@mmail.com";
            Assert.IsTrue(Email.CheckEmailInput(TestEmail));
        }

        ///email null; exception expected
        [TestMethod]
        public void TestCase17()
        {
            bool ExceptionOccured = false;
            try
            {
                bool Result = Email.CheckEmailInput(null);
            }
            catch (Exception ex)
            {
                ExceptionOccured = true;
            }
            Assert.IsTrue(ExceptionOccured, "As expected an exception occured!");
            
        }

    }
}
