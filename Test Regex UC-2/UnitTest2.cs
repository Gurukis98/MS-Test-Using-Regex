using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Enter Your Lastname Starts with Capital and it Have Minimum 3 Character");
            string lastName = Console.ReadLine();
            if (Regex.Match(lastName, "^[A-Z][A-Za-z]{2,}$").Success)
            {
                Console.WriteLine("Lastname is Valid");
            }
            else
            {
                Console.WriteLine("Lastname is Not Valid");
            }
        }
    }
}
