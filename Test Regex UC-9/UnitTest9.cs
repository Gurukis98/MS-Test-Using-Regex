using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_9
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void TestMethod9()
        {
            Console.WriteLine("Enter a Eight EMails\n");
            string email1 = "abc@yahoo.com";
            string email2 = "abc-100@yahoo.com";
            string email3 = "abc.100@yahoo.com";
            string email4 = "abc111@abc.com";
            string email5 = "abc.100@abc.com.au";
            string email6 = "abc@1.com";
            string email7 = "abc@gmail.com.com";
            string email8 = "abc+100@gmail.com";

            if (Regex.Match(email1, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email2, "^[a-z]{3}[-][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email3, "^[a-z]{3}[.][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email4, "^[a-z0-9]{6}[@][a-z]{3}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid ");
            }

            if (Regex.Match(email5, "^[a-z]{3}[.][0-9]{3}[@][a-z]{3}[.][a-z]{3}.[a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email6, "^[a-z]{3}[@][0-9]{1}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email7, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }

            if (Regex.Match(email8, "^[a-z]{3}[+][0-9]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
        }
    }
}
