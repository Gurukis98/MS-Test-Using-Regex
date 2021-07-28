using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_6
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod6()
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters and 1 Uppercase");
            string rule2 = Console.ReadLine();
            if (Regex.Match(rule2, "^[A-Za-z]{8,}$").Success)
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
