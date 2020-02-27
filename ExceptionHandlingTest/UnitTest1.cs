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
            Assert.Throws<FormatException>(FormatExceptionString);
        }

        private void FormatExceptionString()
        {
            string num = "15g";
            IntConverter.ConvertToInt(num);
        }
    }
}