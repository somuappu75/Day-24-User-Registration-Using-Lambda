using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Using_Lambda;

namespace UserTest
{
    /// <summary>
    /// All Test Cases Added 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        [DataRow("Somanath", "Somanath")]
        [DataRow("Som", "Som")]
        [DataRow("s", null)]
        [DataRow("Somusp75", null)]

        public void ValidateFirstname(string a, string expected)
        {

            var actual = UserRegex.ValidateFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        [DataRow("Somanath", "Somanath")]
        [DataRow("Som", "Som")]
        [DataRow("s", null)]
        [DataRow("Somusp75", null)]

        public void ValidateUserLastname(string a, string expected)
        {
            var actual = UserRegex.ValidateLastName(a);
            Assert.AreEqual(expected, actual);
        }

        //passing Sample Email ID and Checking
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = UserRegex.ValidateEmail(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("1 9606484982", "1 9731390823")]
        [DataRow("91 9731390823", "91 9842905050")]
        [DataRow("919740049061", null)]
        public void ValidatePhoneNum(string a, string expected)
        {
            var actual = UserRegex.ValidatePhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Somu@123", "Somo@123")]
        [DataRow("Somu@75$", "Somu@75$")]

        public void ValidatePassword(string a, string expected)
        {
            var actual = UserRegex.ValidatePassWord(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new UserRegex("RegularExpression");
            UserFactory factory = new UserFactory();
            object actual = factory.Test_Method_Parameteized_Constructor("UserRegistration.RegexSample", "RegexSample", "RegularExpression");
            actual.Equals(expected);
        }

    }

}
