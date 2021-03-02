﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculatorKata.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            Calculator calc = new Calculator();

            int actual = calc.Add("");

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void SingleNumberReturnsNumber()
        {
            Calculator calc = new Calculator();

            int actual = calc.Add("5");

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void AddTwoNumbers()
        {
            Calculator calc = new Calculator();

            int actual = calc.Add("5,10");

            Assert.AreEqual(15, actual);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("1,1,1,1", 4)]
        [TestCase("2,1,2,1,2", 8)]
        public void MultipleNumbers(string numbers, int expected)
        {
            Calculator calc = new Calculator();

            int actual = calc.Add(numbers);

            Assert.AreEqual(expected, actual);
        }
    }
}
