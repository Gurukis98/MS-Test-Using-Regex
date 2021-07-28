using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_8
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestMethod8()
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase, Atleast 1 Numeric Number and Exactly 1 Special Character");
            string rule4 = Console.ReadLine();
            if (Regex.Match(rule4, "^[A-Z0-9a-z~,`!@#$%^&*()_./?'+{}:;<>]{8,}$").Success)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Not Valid");
            }
        }
    }
}
