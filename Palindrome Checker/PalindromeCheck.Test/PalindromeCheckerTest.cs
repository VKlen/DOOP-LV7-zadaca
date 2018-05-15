using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck.Test
{
    [TestFixture]
    public class PalindromeCheckerTest
    {
        
        public void PalindromeChecker_WhenNotPalindrome_ReturnsFalse(string input)
        {
            bool actual = PalindromeChecker.IsPalindrome(input);

            bool expected = false;

            Assert.AreEqual(expected, actual);


        }
        
        public void PalindromeChecker_WhenIsPalindrome_ReturnsTrue(string input)
        {
            bool actual = PalindromeChecker.IsPalindrome(input);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
