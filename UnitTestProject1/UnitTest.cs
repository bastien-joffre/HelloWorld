using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using HelloWorld;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private Message getMessageWithFakes(string name, int hour, int day)
        {
            return new Message(
                new FakeEnvironmentVariables(name),
                new FakeDate(hour, day),
                9, 13, 18);
        }

        [TestMethod]
        public void TestGetHelloMessageBonjour()
        {
            Message message = getMessageWithFakes("José", 11, 2);
            string result = message.getHelloMessage();
            Assert.AreEqual(result, "Bonjour José");
        }

        [TestMethod]
        public void TestGetHelloMessageBonApresMidi()
        {
            Message message = getMessageWithFakes("Maria", 15, 3);
            string result = message.getHelloMessage();
            Assert.AreEqual(result, "Bon après-midi Maria");
        }

        [TestMethod]
        public void TestGetHelloMessageBonsoir()
        {
            Message message = getMessageWithFakes("André", 20, 4);
            string result = message.getHelloMessage();
            Assert.AreEqual(result, "Bonsoir André");
        }

        [TestMethod]
        public void TestGetHelloMessageBonWeekEnd()
        {
            Message message = getMessageWithFakes("Geneviève", 5, 22);
            string result = message.getHelloMessage();
            Assert.AreEqual(result, "Bon week-end Geneviève");
        }
    }
}
