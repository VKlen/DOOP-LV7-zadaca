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
        [TestCase("palica")]
        public void PalindromeChecker_WhenNotPalindrome_ReturnsFalse(string input)
        {
            bool actual = PalindromeChecker.IsPalindrome(input);

            bool expected = false;

            Assert.AreEqual(expected, actual);


        }
        [TestCase("")] // Counts as a palindrome
        [TestCase("A but tuba.")]
        [TestCase("Aibohphobia")]
        [TestCase("Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.")]
        [TestCase("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!")]
        public void PalindromeChecker_WhenIsPalindrome_ReturnsTrue(string input)
        {
            bool actual = PalindromeChecker.IsPalindrome(input);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
