using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AutotestApplicationExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {

        People PeopleTestTask = new People("lab123Login", "admin", "muhammjad@gmail.com", "89047777385");

        [TestMethod]
        public void TestMethodLogin()
        {
            Assert.AreEqual("lab123Login", PeopleTestTask.login1);
        }
        [TestMethod]
        public void TestMethodPassword()
        {
            Assert.AreEqual("admin", PeopleTestTask.password1);
        }
        [TestMethod]
        public void TestMethodEmail()
        {
            Assert.AreEqual("muhammad@gmail.com", PeopleTestTask.email1);
        }
        [TestMethod]
        public void TestMethodPhone()
        {
            Assert.AreEqual("89047777365", PeopleTestTask.phone1);
        }
    }
}
