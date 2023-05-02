namespace TaskLib
{
    using System;
    using System.Linq;

    public class StringHelpers
    {
        /// <summary>
        /// Method returning specific word from given input text.
        /// </summary>
        /// <param name="input">input text</param>
        /// <param name="wordNumberToFind">Parameter presenting word number to be returned</param>
        /// <returns>
        /// Specific word from a given text. We assume that only considered separator of words is space (' ').
        /// Example 1: GetWordFromText("one two three", 2) should return "two"
        /// Example 2: GetWordFromText("one;two three", 2) should return "three"
        /// Example 3: GetWordFromText("one", 1) should return "one"
        /// When input parameter wordNumberToFind is less than 1, method should throw
        /// ArgumentOutOfRangeException. When input text does not have enough words
        /// (GetWordFromText("one", 2)), method should throw ArgumentException. 
        /// When input is null method should throw `ArgumentNullException`.
        /// Method should ignore all spaces in the beginning and in the end of input text.
        /// </returns>
        public string GetWordFromText(string input, int wordNumberToFind)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var words = input.Trim().Split(' ');

            if (wordNumberToFind < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(wordNumberToFind), "wordNumberToFind must be greater than 0");
            }

            if (wordNumberToFind > words.Length)
            {
                throw new ArgumentException($"input does not have enough words to get the {wordNumberToFind}th word", nameof(wordNumberToFind));
            }

            return words[wordNumberToFind - 1];
        }

        /// <summary>
        /// Method returning reversed string of an input one.
        /// </summary>
        /// <param name="input">input string to be reversed</param>
        /// <returns>
        /// Example 1: Reverse("one") should return "eno"
        /// Example 2: Reverse("abcd dcba") should return "abcd dcba"
        /// Method should return empty string, if empty string is passed as an input parameter
        /// </returns>
        public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            return new string(input.Reverse().ToArray());
        }
    }
}
