namespace Calculator.Test;

// XUnit testing

using CalculatorLib;

public class CalculatorTests
{
    private Calculator calculator;


    public CalculatorTests()
    {
        calculator = new Calculator();
    }


    [Fact]
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
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 5, 8)]
    [InlineData(2, 5, 7)]
    public void Add_ReturnCorrectNumber_UsingTestCase(int a, int b, int expected){
        // Action
        int result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}