using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("Enter Your Mobilenumber Like (Eg:91 9919819801)");
            string mobileNumber = Console.ReadLine();
            if (Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}$").Success)
            {
                Console.WriteLine("Mobilenumber is Valid");
            }
            else
            {
                Console.WriteLine("Mobilenumber is Not Valid ");
            }
        }
    }
}
