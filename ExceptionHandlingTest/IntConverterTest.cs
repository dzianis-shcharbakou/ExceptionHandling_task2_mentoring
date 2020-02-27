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

            int result = IntConverter.ConvertToInt(num);

            Assert.AreEqual(1514, result);
        }

        [Test]
        public void NegativeTestConvertToInt()
        {
            Assert.Multiple(() => 
            {
                Assert.Throws<FormatException>(FormatExceptionStringWithAlphabitSymbol, "Input string must not contained any symbols except numbers");
                Assert.Throws<FormatException>(FormatExceptionStringWithEmptyString, "Input string must not contained any symbols except numbers");
                Assert.Throws<FormatException>(FormatExceptionStringMixed, "Input string must not contained any symbols except numbers");
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