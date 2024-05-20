using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;

namespace StringManipulation_Test
{
    [TestClass]
    public class CallTest
    {
        [TestMethod]
        public void ConcatenateStrings_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello";
            string string2 = "World!";
            string expected = "Hello World!";

            // Act
            string result = stringOperations.ConcatenateStrings(string1, string2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ReverseString_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            string expected = "!dlroW olleH";

            // Act
            string result = stringOperations.ReverseString(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetStringLength_ReturnInt()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            int expected = string1.Length;

            // Act
            int result = stringOperations.GetStringLength(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveWhitespace_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            string expected = "HelloWorld!";

            // Act
            string result = stringOperations.RemoveWhitespace(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateString_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            int lengthString = 7;
            string expected = "Hello W";

            // Act
            string result = stringOperations.TruncateString(string1, lengthString);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            bool expected = false;

            // Act
            bool result = stringOperations.IsPalindrome(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountOccurrences_ReturnInt()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            char character = 'o';
            int expected = 2;

            // Act
            int result = stringOperations.CountOccurrences(string1, character);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pluralize_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            string expected = "Hello World!s";

            // Act
            string result = stringOperations.Pluralize(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void QuantintyInWords_ReturnString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "Hello World!";
            int quantity = 9;
            string expected = "nine Hello World!s";

            // Act
            string result = stringOperations.QuantintyInWords(string1, quantity);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FromRomanToNumber_ReturnInt()
        {
            // Arrange
            var stringOperations = new StringOperations();
            string string1 = "XXVI";
            int expected = 26;

            // Act
            int result = stringOperations.FromRomanToNumber(string1);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
