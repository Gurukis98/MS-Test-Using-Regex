using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Regex_UC_10
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestMethod10()
        {
            Console.WriteLine("Enter a Invalid EMails\n");
            string email1 = "abc";
            string email2 = "abc@.com.my";
            string email3 = "abc123@gmail.a";
            string email4 = "abc123@.com";
            string email5 = "abc123@.com.com";
            string email6 = "abc@abc.com";
            string email7 = "abc()*@gmail.com";
            string email8 = "abc@%*.com";
            string email9 = "abc..2002@gmail.com";
            string email10 = "abc.@gmail.com";
            string email11 = "abc@abc@gmail.com";
            string email12 = "abc@gmail.com.1a";
            string email13 = "abc@gmail.com.aa.au";

            if (Regex.Match(email1, "^[a-z]{3}[@]$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email2, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email3, "^[a-z]{3}[0-9]{3}[@][a-z]{5}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email4, "^[a-z0-9]{6}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email5, "^[a-z0-9]{6}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid ");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email6, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email7, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email8, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email9, "^[a-z]{3}[.][0-9]{4}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email10, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email11, "^[a-z]{6}[@][a-z]{5}[.][a-z]{3}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email12, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
            {
                Console.WriteLine("EMail is Valid");
            }
            else
            {
                Console.WriteLine("EMail is Not Valid");
            }
            if (Regex.Match(email13, "^[a-z]{3}[@][a-z]{5}[.][a-z]{3}[.][a-z]{2}$").Success)
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
