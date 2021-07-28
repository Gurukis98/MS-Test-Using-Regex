using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod5()
        {
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters");
            string rule1 = Console.ReadLine();
            if (Regex.Match(rule1, "^[a-z]{8,}$").Success)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Not Valid ");
            }
        }
    }
}
