
using System;
using Unittesting.Core.Service;

namespace Unittesting.Core.Tests;

[TestClass]
public sealed class CalculatorTests
{
    private Calculator _calculator;

    [TestInitialize]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        double result = _calculator.Add(6.8, 3.2);
        Assert.AreEqual(9.0, result, 0.001);
    }

    [TestMethod]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        double result = _calculator.Add(-5.5, -3.2);
        Assert.AreEqual(-8.7, result, 0.001);
    }

    [TestMethod]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        double result = _calculator.Add(10.0, -3.5);
        Assert.AreEqual(6.5, result, 0.001);
    }

    [TestMethod]
    public void Add_ZeroValues_ReturnsZero()
    {
        double result = _calculator.Add(0, 0);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        double result = _calculator.Subtract(10.5, 3.2);
        Assert.AreEqual(7.3, result, 0.001);
    }

    [TestMethod]
    public void Subtract_NegativeFromPositive_ReturnsCorrectDifference()
    {
        double result = _calculator.Subtract(5.0, -3.0);
        Assert.AreEqual(8.0, result);
    }

    [TestMethod]
    public void Subtract_FromZero_ReturnsNegativeNumber()
    {
        double result = _calculator.Subtract(0, 5.5);
        Assert.AreEqual(-5.5, result);
    }

    [TestMethod]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        double result = _calculator.Multiply(4.5, 2.0);
        Assert.AreEqual(9.0, result);
    }

    [TestMethod]
    public void Multiply_PositiveAndNegativeNumber_ReturnsNegativeProduct()
    {
        double result = _calculator.Multiply(6.0, -2.5);
        Assert.AreEqual(-15.0, result);
    }

    [TestMethod]
    public void Multiply_TwoNegativeNumbers_ReturnsPositiveProduct()
    {
        double result = _calculator.Multiply(-3.0, -4.0);
        Assert.AreEqual(12.0, result);
    }

    [TestMethod]
    public void Multiply_ByZero_ReturnsZero()
    {
        double result = _calculator.Multiply(5.5, 0);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        double result = _calculator.Divide(10.0, 2.0);
        Assert.AreEqual(5.0, result);
    }

    [TestMethod]
    public void Divide_PositiveByNegative_ReturnsNegativeQuotient()
    {
        double result = _calculator.Divide(15.0, -3.0);
        Assert.AreEqual(-5.0, result);
    }

    [TestMethod]
    public void Divide_NegativeByPositive_ReturnsNegativeQuotient()
    {
        double result = _calculator.Divide(-12.0, 4.0);
        Assert.AreEqual(-3.0, result);
    }

    [TestMethod]
    public void Divide_TwoNegativeNumbers_ReturnsPositiveQuotient()
    {
        double result = _calculator.Divide(-20.0, -4.0);
        Assert.AreEqual(5.0, result);
    }

    [TestMethod]
    public void Divide_ZeroByNumber_ReturnsZero()
    {
        double result = _calculator.Divide(0, 5.0);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        _calculator.Divide(10.0, 0);
    }

    [TestMethod]
    public void Divide_ByZero_ThrowsDivideByZeroExceptionWithMessage()
    {
        var exception = Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(10.0, 0));
        Assert.AreEqual("Cannot divide by zero.", exception.Message);
    }
}
