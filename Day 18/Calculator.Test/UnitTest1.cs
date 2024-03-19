namespace Calculator.Test;

using CalculatorLib;

public class Tests
{
    private Calculator calculator;
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ReturnCorrectNumber()
    {
        // 3A
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Action
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(1, 2, 3)]
    [TestCase(2, 3, 5)]
    [TestCase(3, 5, 8)]
    [TestCase(2, 5, 7)]
    public void Add_ReturnCorrectNumber_UsingTestCase(int a, int b, int expected){
        // Action
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }
}