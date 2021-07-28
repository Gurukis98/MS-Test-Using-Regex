using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Enter Your EMail Like (Eg:abc01@gmail.com)");
            string email = Console.ReadLine();
            if (Regex.Match(email, "^[0-9a-z]{1,}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid ");
            }
        }
    }
}
