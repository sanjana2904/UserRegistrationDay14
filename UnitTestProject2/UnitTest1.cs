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
    }
}