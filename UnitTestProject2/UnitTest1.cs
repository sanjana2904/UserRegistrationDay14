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
            bool result = program.validateEmail("sanju@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestInvalidEmailName()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateEmail("sanjugmail.com"));
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

        public void TestValidPassword()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("sanjanaks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPassword()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateName("sanjanaks"));
        }
        [TestMethod]
        public void TestValidUppercase()
        {
            Program program = new Program();
            bool result = program.validateUppercase("saNjanak");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidUppercase()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateUppercase("sanjana"));
        }

        [TestMethod]
        public void TestValidNumericcase()
        {
            Program program = new Program();
            bool result = program.validateNumericcase("sanjana5Ks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidNumericcase()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateNumericcase("Sanjana"));

        }

        [TestMethod]
        public void TestValidSpecialCharactercase()
        {
            Program program = new Program();
            bool result = program.validateSpecialCharactercase("sanJana5*ks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidSpecialCharactercase()
        {
            Program program = new Program();
            Assert.ThrowsException<UserException>(() => program.validateName("Sanj5*ana"));

        }
    }
}