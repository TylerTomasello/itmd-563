﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proj5_grad_tomasello;

namespace MortgageTests
{
    [TestClass]
    public class UnitTest1
    {
        //Tested if each year and rate worked with 0
        [TestMethod]
        public void TestZeroYear15()
        {
            double mort = CalcMortgage.CalcMonthlyPayment(0, 15, .25);
            Assert.AreEqual(0.00, mort);
        }

        [TestMethod]
        public void TestZeroYear30()
        {
            double mort = CalcMortgage.CalcMonthlyPayment(0, 30, .25);
            Assert.AreEqual(0.00, mort);
        }

        [TestMethod]
        public void TestZeroYearOther()
        {
            double mort = CalcMortgage.CalcMonthlyPayment(0, 45, .25);
            Assert.AreEqual(0.00, mort);
        }

        //Sample test of using rate 1%
        [TestMethod]
        public void TestRate1()
        {
            double mort = CalcMortgage.CalcMonthlyPayment(1000, 15, 1.00);
            double f = (double)mort;

            Assert.AreNotEqual(5.98, mort);
        }

        //Sample test using rate 2%
        [TestMethod]
        public void TestRate2()
        {
            double mort = CalcMortgage.CalcMonthlyPayment(1000, 15, 2.00);
            double f = (double)mort;

            Assert.AreNotEqual(6.44, mort);
        }
    }
}
