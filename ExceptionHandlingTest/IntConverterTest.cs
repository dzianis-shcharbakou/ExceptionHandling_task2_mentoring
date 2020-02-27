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
            string num = "15";

            int result = IntConverter.ConvertToInt(num);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void NegativeTestConvertToInt()
        {
            Assert.Multiple(() => 
            {
                Assert.Throws<FormatException>(FormatExceptionStringWithAlphabitSymbol);
                Assert.Throws<FormatException>(FormatExceptionStringWithEmptyString);
                Assert.Throws<FormatException>(FormatExceptionStringMixed);
            });
        }

        private void FormatExceptionStringWithAlphabitSymbol()
        {
            string num = "a";
            IntConverter.ConvertToInt(num);
        }

        private void FormatExceptionStringWithEmptyString()
        {
            string num = "";
            IntConverter.ConvertToInt(num);
        }

        private void FormatExceptionStringMixed()
        {
            string num = "1a2 34";
            IntConverter.ConvertToInt(num);
        }
    }
}