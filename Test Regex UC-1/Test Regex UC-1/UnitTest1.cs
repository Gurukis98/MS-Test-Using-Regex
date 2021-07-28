using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Enter Your Firstname Starts with Capital and it Have Minimum 3 Character");
            string firstName = Console.ReadLine();
            if (Regex.Match(firstName, "^[A-Z][A-Za-z]{2,}$").Success)
            {
                Console.WriteLine("Firstname is Valid");
            }
            else
            {
                Console.WriteLine("Firstname is Not Valid");
            }
        }
    }
}
