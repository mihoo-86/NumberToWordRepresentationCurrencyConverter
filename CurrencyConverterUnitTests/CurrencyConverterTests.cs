using CurrencyConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverterUnitTests
{
    [TestClass]
    public class CurrencyConverterTests
    {

        //1. Input: 0 Output: zero dollars
        //2. Input: 1 Output: one dollar
        //3. Input: 25,1 Output: twenty-five dollars and ten cents
        //4. Input: 0,01 Output: zero dollars and one cent
        //5. Input: 45 100 Output: forty-five thousand one hundred dollars
        //6. Input: 999 999 999,99 Output: nine hundred ninety-nine million nine hundred
        //ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase1()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(0);

            //Assert
            Assert.AreEqual("zero dollars", result);
        }

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase2()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(1);

            //Assert
            Assert.AreEqual("one dollar", result);
        }

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase3()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(25.1m);

            //Assert
            Assert.AreEqual("twenty-five dollars and ten cents", result);
        }

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase4()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(0.01m);

            //Assert
            Assert.AreEqual("zero dollars and one cent", result);
        }

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase5()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(45100);

            //Assert
            Assert.AreEqual("forty-five thousand one hundred dollars", result);
        }

        [TestMethod]
        public void ConvertCurrencyToWords_TestCase6()
        {
            //Arrange
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            //Act
            var result = currencyConverter.ConvertCurrencyToWords(999999999.99m);

            //Assert
            Assert.AreEqual("nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents", result);
        }
    }
}
