using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_7
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethod7()
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase and Atleast 1 Numeric Number");
            string rule3 = Console.ReadLine();
            if (Regex.Match(rule3, "^[A-Z0-9a-z]{8,}$").Success)
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
