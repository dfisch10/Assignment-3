using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindrome
{
    /// <summary>
    ///     Palindrome class is responsible for determining if an input is equal to a palindrome. 
    /// </summary>
    public class Palindrome
    {
        #region Methods

        /// <summary>
        ///     Is valid checks if a string (word or phrase) input is truely a palindrome.
        /// </summary>
        /// <param name="input">The input to validate.</param>
        /// <returns>If the input is a valid palindrome.</returns>
        public bool IsValid(string input)
        {
            if (input is null)
            {
                return false;
            }
            else
            {
                input = Regex.Replace(input, @"[^0-9a-zA-Z]+", "");
                input = input.ToLower();

                char[] charArray = input.ToCharArray();

                Array.Reverse(charArray);

                string reverseInput = new string(charArray);

                if (input != reverseInput)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            } 
        }
        #endregion
    }
}
