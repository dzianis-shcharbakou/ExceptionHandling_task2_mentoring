using ExceptionHandling2;
using NUnit.Framework;
using System;

namespace ExceptionHandlingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PositiveTestConvertToInt()
        {
            string num = "1514";
            string num2 = "-1514";


            int result = IntConverter.ConvertStringToInt(num);
            int result2 = IntConverter.ConvertStringToInt(num2);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(1514, result);
                Assert.AreEqual(-1514, result2);
            });
        }

        [Test]
        public void NegativeTestConvertToInt()
        {
            string numWithLetter = "a12d";
            string emptyString = "";
            string onlyArithmeticSymbols = "-";

            Assert.Multiple(() => 
            {
                FormatException numWithLetterException = Assert.Throws<FormatException>(() => { IntConverter.ConvertStringToInt(numWithLetter); });
                FormatException emptyStringException = Assert.Throws<FormatException>(() => { IntConverter.ConvertStringToInt(emptyString); });
                FormatException onlyArithmeticSymbolsException = Assert.Throws<FormatException>(() => { IntConverter.ConvertStringToInt(onlyArithmeticSymbols); });

                Assert.That(numWithLetterException.Message, Is.EqualTo("Exception: String must contain only numbers!"));
                Assert.That(emptyStringException.Message, Is.EqualTo("Exception: String length cannot be 0!"));
                Assert.That(onlyArithmeticSymbolsException.Message, Is.EqualTo("Exception: String cannot contain only one arithmetic sign!"));
            });
        }
    }
}