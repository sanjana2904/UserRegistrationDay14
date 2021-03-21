using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationDay14;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            Program program = new Program();
            bool result = program.validateName("Sanjana");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestInvalidFirstName()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateName("sanjana"));
        }
        [TestMethod]
        public void TestEmailName()
        {
            Program program = new Program();
            bool result = program.validateName("sanjugmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestInvalidEmailName()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateName("sanjugmail.com"));
        }

        [TestMethod]
        public void TestValidPhoneNumber()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("91 7708796223");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPhoneNumber()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateName("917708796223"));
        }


    }
}